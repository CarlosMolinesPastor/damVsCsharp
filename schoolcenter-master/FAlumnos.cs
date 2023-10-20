using System;
using System.Linq;
using System.Windows.Forms;

namespace CENTRO_ESCOLAR
{
    public partial class FAlumnos : Form
    {
        public FAlumnos()
        {
            InitializeComponent();
        }
        private SqlHelper sqlhelper;
        private int pos;
        //#############################################################################################
        //Carga del Formulario, nos vamos a la posicion 0
        //#############################################################################################

        private void FAlumnos_Load(object sender, EventArgs e)
        {
            pos = 0;
            string cadenaSql = "SELECT * FROM Alumnos";
            string tabla = "Alumnos";
            sqlhelper = new SqlHelper(cadenaSql, tabla);

            //Llenamos el DataGridView  con el metodo publico ds de sqlAyuda que devuelve el Dataset
            //y llenamos el datagrid
            dGridAlumnos.DataSource = sqlhelper.dsAlumno().Tables[tabla];

            //Evitamos que el usuario pueda cambiar el orden de las columnas..
            //El codigo lo he buscado por internet
            foreach (DataGridViewColumn col in dGridAlumnos.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //Casrgamos los combos con los datos de la tabla cursos Añadimos las propiedades Displaymemeber que
            //es lo  que se ve y valuemember que es lo que se guarda que es el valor que almacenamos en la BD
            cmbCurs.DataSource = sqlhelper.dsCurso().Tables["Curso"];
            //Le decimos que nos muestre el nombre y nos cargue el Id para trabajar con el
            cmbCurs.DisplayMember = "Nombre";
            cmbCurs.ValueMember = "Id";
            //Le damos el valor que muestre para el combobox
            cmbCurs.SelectedValue = dGridAlumnos.Rows[pos].Cells[3].Value;
            cmbBuscar.SelectedIndex = 1;
            //Hacemos lo mismo con el cmbBuscar2 pero lo dejamos no visible para despues cuando en el combo de
            //busqueda sleccionemos el Codigo lo hagamos visible
            cmbBuscar2.DataSource = sqlhelper.dsCurso().Tables["Curso"];
            cmbBuscar2.DisplayMember = "Nombre";
            cmbBuscar2.ValueMember = "Id";
            cmbBuscar2.Visible = false;
            //Cargamos las label con los numeros de registro 
            txtRegActual.Text = (pos + 1).ToString();
            txtRegTotal.Text = sqlhelper.numAlumnos.ToString();
            bNuevo.Enabled = true;
            bGuardar.Enabled = true;
            bActualizar.Enabled = true;
            bBorrar.Enabled = true;
        }
        //#############################################################################################
        //Metodo mostrar registro y mostar posicion del datagrid
        //#############################################################################################

        private void MostrarRegistro(int pos)
        {
            //Instanciamos el objeto alumno de la clase alumno
            Alumno alumno;
            
            //Llmamos al metodo de la clase SqlAyuda para que nos devuelva el alumno
            alumno = sqlhelper.DevuelveAlumno(pos);
            if (alumno != null)
            {
                txtCod.Text = alumno.Dni;
                txtNombre.Text = alumno.Nombre;
                txtTelefono.Text = alumno.Telefono;
                cmbCurs.SelectedValue = alumno.CodCurso;
            }
        }
        private void dGridAlumnos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            pos = e.RowIndex;//Posicion actual de la fila igualado a la posicion
            MostrarRegistro(pos); //mostramos posicion
            txtRegActual.Text = (pos + 1).ToString();//mostramos la posicion actual en el txt y la global
            txtRegTotal.Text = sqlhelper.numAlumnos.ToString();
        }
        //#############################################################################################
        //Busqueda
        //#############################################################################################

