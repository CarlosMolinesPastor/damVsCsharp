using System;
using System.Windows.Forms;

namespace CENTRO_ESCOLAR
{
    public partial class FCursos : Form
    {
        public FCursos()
        {
            InitializeComponent();
        }
        private SqlHelper sqlhelper;
        private int pos;
        //#############################################################################################
        //Carga del Formulario, nos vamos a la posicion 0
        //#############################################################################################
        private void FCursos_Load(object sender, EventArgs e)
        {
            pos = 0;
            string cadenaConexion = "SELECT * FROM Curso";
            string tabla = "Curso";
            sqlhelper = new SqlHelper(cadenaConexion, tabla);

            //Llenamos el DataGridView  con el metodo publico ds de sqlAyuda que devuelve el Dataset
            //y llenamos el datagrid
            dGridCursos.DataSource = sqlhelper.dsCurso().Tables[tabla];
            dGridCursos.Refresh();
            //Evitamos que el usuario pueda cambiar el orden de las columnas..
            //El codigo lo he buscado por internet
            foreach (DataGridViewColumn col in dGridCursos.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //Mostramos el registro de la posicion por el metodo mostrarRegistro.
            //Eliminado por redundancia ya que muestro el registro del datagrid
            //cuando recibe el foco por lo que no hace falta mostrarlo aqui en el
            //load del formulario, esta en el metodo dGridCursos_RowEnter()
            //MostrarRegistro(pos);

            //Añadimos que en el combobox de buscar se selecciones por defecto buscar por nombre
            cmbBuscar.SelectedIndex = 1;
            //Cargamos las label con los numeros de registro
            txtRegActual.Text = (pos + 1).ToString();
            txtRegTotal.Text = sqlhelper.numCursos.ToString();
            //Botones
            bGuardar.Enabled = true;
            bActualizar.Enabled = true;
            bBorrar.Enabled = true;
        }
        //#############################################################################################
        //Metodo mostrar registro y mostar posicion del datagrid
        //#############################################################################################

        private void MostrarRegistro(int pos)
        {
            //Instanciamos el objeto curso de la clase curso
            Curso curso;

            //Llmamos al metodo de la clase Sqlhelper para que nos devuelva el curso
            curso = sqlhelper.DevuelveCurso(pos);
            if (curso != null)
            {
                txtCod.Text = curso.Codigo.ToString();
                txtNombre.Text = curso.Nombre;
                //Nos vamos en el DataGrid a la posicion de la fila indicada y a la celda primera
            }
        }
        //Metodo por el cual indicamos la fila actual que introducimos al entrar en ella y mostramos en
        //los txt a traves de MostrarRegistrol
        private void dGridCursos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            pos = e.RowIndex;//Posicion actual de la fila igualado a la posicion
            MostrarRegistro(pos); //mostramos posicion
            txtRegActual.Text = (pos + 1).ToString();//mostramos la posicion actual en el txt y la global
            txtRegTotal.Text = sqlhelper.numCursos.ToString();
        }
        //#############################################################################################
        //Busqueda
        //#############################################################################################

        //Metodo para buscar en la base de datos, utilizamos una query de SQL para buscar por cadena parecida
        //%like% al campo de texto de busqueda y lo cargamos en el dataset para despues mostrarlo en el datagrid
        private void bBuscar_Click(object sender, EventArgs e)
        {
            //Variables, tabla y cadenaconexion para pasarlo a la clase sqlhelper. valor en este caso es la
            //columna de la tabla y campotxt es el campo de texto de busqueda, creamos la nueva conexion se
            //carga el dataset que se devuelve por dsCurso() y así mostramos los resultados en el datagrid
            string valor, campotxt, tabla, cadenaConexion;

            tabla = "Curso";
            valor = cmbBuscar.Text.ToUpper();
            if (valor == "Codigo")//Indicamos que el valor Codigo del combobox es igual a Id que es el que maneja
                                  //la BD, ya que no se llama Codigo en la BD si no Id
                valor = "Id";
            campotxt = txtBuscar.Text.ToUpper();
            cadenaConexion = ("SELECT * from Curso where " + valor + " like '%" + campotxt + "%' ");
            //Hacemos la conexion y busqueda de sqlhelper
            sqlhelper = new SqlHelper(cadenaConexion, tabla);
            //Llenamos el DataGridView  con el metodo publico ds de sqlhelper que devuelve el Dataset
            dGridCursos.DataSource = sqlhelper.dsCurso().Tables[tabla];
            dGridCursos.Refresh();
        }
        //Boton de refresco que vuelve a cargar el dataadapter y dataset de toda la tabla
        private void bRefrescar_Click(object sender, EventArgs e)
        {
            FCursos_Load(sender, e);
        }
        //#############################################################################################
        // Nuevo Curso
        //#############################################################################################
        
        //Limpiamos los txt
        private void bNuevo_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNombre.Text = "";
            MessageBox.Show("Añade un curso nuevo y selecciona el boton GUARDAR");
            txtCod.Focus();//Devolvemos el foco al campo de texto
        }


