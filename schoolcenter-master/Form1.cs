using System;
using System.Windows.Forms;

namespace CENTRO_ESCOLAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bCursos_Click(object sender, EventArgs e)
        {
            FCursos fcursos = new FCursos();
            fcursos.ShowDialog();
        }

        private void bProfesores_Click(object sender, EventArgs e)
        {
            FProfesores fprofesores = new FProfesores();
            fprofesores.ShowDialog();
        }

        private void bAlumnos_Click(object sender, EventArgs e)
        {
            FAlumnos falumnos = new FAlumnos();
            falumnos.ShowDialog();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
