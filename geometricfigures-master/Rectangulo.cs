using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace E2_T8
{
    //Heredamos de la clase figura, y por ello empleamos el polimorfismo en el que un objeto (figura),
    //puede ser muchos a la vez
    public class Rectangulo: Figura
    {
        //Miembros
        private int mbase;
        private int maltura;
        //
        //Propiedades
        //
        public int Base
        {
            get { return mbase; }
            set {  mbase = value;}
        }
        public int Altura
        {
            get { return maltura; }
            set { maltura = value; }
        }
        //
        //Conntructor
        //
        public Rectangulo (int x, int y, string color, int bas, int altura):base(x,y,color)
        {
            mbase = bas;
            maltura = altura;
        }
        //
        //Metodos
        //
        public override double Area()
        {
            return mbase * maltura;
        }
        public override string QuienSoy()
        {
            return "RECTANGULO";
        }
        public override string ToString()
        {
            string texto;
            
            texto = base.ToString();
            texto += "\nLa Base es: " + mbase;
            texto += "\nla Altura es: " + maltura;


            return texto;
        }
        //Este metodo no esta heredado de la figura, por lo que despues en las listas a la hora de
        //utilizarlo habria que realizar casting.
        public double Perimetro()
        {
            return (2*mbase) + (2*maltura);
        }
    }
}