        private void bGuardar_Click(object sender, EventArgs e)
        {
            int codigo;
            string nombre;
            if (txtCod.Text == "" || txtNombre.Text == "")
                MessageBox.Show("Los campos no pueden estar vacios, corrige el error.");
            else
            {
                //Igualamos variables a las entradas de texto
                codigo = int.Parse(txtCod.Text);
                nombre = txtNombre.Text.ToUpper();
                //Instanciamos un nuevo objeto de curso y llamamos al metodo para añadirlo a la BD
                Curso curso = new Curso(codigo, nombre);
                sqlhelper.CrearCurso(curso);
                //Ahora nos vamos al ultimo registro en el datagrid, pero para asegurarnos que entra nos vamos a
                //la celda en particular
                dGridCursos.CurrentCell = dGridCursos.Rows[sqlhelper.numCursos - 1].Cells[0];
                //Mostramos en los txtBox las posiciones
                txtRegActual.Text = (pos + 1).ToString();
                txtRegTotal.Text = sqlhelper.numCursos.ToString();
                //Actualizar formulario
                FCursos_Load(sender, e);
            }

        }
        //#############################################################################################
        // Borrar Curso
        //#############################################################################################
        private void bBorrar_Click(object sender, EventArgs e)
        {
            DialogResult ok;
            //Declaramos una variable para la posicion puesto que si utilizamos la variable global pues tenemos
            //el problema que al depender el mostrar registro del datagriid y de la posicion que tenemos, nos salimos
            //de los margenes y se produce un error. 
            //private void dGridCursos_RowEnter nos lleva a mostrarRegistro y al eliminar el curso deja de estar en el ds
            int p = Convert.ToInt32(dGridCursos.CurrentRow.Index);

            //con la variable dialog result nos aseguramos que realmente queremos borarr el curso y las diferentes
            //excepciones para no salirnos de los casos, que haya mas de un registro o que 1 o menos y si hay el ultimo desactvar
            //el datagrid
            ok = MessageBox.Show("Seguro que quieres borrar el registro de la base de datos?",
                "Contesta", MessageBoxButtons.YesNo);
            if (ok == DialogResult.Yes)
            {

                if (p > 0) //Si la posicion es mas que 0 entonces nos vamos a la fila anterior para no provocar
                           //el error de lectura
                {
                    dGridCursos.CurrentCell = dGridCursos.Rows[p - 1].Cells[0];
                    sqlhelper.EliminarCurso(p);
                    FCursos_Load(sender, e);
                }
                else //si no nos vamos a la ultima posicion
                {
                    dGridCursos.CurrentCell = dGridCursos.Rows[(sqlhelper.numCursos - 1)].Cells[0];
                    sqlhelper.EliminarCurso(p);
                    FCursos_Load(sender, e);
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
            int cod; //variables para acumular el valor de los campos de texto para crear nuevo curso y
                     //llamar al metodo ActualizarCurso con curso y posicion que sacamos del datagrid y
                     //actualizamos el datagrid 
            string nombre;
            
            if (txtCod.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                pos = Convert.ToInt32(dGridCursos.CurrentRow.Index);
                cod = Convert.ToInt32(txtCod.Text);
                nombre = txtNombre.Text.ToUpper();
                Curso curso = new Curso(cod, nombre);
                sqlhelper.ActualizarCurso(curso, pos);
                dGridCursos.Refresh();
            }
        }

        //#############################################################################################
        //DESPLAZAMIENTO BOTONES
        //#############################################################################################
        private void bPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            dGridCursos.CurrentCell = dGridCursos.Rows[pos].Cells[1];
        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                dGridCursos.CurrentCell = dGridCursos.Rows[pos].Cells[1];
            }
            else
            {
                MessageBox.Show("Es el primer registro!!");
            }

        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (pos < sqlhelper.numCursos - 1)
            {
                pos = pos + 1;
                dGridCursos.CurrentCell = dGridCursos.Rows[pos].Cells[1];
            }
            else
                MessageBox.Show("Es el ultimo registro!!");
        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            pos = sqlhelper.numCursos - 1;
            dGridCursos.CurrentCell = dGridCursos.Rows[pos].Cells[1];
        }

        //#############################################################################################
        //CONTROL COMPORTAMIENTOS
        //#############################################################################################
        private void txtCod_Leave(object sender, EventArgs e)
        {
            if (txtCod.Text =="")
            {
                bGuardar.Enabled = false;
                bActualizar.Enabled = false;
                bBorrar.Enabled = false;
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                bGuardar.Enabled = false;
                bActualizar.Enabled = false;
                bBorrar.Enabled = false;
            }
        }
        private void txtCod_Enter(object sender, EventArgs e)
        {
            bGuardar.Enabled = true;
            bActualizar.Enabled = true;
            bBorrar.Enabled = true;
        }
        //Habilita los botones solo en el caso que el txtcod nop sea igual a vacio
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                bGuardar.Enabled = true;
                bActualizar.Enabled = true;
                bBorrar.Enabled = true;
            }
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
