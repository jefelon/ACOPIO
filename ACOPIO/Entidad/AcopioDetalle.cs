using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACOPIO.Entidad
{
   public  class AcopioDetalle
    {
        private int _id;
        private int _acopioId;
        private double _cantidad;
        private string _producto, _calidad, _raza;
        private Color _color;
        private double _valorUnitario;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }        

        public int AcopioId
        {
            get { return _acopioId; }
            set { _acopioId = value; }
        }
     
        public double Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
       

        public string Raza
        {
            get { return _raza; }
            set { _raza = value; }
        }

        public string Calidad
        {
            get { return _calidad; }
            set { _calidad = value; }
        }

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        
        public double ValorUnitario
        {
            get { return _valorUnitario; }
            set { _valorUnitario = value; }
        }

        public AcopioDetalle()
        {
            _color = new Color();
        }
    }
}
