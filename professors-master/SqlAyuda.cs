using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Profesores2
{
    internal class SqlAyuda
    {
        //Miembros que seran el dataset y el dataadapter
        private SqlDataAdapter daProfesores;
        private DataSet dsProfesores;
        private int mnumProfesores;

        //Propiedades 
        public int numProfesores
        {
            get {  return mnumProfesores; }
            set { mnumProfesores = value;}
        }

        //Constructor del Objeto
        public SqlAyuda()
        {
            //cadena conexion
            string relative = @"..\..\";
            string absolute = Path.GetFullPath(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
            string cadenaconexion = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|\\AppData\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";
            //Creamos la conexion nueva
            SqlConnection con = new SqlConnection(cadenaconexion);
            //Abrimos la conexion
            con.Open();
            //Creamos la cadena de consulta a la BD
            string cadenaSQL = "SELECT * from Profesores";
            //Creamos el SqlAdapter con la consulta y la conexion para despues llenar el dataset
            daProfesores = new SqlDataAdapter(cadenaSQL, con);
            //Creamos el nuevo dataset y lo llenamos con el dataapter
            dsProfesores = new DataSet();
            daProfesores.Fill(dsProfesores, "Profesores");
            //Obtenemos el numero de profesores
            numProfesores = dsProfesores.Tables["Profesores"].Rows.Count;
            //Cerramos la Conexion
            con.Close();
        }
        //Metodos

        //1)A partir de una posicion devuelve un objeto profesor del
        //dataset.
        //Devuelve null si la posicion esta fuera de los limites
        public Profesor DevuelveProfesor(int pos)
        {
            Profesor profesor = null;

            if (pos >= 0 && pos < numProfesores)
            {
                //Objeto que nos permite recoger el registro de una fila
                DataRow dRegistro;

                //Guardamos en el registro la posicion de la tabla profesores
                dRegistro = dsProfesores.Tables["Profesores"].Rows[pos];

                //Cogemos el valor de cada una de las columnas del registro y
                //creamos el objeto profesor con esos datos
                profesor = new Profesor(dRegistro[0].ToString(), dRegistro[1].ToString(), dRegistro[2].ToString(), 
                    dRegistro[3].ToString(), dRegistro[4].ToString());
            }
            return profesor;
        }

        //Metodos CRUD(Create, read, update y delete)

        //Metodo que añade un profesor a la BD
        public void CrearProfesor(Profesor profesor)
        {
            //Primero hay que crear un nuevo registro del dataset para despues con el dataadapter llevarlo a la BD
            DataRow dRegistro = dsProfesores.Tables["Profesores"].NewRow();

            //Igualamos los miembros del Profesor a los datos del nuevo registro de la clase profesores
            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Apellidos;
            dRegistro[3] = profesor.Telefono;
            dRegistro[4] = profesor.Email;

            //Añadimos los datos al dataset
            dsProfesores.Tables["Profesores"].Rows.Add(dRegistro);

            //Reconectamos con el DataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Profesores");

            //Actualizamos el numero de profesores
            numProfesores++;
        }

        //Actualizar los datos del profesor que esta en la pos actual, le pasamos
        //la clase profesor y la posicion
        public void ActualizarProfesor(Profesor profesor, int pos)
        {
            //Apuntamos la posicion actual al registro
            DataRow dRegistro = dsProfesores.Tables["Profesores"].Rows[pos];

            //Igualamos los registros a los datos 
            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Apellidos;
            dRegistro[3] = profesor.Telefono;
            dRegistro[4] = profesor.Email;

            //Reconectamos con el DataAdapter y actualizmos la base de datos
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores,"Profesores"); 
        }

        //Eliminar el profesore, le pasamos la poscion
        public void EliminarProfesor(int pos)
        {
            //Eliminamos el registro situado en la posicion actual
            dsProfesores.Tables["Profesores"].Rows[pos].Delete();

            //Actualizamos el nume de profesores
            numProfesores--;

            //Reconectamos el DataAdapter y actualizamo la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Profesores");
        }

        public int PosicionApellido(string apellido)
        {
            int p = -1;
            int i;
            bool encontrado = false;
            DataRow dRegistro;

            if (numProfesores > 0)
            {
                for (i = 0; i < numProfesores && !encontrado; i++)
                {
                    dRegistro = dsProfesores.Tables["Profesores"].Rows[i];
                    if (dRegistro[2].ToString() == apellido)
                    {
                        p = i;
                        encontrado = true;
                    }
                }
            }
            return p;
        }



        //Metodo para devolver publico el dataset y así poder llenar el DataGridView
        public DataSet ds()
        {
            return dsProfesores;
        }
    }
}
