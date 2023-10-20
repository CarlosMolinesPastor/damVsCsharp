namespace CENTRO_ESCOLAR
{
    internal class Persona
    {
        //Empezamos con la clase abstracta Personas que será la que despues hereden tanto profesores como alumnos
        //Lo primero es los miembros de la clase
        private string mNombre;
        private string mTelefono;
        private string mDni;

        //Bien ahora vamos con las propiedades de los miembros
        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }
        public string Telefono
        {
            get { return mTelefono; }
            set { mTelefono = value; }
        }
        public string Dni
        {
            get { return mDni; }
            set { mDni = value; }
        }

        //Constructor, por el cual construimos una nueva persona con datos que le introduciremos mas tarde
        public Persona(string dni, string nombre, string telefono)
        {
            mDni = dni;
            mNombre = nombre;
            mTelefono = telefono;
        }

    }
}
