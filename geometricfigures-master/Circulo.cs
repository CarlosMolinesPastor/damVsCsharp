using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_T8
{
    //Heredamos de la clase figura, y por ello empleamos el polimorfismo en el que un objeto (figura),
    //puede ser muchos a la vez
    public class Circulo: Figura
    {
        //Miembro propio del circulo es el radio;
        private int mRadio;

        //Propiedades;
        public int Radio
        {
            get { return mRadio; }
            set { mRadio = value; }
        }

        //Constructor al que hay que pasarle los datos de la firura y del propio cirulo y decirle los quie son de la figura
        public Circulo(int x, int y, string color, int radio) : base (x,y,color)
        {
            mRadio = radio;
        }

        //Metodos hay que sobrescribir los metodos de Figura
        public override string QuienSoy()
        {
            return "CIRCULO.";
        }
        public override string ToString()
        {
            string texto;
            
            texto = base.ToString();
            texto = texto + "\nRadio: " + mRadio;

            return texto;
        }
        public override double Area()
        {
            return Math.PI * mRadio * mRadio;
        }
        //Este metodo no esta heredado de la figura, por lo que despues en las listas a la hora de
        //utilizarlo habria que realizar casting.
        public double Perimetro()
        {
            return (2*mRadio) * Math.PI;
        }
    }
}
