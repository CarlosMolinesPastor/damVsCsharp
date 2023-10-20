namespace CENTRO_ESCOLAR
{
    internal class Asignatura
    {
        //Miembros
        private int mCodigo;
        private string mNombre;

        //Propiedades
        public string Nombre { get { return mNombre; } set { mNombre = value; } }
        public int Codigo { get { return mCodigo; } set { mCodigo = value; } }

        //Constructor
        public Asignatura()
        {
            mCodigo = 0;
            mNombre = string.Empty;
        }
    }
}
