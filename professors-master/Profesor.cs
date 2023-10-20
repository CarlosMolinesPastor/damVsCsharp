using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesores2
{
    internal class Profesor
    {
        //Miembros
        private string mDni, mNombre, mApellidos, mTelefono, mEmail;

        //Propiedades
        public string Dni
        {
            get { return mDni; }
            set { mDni = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string Apellidos
        {
            get { return mApellidos; }
            set { mApellidos = value; }
        }

        public string Telefono
        {
            get { return mTelefono; }
            set { mTelefono = value; }
        }

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        //Constructor
        public Profesor(string dni, string nombre, string apellidos, string telefono, string email)
        {
            mDni = dni;
            mNombre = nombre;
            mApellidos = apellidos;
            mTelefono = telefono;
            mEmail = email;
        }
    }
}
