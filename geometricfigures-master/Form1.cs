using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace E2_T8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ########## Creamos la lista de figuras ################
        List<Figura> listafiguras = new List<Figura>();
        //########### Podemos hacer un subprograma para introducir las posiciones propias de la figura y así estructurar mejor los datos
       

        //Funcion Mostrar todos los datos de las figuras
        string MostrarFiguras(List<Figura> listafigura)
        {
            string texto = "Las figuras son las siguientes: \n \n";
            int cont = 1;
            //Recorremos la lista y vamos mostrando los datos de la misma
            if (listafiguras.Count > 0)
            {
                foreach (Figura f in listafigura)
                {
                    texto = texto + "Figura numero: " + cont + "\n";
                    texto = texto + f.QuienSoy() + "\n";
                    texto = texto + f.ToString() + "\n";
                    texto = texto + "Mi area es: " + f.Area() + "\n \n";
                    //En las figuras no se puede añadir el perimetro porque no es una funcion heredada.

                    cont++;
                }
                texto += "La suma de todos los Perímetros es: " + SumasPerimetros(listafigura) + "\n";
            }
            else texto = "No hay Figuras en la lista.";
            //Devolvemos la variable con todos los datos de la figura.
            return texto;
        }

        //Creamos otra funcion para devolver los datos de los circulos y de los cuadrados,
        //La formulacion sería la misma que para las figuras pero aqui vamos aprendiendo a manejar  GetType y typeof
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
        //Mostrar Triangulo
        string MostrarTriangulo(List<Figura> listafigura)
        {
            string texto = "La lista de TRIANGULOS es la siguiente: \n \n";
            int cont = 1; //Numeracion de los triangulos
            int control =0; //Control de lista vacia
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
                    sumaperimetros = sumaperimetros + ((Triangulo)f).PerimetroTriangulo(); 
                    cont++;
                    control++;
                }
            }
            texto += "\nLa suma de los perimetros es " +sumaperimetros;
            if (control == 0) texto = "No existen Triangulo en la lista";
            return texto;
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
                    texto += "El Perímetro es: " + ((Rectangulo)f).Perimetro() +"\n \n";
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
        public string MostrarHexagono(List<Figura> lista)
        {
            string texto = "La lista de Hexagonos es la siguiente: \n \n";
            int cont = 1;
            int control = 0;
            double sumaperimetros = 0;

            foreach (Figura f in lista)
            {
                if(f.GetType() == typeof(Hexagono))
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
        //############################### SUMA DE PERIMETROS QUE SE HA IDO AÑADIENDO A LO LARGO DEL CODIFICADO  ##########################
        //Creamos funcion para devolver el perimetro, suma los perimetros totales
        double SumasPerimetros(List<Figura> listafigura)
        {
            double suma = 0;
            foreach (Figura figura in listafigura)
            {
                //Añadimos la suma de los perimetros de las diferentes figuras.
                if (figura.GetType() == typeof(Cuadrado))
                {
                    suma = suma + ((Cuadrado)figura).Perimetro();
                }
                if (figura.GetType() == typeof(Circulo))
                {
                    suma = suma + ((Circulo)figura).Perimetro();
                }
                if (figura.GetType() == typeof(Triangulo))
                {
                    suma = suma + ((Triangulo)figura).PerimetroTriangulo();
                }
                if (figura.GetType() == typeof(Rectangulo))
                {
                    suma = suma + ((Rectangulo)figura).Perimetro();
                }
                if (figura.GetType()==typeof(Hexagono))
                {
                    suma = suma + ((Hexagono)figura).Perimetro();
                }
            }
            return suma;
        }

        //#############################################################################################################################
        private void bIntroCirculo_Click(object sender, EventArgs e)
        {
            FCirculo fcir = new FCirculo();
            fcir.listafiguras = listafiguras;
            fcir.ShowDialog();
        }

        private void bIntroCuadrado_Click(object sender, EventArgs e)
        {
            FCuadrado fcua = new FCuadrado();
            fcua.listafiguras = listafiguras;
            fcua.ShowDialog();
        }

        private void bMostrarTodos_Click(object sender, EventArgs e)
        {
            //Hacemos funcion con Mostrar Figuras para estructurar mejor
            string texto = MostrarFiguras(listafiguras);

            MessageBox.Show(texto);
        }

        private void bMostrarCirculos_Click(object sender, EventArgs e)
        {
            string texto = MostrarCirculos(listafiguras);

            MessageBox.Show(texto);
        }

        private void bMostrarCuadrados_Click(object sender, EventArgs e)
        {
            string texto = MostrarCuadrado(listafiguras);
            MessageBox.Show(texto); 
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            FTriangulo fTriangulo = new FTriangulo();
            fTriangulo.listafiguras = listafiguras;
            fTriangulo.ShowDialog();
        }

        private void bMostrarTriangulos_Click(object sender, EventArgs e)
        {
            string texto = MostrarTriangulo(listafiguras);
            MessageBox.Show(texto);
        }

        private void bRectangulo_Click(object sender, EventArgs e)
        {
            //Creo el formulario
            FRectangulo frectangulo = new FRectangulo();
            //Igualamos la lista figuras aqui creada con la que llamamos desde el formulario rectangulo
            frectangulo.listafigura = listafiguras;
            //Apuntamos al formulario
            frectangulo.ShowDialog();

        }

        private void bMostrarRectangulo_Click(object sender, EventArgs e)
        {
            string texto =  MostrarRectangulo(listafiguras);
            MessageBox.Show(texto);
        }

        private void bHexagono_Click(object sender, EventArgs e)
        {
            FHexagono fhexagono = new FHexagono();
            fhexagono.listafiguras = listafiguras;
            fhexagono.ShowDialog();
        }

        private void bMostrarHexagonos_Click(object sender, EventArgs e)
        {
            string texto = MostrarHexagono(listafiguras);
            MessageBox.Show(texto);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        //###########################################################################################################################

    }
}
