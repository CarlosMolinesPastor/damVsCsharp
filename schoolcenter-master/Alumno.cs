namespace CENTRO_ESCOLAR
{
    internal class Alumno : Persona
    {
        //Miembros de la clase Alumnos
        private int mCodCurso;

        //Propiedades
        public int CodCurso
        {
            get { return mCodCurso; }
            set { mCodCurso = value; }
        }

        public Alumno(string dni, string nombre, string telefono, int codcurso) : base(dni, nombre, telefono)
        {
            mCodCurso = codcurso;
        }
    }
}
