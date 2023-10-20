using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_T8
{
    //Heredamos de la clase figura, y por ello empleamos el polimorfismo en el que un objeto (figura),
    //puede ser muchos a la vez
    public class Triangulo :Figura
    {
        //Miembro
        private int mlado;

        //Propiedad
        public int Lado
        {
            get { return mlado; }
            set { mlado = value; }
        }
        //Constructor
        public Triangulo(int x, int y, string color, int lado): base (x, y, color)
        {
            mlado = lado;
        }
        //Metodos heredados
        public override string QuienSoy()
        {
            return "TRIANGULO.";
        }
        public override string ToString()
        {
            string texto;
            texto = base.ToString();
            texto += "\nLado: " + mlado;
            return texto;
        }
        public override double Area()
        {
            return (mlado * ((mlado * Math.Sqrt(3)) / 2)) / 2;
        }
        //Este metodo no esta heredado de la figura, por lo que despues en las listas a la hora de
        //utilizarlo habria que realizar casting.
        public double PerimetroTriangulo()
        {
            return 3 * mlado;
        }
    }
}
