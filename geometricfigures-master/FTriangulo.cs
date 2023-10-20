using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_T8
{
    public partial class FTriangulo : Form
    {
        public FTriangulo()
        {
            InitializeComponent();
        }
        //Se declara la lista creada en el formulario principal, aqui no se crea solo se utiliza
        //ya que en el principal al crear el formulario se iguala la lista del formiulario a la lista del 
        //formulario prinicpal.
        public List<Figura> listafiguras;

        private void bAñadir_Click(object sender, EventArgs e)
        {
            int x, y, lado;
            string color;

            //Se igualan las variables a los campos de texto, y despues dse comprueba que los datos sean los 
            //Correctos
            x = int.Parse(txtPosX.Text);
            y = int.Parse(txtPosY.Text);
            lado = int.Parse(txtLado.Text);
            color = txtColor.Text;

            if (x < 0 || y < 0 || lado <= 0 || color == string.Empty || txtPosX.Text == string.Empty|| txtPosY.Text == string.Empty )
            {
                MessageBox.Show("Datos erroneos. Introduce Datos correctos, por favor!!!");
            }
            else
            {
                //Se crea un nuevo cuadrad, se añade a la lista y se da el foco al primer txtBox
                Triangulo triangulo = new Triangulo(x, y, color, lado);
                listafiguras.Add(triangulo);
                txtPosX.Text = string.Empty;
                txtPosY.Text = string.Empty;
                txtColor.Text = string.Empty;
                txtLado.Text = string.Empty;
                txtPosX.Focus();
            }
        }
        string MostrarTriangulo(List<Figura> listafigura)
        {
            string texto = "La lista de TRIANGULOS es la siguiente: \n \n";
            int cont = 1; //Numeracion de los triangulos
            int control = 0; //Control de lista vacia
            double sumaperimetros = 0;

            foreach (Figura f in listafigura)
            {
                if (f.GetType() == typeof(Triangulo))
                {
                    texto += "Figura Numero: " + cont + "\n";
                    texto += f.QuienSoy() + "\n";
                    texto += f.ToString() + "\n";
                    texto += "El Area es: " + f.Area() + "\n";
                    texto += "El Perimetro es: " + ((Triangulo)f).PerimetroTriangulo() + "\n \n";
                    //Vamos sumando los perimetros para despues imprimirlo por pantalla
                    sumaperimetros = sumaperimetros + ((Triangulo)f).PerimetroTriangulo();
                    cont++;
                    control++;
                }
            }
            texto += "\nLa suma de los perimetros es " + sumaperimetros;
            if (control == 0) texto = "No existen Triangulo en la lista";
            return texto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Se cierra el formulario;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto;
            texto = MostrarTriangulo(listafiguras);
            MessageBox.Show(texto);
        }
    }
}
