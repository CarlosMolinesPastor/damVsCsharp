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
    public partial class FHexagono : Form
    {
        public FHexagono()
        {
            InitializeComponent();
        }
        //Se declara la lista creada en el formulario principal, aqui no se crea solo se utiliza
        //ya que en el principal al crear el formulario se iguala la lista del formiulario a la lista del 
        //formulario prinicpàl.
        public List<Figura> listafiguras;

        private void bAñadir_Click(object sender, EventArgs e)
        {
            int x, y, lado;
            string color;

            x = int.Parse(txtPosX.Text);
            y = int.Parse(txtPosY.Text);
            lado = int.Parse(txtLado.Text);
            color = txtColor.Text;

            if (x < 0 || y < 0 || lado < 0 || color == string.Empty || txtPosX.Text == string.Empty || txtPosY.Text == string.Empty ||
                txtLado.Text == string.Empty)
            {
                MessageBox.Show("Datos erroneos. Introduce Datos correctos, por favor!!!");
            }
            else
            {
                //Se crea nuevo circulo y posteriormente se añade a la lista de figuras
                Hexagono hexagono = new Hexagono(x,y,color,lado);
                listafiguras.Add(hexagono);
                //Se vacia los campos y llevamos el foco al primer txt
                txtPosX.Text = string.Empty;
                txtPosY.Text = string.Empty;
                txtColor.Text = string.Empty;
                txtLado.Text = string.Empty;
                txtPosX.Focus();
            }
        }

        public string MostrarHexagono(List<Figura> lista)
        {
            string texto = "La lista de Hexagonos es la siguiente: \n \n";
            int cont = 1;
            int control = 0;
            double sumaperimetros = 0;

            foreach (Figura f in lista)
            {
                if (f.GetType() == typeof(Hexagono))
                {
                    texto += "Figura numero: " + cont + "\n";
                    texto += f.QuienSoy() + "\n";
                    texto += f.ToString() + "\n";
                    texto += "El Area es: " + f.Area() + "\n";
                    texto += "El Perímetro es: " + ((Hexagono)f).Perimetro() + "\n \n";
                    sumaperimetros = sumaperimetros + ((Hexagono)f).Perimetro();
                    cont++;
                    control++;
                }
            }
            texto += "La suma de los Perímetros es: " + sumaperimetros;
            if (control == 0)
                texto = "No hay Hexágonos añadidos.";
            return texto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto;
            texto = MostrarHexagono(listafiguras);
            MessageBox.Show(texto);
        }
    }
}
