using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACOPIO.Entidad
{
   public class Usuario
    {
        private static int _id;
        private static string _nombreUsuario, _contrasena, _tipo;
        private static int _centroAcopioId, _campaniaId;

        public static int CampaniaId
        {
            get { return Usuario._campaniaId; }
            set { Usuario._campaniaId = value; }
        }

        public static int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        
        public static string NombreUsuario
        {
            get
            {
                return _nombreUsuario;
            }

            set
            {
                _nombreUsuario = value;
            }
        }


        public static string Contrasena
        {
            get
            {
                return _contrasena;
            }

            set
            {
                _contrasena = value;
            }
        }

        public static string Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                _tipo = value;
            }
        }

        public static int CentroAcopioId
        {
            get { return _centroAcopioId; }
            set { _centroAcopioId = value; }
        }
    }
}
