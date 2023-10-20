namespace CENTRO_ESCOLAR
{
    internal class Curso
    {
        //Miembros
        private int mCodigo;
        private string mNombre;

        //Propiedades
        public string Nombre { get { return mNombre; } set { mNombre = value; } }
        public int Codigo { get { return mCodigo; } set { mCodigo = value; } }

        //Constructor
        public Curso(int codigo, string nombre)
        {
            mCodigo = codigo;
            mNombre = nombre;
        }
    }
}
