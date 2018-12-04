using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACOPIO.Entidad
{
   public class CategorizacionDetalle
    {
        private int _id;
        private int _nroSaco;
        private int _categorizacionId;
        private double _cantidad;
        private string _producto, _raza;
        private Categoria _categoria;
        private Color _color;
 
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int NroSaco
        {
            get { return _nroSaco; }
            set { _nroSaco = value; }
        }
        public int CategorizacionId
        {
            get { return _categorizacionId; }
            set { _categorizacionId = value; }
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
        
        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public CategorizacionDetalle()
        {
            _color = new Color();
            _categoria= new Categoria();
        }
    }
}
