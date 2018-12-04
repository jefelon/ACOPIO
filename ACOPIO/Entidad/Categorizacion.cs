using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACOPIO.Entidad
{
    public class Categorizacion
    {
        private int _id;
        private DateTime _fecha;
        private CentroAcopio _centroAcopio;
        private Campania _campania;
        private int _usuarioId;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }   

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }      

        public CentroAcopio CentroAcopio
        {
            get { return _centroAcopio; }
            set { _centroAcopio = value; }
        }      

        public Campania Campania
        {
            get { return _campania; }
            set { _campania = value; }
        }    

        public int UsuarioId
        {
            get { return _usuarioId; }
            set { _usuarioId = value; }
        }

        public Categorizacion()
        {
            _centroAcopio = new CentroAcopio();
            _campania = new Campania();
        }
    }
}
