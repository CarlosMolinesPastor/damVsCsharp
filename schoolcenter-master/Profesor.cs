namespace CENTRO_ESCOLAR
{
    internal class Profesor : Persona
    {
        //Miembros

        private string mcorreoE;
        private int mcodCurso;

        //Propiedades

        public string CorreoE
        {
            get { return mcorreoE; }
            set { mcorreoE = value; }
        }
        public int CodCurso
        {
            get { return mcodCurso; }
            set { mcodCurso = value; }
        }

        //Constructor
        public Profesor(string dni, string nombre, string telefono, string correoE, int codCurso) : base(dni, nombre, telefono)
        {
            mcodCurso = codCurso;
            mcorreoE = correoE;
        }

    }
}