        //Metodo para buscar en la base de datos, utilizamos una query de SQL para buscar por cadena parecida
        //%like% al campo de texto de busqueda y lo cargamos en el dataset para despues mostrarlo en el datagrid
        private void bBuscar_Click(object sender, EventArgs e)
        {
            //Variables, tabla y cadenaconexion para pasarlo a la clase sqlhelper. valor en este caso es el
            //campo de la tabla y campotxt es el campo de texto de busqueda, creamos la nueva conexion se
            //carga el dataset que se devuelve por dsAlumno() y así mostramos los resultados en el datagrid
            string valor, campotxt, tabla, cadenaConexion;

            tabla = "Alumnos";
            valor = cmbBuscar.Text;
            campotxt = txtBuscar.Text.ToUpper();

            // llamada para parsear el txt en numero
            if (valor == "Curso")
            {
                campotxt = cmbBuscar2.SelectedValue.ToString();
            }
            //Metodo buscar, llamamos a la conexion sqlhelper de Alumnos
            cadenaConexion = ("SELECT * from Alumnos where " + valor + " like '%" + campotxt + "%' ");
            sqlhelper = new SqlHelper(cadenaConexion, tabla);
            //Llenamos el DataGridView  con el metodo publico ds de sqlAyuda que devuelve el Dataset
            dGridAlumnos.DataSource = sqlhelper.dsAlumno().Tables[tabla];
            dGridAlumnos.Refresh();
        }
        //Creamos un metodo para que cuando detecte que cambia el texto del combo buscar principal, se active el
        //segundo combobox para poder elegir entre los campos que se desplegan
        private void cmbBuscar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text == "Curso")
            {
                cmbBuscar2.Visible = true;
                cmbBuscar2.SelectedIndex = 0;
            }
        }
        private void cmbBuscar2_Leave(object sender, EventArgs e)
        {
            txtBuscar.Text = cmbBuscar2.Text;
            cmbBuscar2.Visible = false;
        }

        //Boton de refresco que vuelve a cargar el dataadapter y dataset de toda la tabla
        private void bRefrescar_Click(object sender, EventArgs e)
        {
            FAlumnos_Load(sender, e);
            txtBuscar.Text = "";
        }
        //#############################################################################################
        // Nuevo Alumno
        //#############################################################################################
        private void bNuevo_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            cmbCurs.Text = "";
            MessageBox.Show("Añade un Alumno nuevo y selecciona el boton GUARDAR");
            txtCod.Focus();//Devolvemos el foco al campo de texto
            bBorrar.Enabled = false;
            bActualizar.Enabled = false;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            int codigoCurso;
            string dni, nombre, telefono;
            if (txtCod.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "" || cmbCurs.Text == "")
                MessageBox.Show("Los campos no pueden estar vacios, corrige el error.");
            else
            {
                dni = txtCod.Text.ToUpper();
                nombre = txtNombre.Text.ToUpper();
                telefono = txtTelefono.Text.ToUpper();
                codigoCurso = Convert.ToInt32(cmbCurs.SelectedValue);
                Alumno alumno = new Alumno(dni, nombre, telefono, codigoCurso);
                sqlhelper.CrearAlumno(alumno);
                //Ahora nos vamos al ultimo registro en el datagrid, pero para asegurarnos que entra nos vamos a
                //la celda en particular
                dGridAlumnos.CurrentCell = dGridAlumnos.Rows[sqlhelper.numAlumnos - 1].Cells[0];
                //Mostramos en los txtBox las posiciones
                txtRegActual.Text = (pos + 1).ToString();
                txtRegTotal.Text = sqlhelper.numAlumnos.ToString();
                //Actualizar formulario
                FAlumnos_Load(sender, e);

            }

        }
        //#############################################################################################
        // Borrar Alumno
        //#############################################################################################
        private void bBorrar_Click(object sender, EventArgs e)
        {
            DialogResult ok, ultimo;
            //Declaramos una variable para la posicion puesto que si utilizamos la variable global "pos" tenemos
            //el problema que al depender el mostrar registro del datagriid y de la posicion que tenemos, nos salimos
            //de los margenes y se produce un error. 
            //private void dGridAlumnos_RowEnter nos lleva a mostrarRegistro y al eliminar el Alumno deja de estar en el ds
            int p = Convert.ToInt32(dGridAlumnos.CurrentRow.Index);

            //con la variable dialog result nos aseguramos que realmente queremos borarr el Alumno y las diferentes
            //excepciones para no salirnos de los casos, que haya mas de un registro o que 1 o menos y si hay el ultimo desactvar
            //el datagrid
            ok = MessageBox.Show("Seguro que quieres borrar el registro de la base de datos?",
                "Contesta", MessageBoxButtons.YesNo);
            if (ok == DialogResult.Yes)
            {
                if (dGridAlumnos.Rows.Count > 1)
                {
                    if (p > 0) //Si la posicion es mas que 0 entonces nos vamos a la fila anterior para no provocar
                               //el error de lectura
                    {
                        dGridAlumnos.CurrentCell = dGridAlumnos.Rows[p - 1].Cells[0];
                        sqlhelper.EliminarAlumno(p);
                        MessageBox.Show("Registro Borrado de la Base de Datos");
                        FAlumnos_Load(sender, e);

                    }
                    else //si no nos vamos a la ultima posicion
                    {
                        dGridAlumnos.CurrentCell = dGridAlumnos.Rows[(sqlhelper.numAlumnos - 1)].Cells[0];
                        sqlhelper.EliminarAlumno(p);
                        MessageBox.Show("Registro Borrado de la Base de Datos");
                        FAlumnos_Load(sender, e);
                    }

                }
                else
                {
                    ultimo = MessageBox.Show("Es el último registro de la base de datos, seguro que quieres borrarlo??",
                "Contesta", MessageBoxButtons.YesNo);
                    if (ok == DialogResult.Yes)
                    {
                        sqlhelper.EliminarAlumno(p);
                        MessageBox.Show("Registro Borrado de la Base de Datos");
                    }
                }
            }
            else
                MessageBox.Show("Operacion anulada por el usuario");
        }

        //#############################################################################################
        //ACTUALIZAR
        //#############################################################################################
        private void bActualizar_Click(object sender, EventArgs e)
        {
            int curso;
            string dni, nombre, telefono;
            
            //Jugamos con las propiedades del combobox, le decimos que cargue en el datasource del combo el dataset
            //de la tabla curso, y le decimos que coja el valor de la primera columna y por ultimo que convierta lo
            //( hecho ya en Form_load) seleccionado a entero para instancias así el alumno y llamar al metodo
            //ActualizarAlumno
           
            if (txtCod.Text == ""|| txtNombre.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                pos = Convert.ToInt32(dGridAlumnos.CurrentRow.Index);//Posicion del datagrid
                dni = txtCod.Text.ToUpper();
                nombre = txtNombre.Text.ToUpper();
                telefono = txtTelefono.Text.ToUpper();
                curso = Convert.ToInt32(cmbCurs.SelectedValue);
                Alumno alumno = new Alumno(dni, nombre, telefono, curso);
                sqlhelper.ActualizarAlumno(alumno, pos);
                FAlumnos_Load(sender, e);
            }
        }

        //#############################################################################################
        //DESPLAZAMIENTO BOTONES
        //#############################################################################################
        private void bPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            dGridAlumnos.CurrentCell = dGridAlumnos.Rows[pos].Cells[1];
        }
        private void bAnterior_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                dGridAlumnos.CurrentCell = dGridAlumnos.Rows[pos].Cells[1];
            }
            else
            {
                MessageBox.Show("Es el primer registro!!");
            }
        }
        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (pos < sqlhelper.numAlumnos - 1)
            {
                pos = pos + 1;
                dGridAlumnos.CurrentCell = dGridAlumnos.Rows[pos].Cells[1];
            }
            else
                MessageBox.Show("Es el ultimo registro!!");
        }
        private void bUltimo_Click(object sender, EventArgs e)
        {
            pos = sqlhelper.numAlumnos - 1;
            dGridAlumnos.CurrentCell = dGridAlumnos.Rows[pos].Cells[1];
        }
        //#############################################################################################
        //CONTROL DE CAMPOS
        //#############################################################################################
        private void txtCod_Leave(object sender, EventArgs e)
        {
            DialogResult ok;
            if (txtCod.Text.Length == 0 || txtCod.Text.Length > 9)
            {
                ok = MessageBox.Show("El DNI tiene que tener un tamaño de 1 a 9 digitos y letras \n\n Quiere " +
                    "usted continuar editando el DNI??", "Conteste", MessageBoxButtons.YesNo);
                if (ok == DialogResult.Yes)
                {
                    txtCod.Text = "";
                    txtCod.Focus();
                }
                else FAlumnos_Load(sender, e);
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            DialogResult ok;
            if (txtTelefono.Text.Length == 0 || txtTelefono.Text.Length > 9)
            {
                ok = MessageBox.Show("El TELEFONO tiene que tener un tamaño de 1 a 9 digitos y letras \n\n Quiere " +
                    "usted continuar editando elk telefono??");
                if (ok == DialogResult.Yes)
                {
                    txtTelefono.Text = "";
                    txtTelefono.Focus();
                }
                else FAlumnos_Load(sender, e);
            }
        }

        //#############################################################################################
        //ACCESO AL FORMULARIO CURSOS
        //#############################################################################################
        private void bNCurso_Click(object sender, EventArgs e)
        {
            //Abrimos el formulario para añadir un curso nuevo y despues añadimos en la
            //propidad de getFocus del Formulario que cuando reciba el foco que recargue el propio formulario
            FCursos cursos = new FCursos();
            cursos.ShowDialog();
        }

        //#############################################################################################
        //MANTENER COMBOBOX ACTUALIZADOS
        //#############################################################################################


        private void cmbBuscar2_Enter(object sender, EventArgs e)
        {
            sqlhelper = new SqlHelper("Select * from Curso", "Curso");
            cmbBuscar2.DataSource = sqlhelper.dsCurso().Tables["Curso"];
            cmbBuscar2.Refresh();
        }

        private void cmbCurs_Enter(object sender, EventArgs e)
        {
            //Para actualizar los datos del combo cuando se produce un cambio en la tabla, tenemos
            //que acceder de nuevo a carcgar los datos nuevos del dataset en el combo
            sqlhelper = new SqlHelper("Select * from Curso", "Curso");
            cmbCurs.DataSource = sqlhelper.dsCurso().Tables["Curso"];
            cmbCurs.Refresh();
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
