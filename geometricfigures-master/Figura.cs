using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_T8
{
    public abstract class Figura
    {
        //Miembros de la clase siempre en private a no ser que queramos acceder desde fuera
        private int mPosicionX, mPosicionY;
        private string mColor;

        //Propiedades de la clase propiedades publicas
        public int PosicionX
        {
            get { return mPosicionX; }
            set { mPosicionX = value; }
        }
        public int PosicionY
        {
            get { return mPosicionY; }
            set { mPosicionY = value; }
        }
        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        /*Constructor, es decir los valores que le asignamos al crear un objeto nuevo, se llama como la clase
        le asignamos 
        */
        public Figura(int x, int y, string color)
        {
            mPosicionX = x;
            mPosicionY = y;
            mColor = color;
        }
        //Metodos 

        // Metodo Virtual para despues modificarlo
        public virtual string QuienSoy()
        {
            return "Soy una figura";
        }

        //Metodo de sobreescritura del metodo ToString que heredamos de System.Object
        public override string ToString()
        {
            string texto;

            texto = "Posicion X: " + mPosicionX + 
                "\nPosicion Y: " + mPosicionY + 
                "\nColor: " + mColor;
            return texto;
        }

        //Metodo Abstracto de area. No tiene cuerpo, se reescribe en las clases de herencia de las distintas figuras
        // Triangulo, circulo...
        public abstract double Area();
    }
}
