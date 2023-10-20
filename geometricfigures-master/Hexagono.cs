using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace E2_T8
{
    //Heredamos de la clase figura, y por ello empleamos el polimorfismo en el que un objeto (figura),
    //puede ser muchos a la vez
    public class Hexagono: Figura
    {
        //Miembros
        private int mlado;
        //Propiedades
        public int Lado
        {
            get { return mlado; }
            set { mlado = value; }
        }
        //Constructor
        public Hexagono(int x, int y, string color, int lado): base(x,y,color)
        {
            mlado = lado;
        }
        //Metodos
        public override string QuienSoy()
        {
            return "HEXAGONO";
        }
        public override string ToString()
        {
            string texto = base.ToString();
            texto += "\nLado: " + mlado;
            return texto;
        }
        public override double Area()
        {
            //El area es igual al perimetro * apotema/2
            //El apotema es igual raiz cuadrada del lado al cuadrado - lado/2 al cuadrado, para lo que creamos una funcion
            return (Perimetro() * Apotema()) / 2;
        }
        public double Apotema()
        {
            double apotema;
            apotema = Math.Sqrt((mlado * mlado) - ((mlado / 2) * (mlado / 2)));
            return apotema;
        }
        //Este metodo no esta heredado de la figura, por lo que despues en las listas a la hora de
        //utilizarlo habria que realizar casting.
        public double Perimetro()
        {
            return 6* mlado;
        }
    }
}
