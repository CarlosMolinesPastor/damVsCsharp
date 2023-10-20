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
    public partial class FCirculo : Form
    {
        public FCirculo()
        {
            InitializeComponent();
        }
        //Se declara la lista creada en el formulario principal, aqui no se crea solo se utiliza
        //ya que en el principal al crear el formulario se iguala la lista del formiulario a la lista del 
        //formulario prinicpàl.
        public List<Figura> listafiguras;

        private void bAñadir_Click(object sender, EventArgs e)
        {
            int x, y, radio;
            string color;

            x = int.Parse(txtPosX.Text);
            y = int.Parse(txtPosY.Text);
            radio = int.Parse(txtRadio.Text);
            color = txtColor.Text;

            if (x < 0 || y < 0 || radio < 0 || color == string.Empty || txtPosX.Text == string.Empty || txtPosY.Text == string.Empty ||
                txtRadio.Text == string.Empty)
            {
                x = 0; y = 0; radio = 0;
                MessageBox.Show("Datos erroneos. Introduce Datos correctos, por favor!!!");
            }
            else
            {
                //Se crea nuevo circulo y posteriormente se añade a la lista de figuras
                Circulo circulo = new Circulo(x,y,color,radio);
                listafiguras.Add(circulo);
                //Se vacia los campos y llevamos el foco al primer txt
                txtPosX.Text = string.Empty;
                txtPosY.Text = string.Empty;
                txtColor.Text = string.Empty;
                txtRadio.Text = string.Empty;
                txtPosX.Focus();
            }
        }

        string MostrarCirculos(List<Figura> listafigura)
        {
            string texto = "Los circulos son los siguientes: \n \n";
            int cont = 1;
            int control = 0; //Variable para controlar la lista vacia
            double sumaperimetros = 0; //Variable para calcular la suma de perímetros
                                       //Recorremos la lista y vamos mostrando los datos de la misma

            foreach (Figura f in listafigura)
            {
                if (f.GetType() == typeof(Circulo))
                {
                    texto = texto + "Figura numero: " + cont + "\n";
                    texto = texto + f.QuienSoy() + "\n";
                    texto = texto + f.ToString() + "\n";
                    texto = texto + "Mi area es: " + f.Area() + "\n";
                    texto += "El Perimetro es: " + ((Circulo)f).Perimetro() + "\n \n";
                    sumaperimetros = sumaperimetros + ((Circulo)f).Perimetro();
                    cont++;
                    control++;
                }
            }
            texto = texto + "\nLa suma de los perímetros es " + sumaperimetros;

            if (control == 0)
                texto = "No hay Circulos en la lista";
            //Devolvemos la variable con todos los datos de la figura.
            return texto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto;
            texto = MostrarCirculos(listafiguras);
            MessageBox.Show(texto);

        }
    }
}
