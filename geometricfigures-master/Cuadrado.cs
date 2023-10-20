using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_T8
{
    //Heredamos de la clase figura, y por ello empleamos el polimorfismo en el que un objeto (figura),
    //puede ser muchos a la vez
    public class Cuadrado : Figura
    {
        //Miembros
        private int mLado;
        
        //Porpiedades
        public int Lado
        {
            get { return mLado; }
            set { mLado = value; }
        }
        //Constructor
        public Cuadrado(int x, int y, string color, int lado) : base(x,y,color) 
        {
            mLado = lado;
        }
        //Metodos que sobreescribimos
        public override string QuienSoy()
        {
            return "CUADRADO.";
        }
        public override string ToString()
        {
            string texto = base.ToString();
            texto = texto + "\nLado: " + mLado;

            return texto;
        }
        public override double Area()
        {
            return mLado * mLado;
        }
        //Este metodo no esta heredado de la figura, por lo que despues en las listas a la hora de
        //utilizarlo habria que realizar casting.
        public double Perimetro()
        {
            //double perimetro;
            //perimetro = 4 * mLado;
            //return perimetro;
            //Esto es lo mismo que
            return 4 * mLado;
        }
    }
}
