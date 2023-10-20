using System;
using System.Linq;
using System.Windows.Forms;

namespace CENTRO_ESCOLAR
{
    public partial class FProfesores : Form
    {
        public FProfesores()
        {
            InitializeComponent();
        }
        private SqlHelper sqlhelper;
        private int pos;
        //#############################################################################################
        //Carga del Formulario, nos vamos a la posicion 0
        //#############################################################################################

        private void FProfesores_Load(object sender, EventArgs e)
        {
            pos = 0;
            string cadenaSql = "SELECT * FROM Profesores";
            string tabla = "Profesores";
            sqlhelper = new SqlHelper(cadenaSql, tabla);

            //Llenamos el DataGridView  con el metodo publico ds de sqlAyuda que devuelve el Dataset
            //y llenamos el datagrid
            dGridProfesores.DataSource = sqlhelper.dsProfesor().Tables[tabla];
            dGridProfesores.Refresh();
            //Evitamos que el usuario pueda cambiar el orden de las columnas..
            //El codigo lo he buscado por internet
            foreach (DataGridViewColumn col in dGridProfesores.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Casrgamos los combos con los datos de la tabla cursos Añadimos las propiedades Displaymemeber que
            //es lo  que se ve y valuemember que es lo que se guarda que es el valor que almacenamos en la BD
            cmbCurso.DataSource = sqlhelper.dsCurso().Tables["Curso"];
            //Le decimos que nos muestre el nombre y nos cargue el Id para trabajar con el
            cmbCurso.DisplayMember = "Nombre";
            cmbCurso.ValueMember = "Id";
            cmbCurso.SelectedValue = dGridProfesores.Rows[pos].Cells[4].Value;
            cmbBuscar.SelectedIndex = 1;
            //Hacemos lo mismo con el cmbBuscar2 pero lo dejamos no visible para despues cuando en el combo de
            //busqueda sleccionemos el Codigo lo hagamos visible
            cmbBuscar2.DataSource = sqlhelper.dsCurso().Tables["Curso"];
            cmbBuscar2.DisplayMember = "Nombre";
            cmbBuscar2.ValueMember = "Id";
            cmbBuscar2.Visible = false;
            //Cargamos las label con los numeros de registro 
            txtRegActual.Text = (pos + 1).ToString();
            txtRegTotal.Text = sqlhelper.numProfesores.ToString();
            //Botones Visibilidad
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
            //Instanciamos el objeto profesor de la clase profesor
            Profesor profesor;

            //Llmamos al metodo de la clase SqlAyuda para que nos devuelva el profesor
            profesor = sqlhelper.DevuelveProfesor(pos);
            if (profesor != null)
            {
                txtCod.Text = profesor.Dni;
                txtNombre.Text = profesor.Nombre;
                txtTelefono.Text = profesor.Telefono;
                txtEmail.Text = profesor.CorreoE;
                cmbCurso.SelectedValue = profesor.CodCurso;
            }
        }
        private void dGridProfesores_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            pos = e.RowIndex;//Posicion actual de la fila igualado a la posicion
            MostrarRegistro(pos); //mostramos posicion
            txtRegActual.Text = (pos + 1).ToString();//mostramos la posicion actual en el txt y la global
            txtRegTotal.Text = sqlhelper.numProfesores.ToString();
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
            //carga el dataset que se devuelve por dsProfesor() y así mostramos los resultados en el datagrid
            string valor, campotxt, tabla, cadenaConexion;

            tabla = "Profesores";
            valor = cmbBuscar.Text;
            campotxt = txtBuscar.Text.ToUpper();

            // llamada para parsear el txt en numero
            if (valor == "CursoTutor")
            {
                campotxt = cmbBuscar2.SelectedValue.ToString();
            }
            //Metodo buscar, llamamos a la conexion sqlhelper de Profesores
            cadenaConexion = ("SELECT * from Profesores where " + valor + " like '%" + campotxt + "%' ");
            sqlhelper = new SqlHelper(cadenaConexion, tabla);
            //Llenamos el DataGridView  con el metodo publico ds de sqlAyuda que devuelve el Dataset
            dGridProfesores.DataSource = sqlhelper.dsProfesor().Tables[tabla];
            dGridProfesores.Refresh();
        }
        //Creamos un metodo para que cuando detecte que cambia el texto del combo buscar principal, se active el
        //segundo combobox para poder elegir entre los campos que se desplegan
        private void cmbBuscar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text == "CursoTutor")
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
            FProfesores_Load(sender, e);
            txtBuscar.Text = "";
        }
        //#############################################################################################
        // Nuevo Profesor
        //#############################################################################################
        private void bNuevo_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            cmbCurso.Text = "";
            MessageBox.Show("Añade un Profesor nuevo y selecciona el boton GUARDAR");
            txtCod.Focus();//Devolvemos el foco al campo de texto
            bBorrar.Enabled = false;
            bActualizar.Enabled = false;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            int codigoCurso;
            string dni, nombre, telefono, email;
            if (txtCod.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || cmbCurso.Text == "")
                MessageBox.Show("Los campos no pueden estar vacios, corrige el error.");
            else
            {
                dni = txtCod.Text.ToUpper();
                nombre = txtNombre.Text.ToUpper();
                telefono = txtTelefono.Text.ToUpper();
                email = txtEmail.Text.ToUpper();
                codigoCurso = Convert.ToInt32(cmbCurso.SelectedValue);
                Profesor profesor = new Profesor(dni, nombre, telefono, email, codigoCurso);
                sqlhelper.CrearProfesor(profesor);
                //Ahora nos vamos al ultimo registro en el datagrid, pero para asegurarnos que entra nos vamos a
                //la celda en particular
                dGridProfesores.CurrentCell = dGridProfesores.Rows[sqlhelper.numProfesores - 1].Cells[0];
                //Mostramos en los txtBox las posiciones
                txtRegActual.Text = (pos + 1).ToString();
                txtRegTotal.Text = sqlhelper.numProfesores.ToString();
                //Actualizar formulario
                FProfesores_Load(sender, e);
            }

        }
        //#############################################################################################
        // Borrar Profesor
        //#############################################################################################
        private void bBorrar_Click(object sender, EventArgs e)
        {
            DialogResult ok, ultimo;
            //Declaramos una variable para la posicion puesto que si utilizamos la variable global "pos" tenemos
            //el problema que al depender el mostrar registro del datagriid y de la posicion que tenemos, nos salimos
            //de los margenes y se produce un error. 
            //private void dGridProfesores_RowEnter nos lleva a mostrarRegistro y al eliminar el Profesor deja de estar en el ds
            int p = Convert.ToInt32(dGridProfesores.CurrentRow.Index);

            //con la variable dialog result nos aseguramos que realmente queremos borarr el Profesor y las diferentes
            //excepciones para no salirnos de los casos, que haya mas de un registro o que 1 o menos y si hay el ultimo desactvar
            //el datagrid
            ok = MessageBox.Show("Seguro que quieres borrar el registro de la base de datos?",
                "Contesta", MessageBoxButtons.YesNo);
            if (ok == DialogResult.Yes)
            {
                if (dGridProfesores.Rows.Count > 1)
                {
                    if (p > 0) //Si la posicion es mas que 0 entonces nos vamos a la fila anterior para no provocar
                               //el error de lectura
                    {
                        dGridProfesores.CurrentCell = dGridProfesores.Rows[p - 1].Cells[0];
                        sqlhelper.EliminarProfesor(p);
                        MessageBox.Show("Registro Borrado de la Base de Datos");
                        FProfesores_Load(sender, e);
                    }
                    else //si no nos vamos a la ultima posicion
                    {
                        dGridProfesores.CurrentCell = dGridProfesores.Rows[(sqlhelper.numProfesores - 1)].Cells[0];
                        sqlhelper.EliminarProfesor(p);
                        MessageBox.Show("Registro Borrado de la Base de Datos");
                        FProfesores_Load(sender, e);
                    }

                }
                else
                {
                    ultimo = MessageBox.Show("Es el último registro de la base de datos, seguro que quieres borrarlo??",
                "Contesta", MessageBoxButtons.YesNo);
                    if (ok == DialogResult.Yes)
                    {
                        sqlhelper.EliminarProfesor(p);
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
            int curso; //variables para acumular el valor de los campos de texto para crear nuevo Profesor y
                       //llamar al metodo ActualizarProfesor con Profesor y posicion que sacamos del datagrid y
                       //actualizamos el datagrid 
            string dni, nombre, telefono, email;
           
            //Jugamos con las propiedades del combobox, le decimos que cargue en el datasource del combo el dataset
            //de la tabla curso, y le decimos que coja el valor de la primera columna y por ultimo que convierta lo
            //( hecho ya en Form_load) seleccionado a entero para instancias así el profesor y llamar al metodo
            //ActualizarProfesor

            curso = Convert.ToInt32(cmbCurso.SelectedValue);
            if (txtCod.Text == "" || txtNombre.Text == "" || txtEmail.Text =="")
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                pos = Convert.ToInt32(dGridProfesores.CurrentRow.Index);//Posicion del datagrid
                dni = txtCod.Text.ToUpper();
                nombre = txtNombre.Text.ToUpper();
                telefono = txtTelefono.Text.ToUpper();
                email = txtEmail.Text.ToUpper();
                Profesor profesor = new Profesor(dni, nombre, telefono, email, curso);
                sqlhelper.ActualizarProfesor(profesor, pos);
                FProfesores_Load(sender, e);
            }
        }

        //#############################################################################################
        //DESPLAZAMIENTO BOTONES
        //#############################################################################################
        private void bPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            dGridProfesores.CurrentCell = dGridProfesores.Rows[pos].Cells[1];
        }
        private void bAnterior_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                dGridProfesores.CurrentCell = dGridProfesores.Rows[pos].Cells[1];
            }
            else
            {
                MessageBox.Show("Es el primer registro!!");
            }
        }
        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (pos < sqlhelper.numProfesores - 1)
            {
                pos = pos + 1;
                dGridProfesores.CurrentCell = dGridProfesores.Rows[pos].Cells[1];
            }
            else
                MessageBox.Show("Es el ultimo registro!!");
        }
        private void bUltimo_Click(object sender, EventArgs e)
        {
            pos = sqlhelper.numProfesores - 1;
            dGridProfesores.CurrentCell = dGridProfesores.Rows[pos].Cells[1];
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
                    "usted continuar editando el DNI??", "Conteste",MessageBoxButtons.YesNo);
                if (ok == DialogResult.Yes)
                {
                    txtCod.Text = "";
                    txtCod.Focus();
                }
                else FProfesores_Load(sender, e);
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            DialogResult ok;
            if (txtTelefono.Text.Length == 0 || txtTelefono.Text.Length > 9)
            {
                ok = MessageBox.Show("El TELEFONO tiene que tener un tamaño de 1 a 9 digitos y letras \n\n Quiere " +
                    "usted continuar editando elk telefono??", "Conteste" , MessageBoxButtons.YesNo);
                if (ok == DialogResult.Yes)
                {
                    txtTelefono.Text = "";
                    txtTelefono.Focus();
                }
                else FProfesores_Load(sender, e);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            DialogResult ok;
            if (!txtEmail.Text.Contains('@') || !txtEmail.Text.Contains('.'))
            {
                ok = MessageBox.Show("El EMAIL debe contener el signo '@' y el signo '.'\n\n", "Conteste", MessageBoxButtons.YesNo);
                if (ok == DialogResult.Yes)
                {
                    txtEmail.Text = "";
                    txtEmail.Focus();
                }
                else FProfesores_Load(sender, e);
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

        private void cmbCurso_Enter(object sender, EventArgs e)
        {
            //Para actualizar los datos del combo cuando se produce un cambio en la tabla, tenemos
            //que acceder de nuevo a cargar los datos nuevos del dataset en el combo
            sqlhelper = new SqlHelper("Select * from Curso", "Curso");
            cmbCurso.DataSource = sqlhelper.dsCurso().Tables["Curso"];
            cmbCurso.Refresh();
        }

        private void cmbBuscar2_Enter(object sender, EventArgs e)
        {
            sqlhelper = new SqlHelper("Select * from Curso", "Curso");
            cmbBuscar2.DataSource = sqlhelper.dsCurso().Tables["Curso"];
            cmbBuscar2.Refresh();
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}



