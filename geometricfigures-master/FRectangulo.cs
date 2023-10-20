using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_T8
{
    public partial class FRectangulo : Form
    {
        public FRectangulo()
        {
            InitializeComponent();
        }
        //Crear la lista para utilizarla --  importante que sea ******publica****** para acceder a ella desde el boton de formulario
        public List<Figura> listafigura;

        private void bAñadir_Click(object sender, EventArgs e)
        {
            //Primero las variables que necesitamos
            int x, y, bas, altura;
            string color;

            //Segundo igualamos las variables a los txt correspondientes
            x = int.Parse(txtPosX.Text);
            y = int.Parse(txtPosY.Text);
            bas = int.Parse(txtBase.Text);
            altura = int.Parse(txtAltura.Text);
            color = txtColor.Text;

            //Tercero creamos el Rectangulo pero no antes depuramos un poco las entradas
            if (x < 0 || y < 0 || bas <= 0 || altura <= 0 || color == string.Empty || bas == altura || 
                txtPosX.Text == string.Empty || txtPosY.Text == string.Empty || txtBase.Text == string.Empty || 
                txtAltura.Text == string.Empty)
            {
                MessageBox.Show("Datos erroneos. Introduce Datos correctos, por favor!!!");
                if(bas == altura)
                {
                    MessageBox.Show("No puede tener la misma base y altura, si no sería un cuadrado");
                }
            }
            else
            {
                Rectangulo rectangulos = new Rectangulo(x, y, color, bas, altura);
                //Añadimos el rectangulo a la lista
                listafigura.Add(rectangulos);
                //Dejamos los textos en blanco y ponemos el foco en la primera por si queremos añadir otro
                txtPosX.Text = string.Empty;
                txtPosY.Text = string.Empty;
                txtColor.Text = string.Empty;
                txtBase.Text = string.Empty;
                txtAltura.Text = string.Empty;
                txtPosX.Focus();
            }
        }
        public string MostrarRectangulo(List<Figura> lista)
        {
            string texto = "La lista de Rectangulos es la siguiente: \n \n";
            int cont = 1;
            int control = 0;
            double sumaperimetros = 0;

            foreach (Figura f in lista)
            {
                if (f.GetType() == typeof(Rectangulo))
                {
                    texto += "Figura numero: " + cont + "\n";
                    texto += f.QuienSoy() + "\n";
                    texto += f.ToString() + "\n";
                    texto += "El Area es: " + f.Area() + "\n";
                    texto += "El Perímetro es: " + ((Rectangulo)f).Perimetro() + "\n \n";
                    sumaperimetros = sumaperimetros + ((Rectangulo)f).Perimetro();
                    cont++;
                    control++;
                }
            }
            texto += "La suma de los Perímetros es: " + sumaperimetros;
            //Utilizamos el contador control para saber si no hay ninguma en la lista
            if (control == 0)
                texto = "No hay Rectangulos añadidos";
            return texto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto;
            texto = MostrarRectangulo(listafigura);
            MessageBox.Show(texto);
        }
    }
}
