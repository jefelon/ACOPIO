using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACOPIO.Entidad
{
    public class Productor
    {
        private int _id, _edad;
        private string _dni, _nombre, _sexo, _socio;
        private UnidadProductiva _unidadProductiva;

       
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public string Socio
        {
            get { return _socio; }
            set { _socio = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }


        public UnidadProductiva UnidadProductiva
        {
            get { return _unidadProductiva; }
            set { _unidadProductiva = value; }
        }

        public Productor()
        {
            _unidadProductiva = new UnidadProductiva();
        }
    }
}
