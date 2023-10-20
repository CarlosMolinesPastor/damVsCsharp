using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CENTRO_ESCOLAR
{
    internal class SqlHelper
    {
        //Miembros que seran el dataset y el dataadapter
        private SqlDataAdapter daAlumnos;
        private SqlDataAdapter daProfesores;
        private SqlDataAdapter daCursos;

        private DataSet dsAlumnos;
        private DataSet dsProfesores;
        private DataSet dsCursos;

        private int mnumAlumnos;
        private int mnumProfes;
        private int mnumCursos;

        //Propiedades 
        public int numAlumnos
        {
            get { return mnumAlumnos; }
            set { mnumAlumnos = value; }
        }
        public int numProfesores
        {
            get { return mnumProfes; }
            set { mnumProfes = value; }
        }
        public int numCursos
        {
            get { return mnumCursos; }
            set { mnumCursos = value; }
        }

        //Constructor del Objeto
        public SqlHelper(string cadenaSql, string tabla)
        {

            // Variables de conexion y de query que le pasemos y la tabla, así utilizamos la clase
            // para todos los casos
            string relative = @"..\..\";
            string absolute = Path.GetFullPath(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
            string cadenaconexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\App_Data\\Centro.mdf;" +
                "Integrated Security=True;Connect Timeout=30";
            //Creamos un try catch para que en el caso que nos de un error en la conexion nos muestre el
            //error
            try
            {
                //Creamos la conexion nueva
                SqlConnection con = new SqlConnection(cadenaconexion);
                //Abrimos la conexion
                con.Open();
                //Ahora vamos por los casos en que tengamos las diferentes tablas y cadenas sql que le preguntamos
                if (tabla == "Profesores")
                {
                    daProfesores = new SqlDataAdapter(cadenaSql, con);
                    dsProfesores = new DataSet();
                    daProfesores.Fill(dsProfesores, tabla);
                    //Añadimos un dataadapter del curso y dataset para trabajar con el
                    daCursos = new SqlDataAdapter("Select * from Curso", con);
                    dsCursos = new DataSet();
                    daCursos.Fill(dsCursos, "Curso");
                    numProfesores = dsProfesores.Tables[tabla].Rows.Count;
                    numCursos = dsCursos.Tables["Curso"].Rows.Count;
                    con.Close();
                }
                if (tabla == "Alumnos")
                {
                    daAlumnos = new SqlDataAdapter(cadenaSql, con);
                    dsAlumnos = new DataSet();
                    daAlumnos.Fill(dsAlumnos, tabla);
                    daCursos = new SqlDataAdapter("Select * from Curso", con);
                    dsCursos = new DataSet();
                    daCursos.Fill(dsCursos, "Curso");
                    numAlumnos = dsAlumnos.Tables[tabla].Rows.Count;
                    numCursos = dsCursos.Tables["Curso"].Rows.Count;
                    con.Close();
                }
                if (tabla == "Curso")
                {
                    daCursos = new SqlDataAdapter(cadenaSql, con);
                    dsCursos = new DataSet();
                    daCursos.Fill(dsCursos, tabla);
                    //Añadimos el Dataadapter de los profesores y alumnos para cambiar el codigo del curso a 0 del profesor
                    //cuando se elimina el curso
                    daProfesores = new SqlDataAdapter("Select * from Profesores", con);
                    dsProfesores = new DataSet();
                    daProfesores.Fill(dsProfesores, "Profesores");
                    daAlumnos = new SqlDataAdapter("Select * from Alumnos", con);
                    dsAlumnos = new DataSet();
                    daAlumnos.Fill(dsAlumnos, "Alumnos");
                    numCursos = dsCursos.Tables[tabla].Rows.Count;
                    numProfesores = dsProfesores.Tables["Profesores"].Rows.Count;
                    numAlumnos = dsAlumnos.Tables["Alumnos"].Rows.Count;
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex); ;
            }
        }

        //#############################################################################################
        //Devolvemos los dataset en publico para poder utilizarlos en los formularios para los datagrid
        //#############################################################################################
        public DataSet dsCurso()
        {
            return dsCursos;
        }
        public DataSet dsProfesor()
        {
            return dsProfesores;
        }
        public DataSet dsAlumno()
        {
            return dsAlumnos;
        }



        //#############################################################################################
        //Devuelve Posiciones
        //#############################################################################################

        //Curso
        public Curso DevuelveCurso(int pos)
        {
            Curso curso = null;

            if (pos >= 0 && pos < numCursos)
            {
                //Objeto que nos permite recoger el registro de una fila
                DataRow dRegistro;

                //Guardamos en el registro la posicion de la tabla Juegos
                dRegistro = dsCursos.Tables["Curso"].Rows[pos];

                //Cogemos el valor de cada una de las columnas del registro y
                //creamos el objeto juegos con esos datos
                curso = new Curso(int.Parse(dRegistro[0].ToString()), dRegistro[1].ToString());
            }
            return curso;
        }

        //Profesor
        public Profesor DevuelveProfesor(int pos)
        {
            Profesor profesor = null;

            if (pos >= 0 && pos < numProfesores)
            {
                //Objeto que nos permite recoger el registro de una fila
                DataRow dRegistro;

                //Guardamos en el registro la posicion de la tabla Juegos
                dRegistro = dsProfesores.Tables["Profesores"].Rows[pos];

                //Cogemos el valor de cada una de las columnas del registro y
                //creamos el objeto juegos con esos datos
                profesor = new Profesor(dRegistro[0].ToString(), dRegistro[1].ToString(),
                    dRegistro[2].ToString(), dRegistro[3].ToString(), int.Parse(dRegistro[4].ToString()));
            }
            return profesor;
        }

        //Alumno
        public Alumno DevuelveAlumno(int pos)
        {
            Alumno alumno = null;

            if (pos >= 0 && pos < numAlumnos)
            {
                //Objeto que nos permite recoger el registro de una fila
                DataRow dRegistro;

                //Guardamos en el registro la posicion de la tabla Juegos
                dRegistro = dsAlumnos.Tables["Alumnos"].Rows[pos];

                //Cogemos el valor de cada una de las columnas del registro y
                //creamos el objeto juegos con esos datos
                alumno = new Alumno(dRegistro[0].ToString(), dRegistro[1].ToString(),
                    dRegistro[2].ToString(), int.Parse(dRegistro[3].ToString()));
            }
            return alumno;
        }


        //#############################################################################################
        //Metodo CRUD
        //#############################################################################################

        //#############################################################################################
        //Crear
        //#############################################################################################

        //Curso
        public void CrearCurso(Curso curso)
        {
            //Primero hay que crear un nuevo registro del dataset para despues con el dataadapter llevarlo a la BD
            //Tambien creamos una variable boleana para controlar el que se ecnuentre el registro o no en la BD
            DataRow dRegistro = dsCursos.Tables["Curso"].NewRow();
            bool encontrado = false;


            //Igualamos los miembros del Juego a los datos del nuevo registro de la clase juegos
            dRegistro[0] = curso.Codigo;
            dRegistro[1] = curso.Nombre;

            //Añadimos los datos al dataset
            //Comprobamos que el dataset no tenga los mismos datos que vamos a introducir y en caso que no
            //los añadimos
            //Recorremos el dataset con una fila y buscamos valores iguales en caso cambiamos la variable bool
            foreach (DataRow row in dsCursos.Tables["Curso"].Rows)
            {
                if ((row[0].ToString() == dRegistro[0].ToString() || row[1].ToString() == dRegistro[1].ToString()))
                {
                    encontrado = true;
                }
            }
            //En caso que encontremos variables iguales lanzamos mensaje de error, si no, añadimos el registro
            if (encontrado)
            {
                MessageBox.Show("El Código del Curso o el Nombre es un valor repetido, por favor comprueba los " +
                 "datos introducidos");
            }
            else
            {
                dsCursos.Tables["Curso"].Rows.Add(dRegistro);

                //Reconectamos con el DataAdapter y actualizamos el dataset y la bd
                SqlCommandBuilder cb = new SqlCommandBuilder(daCursos);
                daCursos.Update(dsCursos, "Curso");
                //Actualizamos el numero de cursos
                numCursos++;
            }
        }

        //Profesor
        public void CrearProfesor(Profesor Profesor)
        {
            //Primero hay que crear un nuevo registro del dataset para despues con el dataadapter llevarlo a la BD
            //Tambien creamos una variable boleana para controlar el que se ecnuentre el registro o no en la BD
            DataRow dRegistro = dsProfesores.Tables["Profesores"].NewRow();
            bool dni = false;
            bool email = false;
            bool tutor = false;



            //Igualamos los miembros del Juego a los datos del nuevo registro de la clase juegos
            dRegistro[0] = Profesor.Dni;
            dRegistro[1] = Profesor.Nombre;
            dRegistro[2] = Profesor.Telefono;
            dRegistro[3] = Profesor.CorreoE;
            dRegistro[4] = Profesor.CodCurso;

            //Añadimos los datos al dataset. Comprobamos que el dataset no tenga los mismos datos que vamos
            //a introducir y en caso que no los añadimos.
            //Recorremos el dataset con una fila y buscamos valores iguales en caso cambiamos la variable bool
            foreach (DataRow row in dsProfesores.Tables["Profesores"].Rows)
            {
                if (row[0].ToString() == dRegistro[0].ToString())
                {
                    dni = true;
                }
                if (row[3].ToString() == dRegistro[3].ToString())
                {
                    email = true;
                }
                if (row[4].ToString() == dRegistro[4].ToString())
                {
                    tutor = true;
                }

            }
            //En caso que encontremos variables iguales lanzamos mensaje de error, si no, añadimos el registro
            if (dni || tutor || email)
            {
                if (dni)
                    MessageBox.Show("El DNI del profesor es un valor repetido por favor comprueba los " +
                     "datos introducidos");
                if (email)
                    MessageBox.Show("El Email del profesor es un valor repetido por favor comprueba los " +
                     "datos introducidos");
                if (tutor)
                    MessageBox.Show("Tiene usted un error en el campo Curso, debe elegir uno de los items y no puede existir dos" +
                        "  tutores del mismo curso");
            }
            else
            {
                dsProfesores.Tables["Profesores"].Rows.Add(dRegistro);
                //Reconectamos con el DataAdapter y actualizamos el dataset y la bd
                SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
                daProfesores.Update(dsProfesores, "Profesores");
                //Actualizamos el numero de Profesor
                numProfesores++;
            }
        }

        //Alumnos
        public void CrearAlumno(Alumno alumno)
        {

            DataRow dRegistro = dsAlumnos.Tables["Alumnos"].NewRow();
            bool dni = false;

            dRegistro[0] = alumno.Dni;
            dRegistro[1] = alumno.Nombre;
            dRegistro[2] = alumno.Telefono;
            dRegistro[3] = alumno.CodCurso;

            foreach (DataRow row in dsAlumnos.Tables["Alumnos"].Rows)
            {
                if (row[0].ToString() == dRegistro[0].ToString())
                {
                    dni = true;
                }
            }

            if (dni)
            {
                     MessageBox.Show("El DNI del alumno es un valor repetido por favor comprueba los " +
                     "datos introducidos");
            }
            else
            {
                dsAlumnos.Tables["Alumnos"].Rows.Add(dRegistro);
                SqlCommandBuilder cb = new SqlCommandBuilder(daAlumnos);
                daAlumnos.Update(dsAlumnos, "Alumnos");
                numAlumnos++;
            }
        }

        //#############################################################################################
        //Borrar
        //#############################################################################################
        public void EliminarCurso(int pos)
        {
            //Tenemos que comprobar que no existe ningun profesor ni nungun alumno que tenga ese curso para poder borrarlo y
            //lo que hacemos es que al profesor y al alumno en el campo curso le asignamos el valor 0 (sin datos en el curso)
            //Localizamos el curso que vamos a borrar
            Curso curso = DevuelveCurso(pos);

            //Recorremos la tabla profesores que previamente la hemos llenado (En el sqlhelper)
            foreach (DataRow row in dsProfesores.Tables["Profesores"].Rows)
            {
                //Le indicamos que si el codigo del curso es igual al valor del codigo en el profesor que
                //iguale el valor de codigo en el profesor a 0 (sin datos) y que actualice la tabla profesores
                if (curso.Codigo.ToString() == row[4].ToString())
                {
                    row[4] = 0;
                    SqlCommandBuilder cb1 = new SqlCommandBuilder(daProfesores);
                    daProfesores.Update(dsProfesores, "Profesores");
                }
            }
            //Lo mismo para la tabla alumnos
            foreach (DataRow row in dsAlumnos.Tables["Alumnos"].Rows)
            {
                if (curso.Codigo.ToString() == row[3].ToString())
                {
                    row[3] = 0;
                    SqlCommandBuilder cb2 = new SqlCommandBuilder(daAlumnos);
                    daAlumnos.Update(dsAlumnos, "Alumnos");
                }
            }
            //Si el valor de la posicion es igual a 0 no dejamos eliminarlo y si no lo eliminamos
            if (pos == 0)
            {
                MessageBox.Show("Lo siento, no se puede eliminar este valor, es el único valor protegido de la tabla");
            }
            else
            {
                //Eliminamos el registro situado en la posicion actual
                dsCursos.Tables["Curso"].Rows[pos].Delete();

                //Actualizamos el nume de Juegos
                numCursos--;

                //Reconectamos el DataAdapter y actualizamo la BD
                SqlCommandBuilder cb = new SqlCommandBuilder(daCursos);
                daCursos.Update(dsCursos, "Curso");
            }

        }
        //Profesores
        public void EliminarProfesor(int pos)
        {
            //Eliminamos el registro situado en la posicion actual
            dsProfesores.Tables["Profesores"].Rows[pos].Delete();

            //Actualizamos el nume de Juegos
            numProfesores--;

            //Reconectamos el DataAdapter y actualizamo la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Profesores");
        }
        //Alumnos
        public void EliminarAlumno(int pos)
        {
            //Eliminamos el registro situado en la posicion actual
            dsAlumnos.Tables["Alumnos"].Rows[pos].Delete();

            //Actualizamos el nume de Juegos
            numAlumnos--;

            //Reconectamos el DataAdapter y actualizamo la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daAlumnos);
            daAlumnos.Update(dsAlumnos, "Alumnos");
        }
        //#############################################################################################
        //Actualizar
        //#############################################################################################
       
        //Curso
        public void ActualizarCurso(Curso curso, int pos)
        {
            //Apuntamos la posicion actual al registro
            DataRow dRegistro = dsCursos.Tables["Curso"].Rows[pos];
            //Usamos las variables boleanas para controlar la existencia del curso así controlar los
            //datos que metemos, ahora se le añade un contador para eso mismo ya que puede encontrar un
            //repetido que sera el mismo, por lo que nos interesa encontrar mas de un resultado
            bool cod = false;
            bool nombre = false;
            int contcod = 0;
            int contnombre = 0;

            //Igualamos los registros a los datos 
            dRegistro[0] = curso.Codigo;
            dRegistro[1] = curso.Nombre;

            foreach (DataRow row in dsCursos.Tables["Curso"].Rows)
            {
                //Para pasara atrue se tiene que repetir mas de una vez, es decir el valor del registro que
                //apuntamos y el de la posicion neuva
                if (row[0].ToString() == dRegistro[0].ToString())
                {
                    contcod++;
                    if (contcod > 1)
                        cod = true;
                }
                if (row[1].ToString() == dRegistro[1].ToString())
                {
                    contnombre++;
                    if (contnombre > 1)
                        nombre = true;
                }
            }
            //En caso que encontremos variables iguales lanzamos mensaje de error, si no, añadimos el registro
            if (cod || nombre)
            {
                if (cod)
                    MessageBox.Show("Error de datos de registro, el codigo no puede estar repetido");
                if (nombre)
                    MessageBox.Show("Error en el registro, el nombre del curso no puede estar repetido");
            }
            else
            {
                //Reconectamos con el DataAdapter y actualizmos la base de datos
                SqlCommandBuilder cb = new SqlCommandBuilder(daCursos);
                daCursos.Update(dsCursos, "Curso");
            }
        }
        //Profesor
        public void ActualizarProfesor(Profesor profesor, int pos)
        {
            //Apuntamos la posicion actual al registro
            DataRow dRegistro = dsProfesores.Tables["Profesores"].Rows[pos];
            //Usamos las variables boleanas para controlar la existencia del profesor así controlar los
            //datos que metemos, ahora se le añade un contador para eso mismo ya que puede encontrar un
            //repetido que sera el mismo, por lo que nos interesa encontrar mas de un resultado
            bool dni = false;
            bool tutor = false;
            bool email = false;
            int contadordni = 0;
            int contadoremail = 0;
            int contadorTutor = 0;

            //Igualamos los registros a los datos 
            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Telefono;
            dRegistro[3] = profesor.CorreoE;
            dRegistro[4] = profesor.CodCurso;

            //Igual cursos**
            foreach (DataRow row in dsProfesores.Tables["Profesores"].Rows)
            {
                if (row[0].ToString() == dRegistro[0].ToString())
                {
                    contadordni++;
                    if (contadordni > 1)
                        dni = true;
                }
                if (row[3].ToString() == dRegistro[3].ToString())
                {
                    contadoremail++;
                    if (contadoremail > 1)
                        email = true;
                }
                if (row[4].ToString() == dRegistro[4].ToString() && dRegistro[4].ToString() != "0")
                {
                    contadorTutor++;
                    if (contadorTutor > 1)
                        tutor = true;
                }
            }

            if (dni || email || tutor)
            {
                if (dni)
                    MessageBox.Show("El DNI del profesor es un valor repetido por favor comprueba los " +
                     "datos introducidos");
                if (email)
                    MessageBox.Show("El Email del profesor es un valor repetido por favor comprueba los " +
                   "datos introducidos");
                if (tutor)
                    MessageBox.Show("Tiene usted un error en el campo Curso, debe elegir uno de los items y no puede existir dos" +
                        "  tutores del mismo curso");
            }
            else
            {
                //Reconectamos con el DataAdapter y actualizmos la base de datos
                SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
                daProfesores.Update(dsProfesores, "Profesores");
            }
        }
        //Alumnos
        public void ActualizarAlumno(Alumno alumno, int pos)
        {
            //Apuntamos la posicion actual al registro
            DataRow dRegistro = dsAlumnos.Tables["Alumnos"].Rows[pos];
            //Usamos las variables boleanas para controlar la existencia del alumno así controlar los
            //datos que metemos, ahora se le añade un contador para eso mismo ya que puede encontrar un
            //repetido que sera el mismo, por lo que nos interesa encontrar mas de un resultado
            bool dni = false;
            int contadordni = 0;

            //Igualamos los registros a los datos 
            dRegistro[0] = alumno.Dni;
            dRegistro[1] = alumno.Nombre;
            dRegistro[2] = alumno.Telefono;
            dRegistro[3] = alumno.CodCurso;

            //Ver Cursos**
            foreach (DataRow row in dsAlumnos.Tables["Alumnos"].Rows)
            {
                if (row[0].ToString() == dRegistro[0].ToString())
                {
                    contadordni++;
                    if (contadordni > 1)
                        dni = true;
                }

            }
            if (dni)
            {
                MessageBox.Show("El DNI del alumno es un valor repetido por favor comprueba los " +
                 "datos introducidos");
            }
            else
            {
                //Reconectamos con el DataAdapter y actualizmos la base de datos
                SqlCommandBuilder cb = new SqlCommandBuilder(daAlumnos);
                daAlumnos.Update(dsAlumnos, "Alumnos");
            }
        }
    }
}
