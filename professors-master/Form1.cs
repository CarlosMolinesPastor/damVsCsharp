using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;

namespace Profesores2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Instanciamos el objeto que maneja la base de datos
        SqlAyuda sqlHelp;
        //Variable que indica en que registro nos encontramos
        private int pos;
        //Variable para no tener que andar con sumas + 1 de la posicion para sacarlo por el txt.
        private int totalpos;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creamos el objeto BD
            sqlHelp = new SqlAyuda();
            //la posicion la igualamos a 0
            pos = 0;
            totalpos = pos + 1;
            //Llenamos el DataGridView  con el metodo publico ds de sqlAyuda que devuelve el Dataset y llenamos el 
            dGridProfesores.DataSource = sqlHelp.ds().Tables["Profesores"];
            dGridProfesores.Refresh();
            //Evitamos que el usuario pueda cambiar el orden de las columnas.. El codigo lo he buscado por internet
            foreach(DataGridViewColumn col in dGridProfesores.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //Llamamos al Metodo MostrarRegistro para mostrar el primer registro en la app
            MostrarRegistro(pos);
            txtPos.Text = totalpos.ToString();
            txtTotal.Text = sqlHelp.numProfesores.ToString();
        }
        //Metodo que muestra el Registro en la posicion que estamos
        private void MostrarRegistro(int pos)
        {
            //Instanciamos el objeto profesor de la clase profesor
            Profesor profesor;

            //Llmamos al metodo de la clase SqlAyuda para que nos devuelva el profesor
            profesor = sqlHelp.DevuelveProfesor(pos);
            
            if(profesor != null)
            {
                txtDni.Text = profesor.Dni;
                txtNombre.Text = profesor.Nombre;
                txtApellidos.Text = profesor.Apellidos;
                txtTelefono.Text = profesor.Telefono;
                txtEmail.Text = profesor.Email;
                dGridProfesores.CurrentCell = dGridProfesores.Rows[pos].Cells[0];
                dGridProfesores.Refresh();

            }


            //Ponemos los valores en los txt correspondientes

        }

        //Boton primero, igualamos las porsiciones tanto la del registro como la del campo de texto
        private void bPrimero_Click(object sender, EventArgs e)
        {
            if (sqlHelp.numProfesores == 0)
            {
                MessageBox.Show("No hay registros en la base de datos");
            }
            else
            {
                pos = 0; totalpos = 1;

                MostrarRegistro(pos);
                txtPos.Text = totalpos.ToString();
                txtTotal.Text = sqlHelp.numProfesores.ToString();

            }
        }
        //Boton anterior aqui modificamos para que si no hay datos en la base de datos en primero nos muestre que no hay
        //registroes y en caso contrario que discierna que se encuentra en la posicion 0 y no se puede ir para atrás o no
        private void bAnterior_Click(object sender, EventArgs e)
        {
            if (sqlHelp.numProfesores == 0)
            {
                MessageBox.Show("No hay registros en la base de datos");
            }
            else
            {
                if (pos != 0)
                {
                    pos--; totalpos = pos + 1;

                    MostrarRegistro(pos);
                    txtPos.Text = totalpos.ToString();
                    txtTotal.Text = sqlHelp.numProfesores.ToString();

                }
                else
                {
                    MessageBox.Show("Es el primer registro");
                }
            }
        }
        //boton siguiente, hacemos lo mismo que con el boton Anterior pero teniendo en cuenta no salirnos de los registros 
        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (sqlHelp.numProfesores == 0)
            {
                MessageBox.Show("No hay registros en la base de datos");
            }
            else
            {
                if (pos != (sqlHelp.numProfesores -1))
                {
                    pos++; totalpos = pos + 1;

                    MostrarRegistro(pos);
                    txtPos.Text = totalpos.ToString();
                    txtTotal.Text = sqlHelp.numProfesores.ToString();

                }
                else
                {
                    MessageBox.Show("Es el ultimo registro");
                }
            }
        }
        //Boton ultimo en el que vemos la posicibilidad de  irnos al ultimo registro
        private void bUltimo_Click(object sender, EventArgs e)
        {
            if (sqlHelp.numProfesores == 0)
            {
                MessageBox.Show("No hay registros en la base de datos");
            }
            else
            {
                pos = sqlHelp.numProfesores -1; totalpos = sqlHelp.numProfesores;

                MostrarRegistro(pos);
                txtPos.Text = totalpos.ToString();
                txtTotal.Text = sqlHelp.numProfesores.ToString();

            }
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            //Le mandamos el foco al DNI
            txtDni.Focus();
        }
        //Guardar el profesor, creamos un nuevo profesor con los datos de los campos de texto y  se lo pasamos al metodo
        //crearProfesor de la clase sqlAyuda, que hace todas las gestiones con la BD (crear registro igualar datos, añadir
        //el registro al dataset y reconectar el datatable con la bd y actualizarla.
        private void bGuardar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor(txtDni.Text,txtNombre.Text,txtApellidos.Text,txtTelefono.Text,txtEmail.Text);
            sqlHelp.CrearProfesor(profesor);
            pos = sqlHelp.numProfesores -1;
            MostrarRegistro(pos);
            txtPos.Text = sqlHelp.numProfesores.ToString();
            txtTotal.Text = sqlHelp.numProfesores.ToString();
        }
       
        private void bActualizar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor(txtDni.Text, txtNombre.Text, txtApellidos.Text, txtTelefono.Text, txtEmail.Text);
            sqlHelp.ActualizarProfesor(profesor, pos);
            MessageBox.Show("Registro actualizado");
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ok;

            if (sqlHelp.numProfesores > 0)
            {
                ok = MessageBox.Show("Deverdad quieres eliminar el registro actual", "Contesta", MessageBoxButtons.YesNo);
                if (ok == DialogResult.Yes)
                {
                    if (pos == 0 && sqlHelp.numProfesores == 1)
                    {
                        sqlHelp.EliminarProfesor(pos);
                        MessageBox.Show("Base de Datos sin regsitros");
                        txtDni.Text = "";
                        txtNombre.Text = "";
                        txtApellidos.Text = "";
                        txtTelefono.Text = "";
                        txtEmail.Text = "";
                        txtPos.Text = "";
                        txtTotal.Text = "";
                    }
                    else if (pos == 0 && sqlHelp.numProfesores != 1)
                    {
                        sqlHelp.EliminarProfesor(pos);
                        MostrarRegistro(pos);
                        pos++;
                        txtTotal.Text = sqlHelp.numProfesores.ToString();
                        dGridProfesores.Refresh();
                    }
                    else
                    {
                        sqlHelp.EliminarProfesor(pos);
                        pos--;
                        MostrarRegistro(pos);
                        txtTotal.Text = sqlHelp.numProfesores.ToString();
                        dGridProfesores.Refresh();
                    }
                    
                }
                else
                    MessageBox.Show("Base de Datos sin registro");
               
            }
            
               
        }

        //Mostrar apellidos, apuntamos al metodo de PosicionApellido y lo igaulamos a la posicion
        //que nos devuelve
        private void button2_Click(object sender, EventArgs e)
        {
            string apellido = Interaction.InputBox("Introduce un apellido a buscar");
            int pos = sqlHelp.PosicionApellido(apellido);
            if (pos >= 0)
            {
                MostrarRegistro(pos);
            }
            else
                MessageBox.Show("No existe ese apellido en la Base de Datos");
        }

        //Funciones que al perder el foco compruebe los campos que tienen los datos correctos
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains('@') || !txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("El campo Email tiene que tener el caracter '@' y el caracter '.' ");
                txtEmail.Text = "";
                txtEmail.Focus();
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text.Length >= 10 || txtDni.Text == string.Empty)
            {
                MessageBox.Show("El campo DNI no puede tener más de 9 caracteres o estar vacio");
                txtDni.Text = "";
                txtDni.Focus();
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Length >= 10)
            {
                MessageBox.Show("El campo Telefono no puede tener más de 9 caracteres ");
                txtTelefono.Text = "";
                txtTelefono.Focus();
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
