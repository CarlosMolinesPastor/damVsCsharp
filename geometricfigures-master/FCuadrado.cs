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
    public partial class FCuadrado : Form
    {
        public FCuadrado()
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

            //Se igualan las variables a los campos de texto, y despues dse comprueba que los datos sean los 
            //Correctos
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
                //Se crea un nuevo cuadrad, se añade a la lista y se da el foco al primer txtBox
                Cuadrado cuadrado = new Cuadrado(x, y, color, lado);
                listafiguras.Add(cuadrado);
                txtPosX.Text = string.Empty;
                txtPosY.Text = string.Empty;
                txtColor.Text = string.Empty;
                txtLado.Text = string.Empty;
                txtPosX.Focus();
            }
        }

        string MostrarCuadrado(List<Figura> listafigura)
        {
            //Primero variable de devolucion y el contador
            string texto = "Los Cuadrados son los siguientes: \n \n";
            int cont = 1;
            int control = 0; //Variable contador de control de lista vacia;
            double sumaperimetros = 0;
            //Segundo recorremos la lista

            foreach (Figura figura in listafigura)
            {
                //Creamos la variable para mostrar los cuadrados, es decir ver si son del tipo
                if (figura.GetType() == typeof(Cuadrado))
                {
                    texto += "Figura numero: " + cont + "\n";
                    texto += figura.QuienSoy() + "\n";
                    texto += figura.ToString() + "\n";
                    texto += "Mi Area es: " + figura.Area() + "\n";
                    //Aqui habria que hacer casting a la figura pues el perimetro no es heredado
                    texto += "El Perimetro es: " + ((Cuadrado)figura).Perimetro() + "\n \n";
                    sumaperimetros = sumaperimetros + ((Cuadrado)figura).Perimetro();
                    cont++;
                    control++;
                }
            }
            texto = texto + "\nLa suma de los perímetros es " + sumaperimetros;

            if (control == 0)
                texto = "No hay Cuadrados en la lista";
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
            texto = MostrarCuadrado(listafiguras);
            MessageBox.Show(texto);
        }
    }
}
