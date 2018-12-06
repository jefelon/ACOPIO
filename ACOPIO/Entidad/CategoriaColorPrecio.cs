using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACOPIO.Entidad
{
    public class CategoriaColorPrecio
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private Categoria _categoria;

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        private Color _color;

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        private string _precio;

        public string Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        private string _razaId;

        public string RazaId
        {
            get { return _razaId; }
            set { _razaId = value; }
        }

        public CategoriaColorPrecio()
        {
            _categoria = new Categoria();
            _color = new Color();
        }
    }
}
