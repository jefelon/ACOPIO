using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACOPIO.Entidad
{
    public class Categoria
    {
        private int _id;
        private string _nombre;
        private double _precio;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
    }
}
