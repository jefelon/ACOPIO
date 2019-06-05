using ACOPIO.Entidad;
using Aqpfact.FDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace ACOPIO.Datos
{
    public class FUsuario
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("select * from tblUsuario order by id; ", dbParams);

        }
        public static DataSet iniciarSesion(string sUsuario, string sContrasena)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@NombreUsuario", DbType.String, 0, sUsuario),
                    SQLiteHelper.MakeParam("@Contrasena", DbType.String, 0, sContrasena),
                };
            return SQLiteHelper.ExecuteDataSet("select * from tblUsuario WHERE NombreUsuario=@NombreUsuario AND Contrasena=@Contrasena; ", dbParams);

        }
        public static int Insertar(Usuario usuario)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                     //SQLiteHelper.MakeParam("@NombreUsuario", DbType.String, 0, usuario.Nombre),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblUsuario(Nombre) values(@Nombre); select last_insert_rowid();", dbParams));
        }

        public static int ActualizarNombreUsuario(int id, string nombreUsuario)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, id),
                    SQLiteHelper.MakeParam("@NombreUsuario", DbType.String, 0, nombreUsuario),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblUsuario set NombreUsuario=@NombreUsuario   WHERE Id=@Id", dbParams));

        }
        public static int ActualizarClaveUsuario(int id, string clave)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, id),
                    SQLiteHelper.MakeParam("@Clave", DbType.String, 0, clave),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblUsuario set Contrasena=@Clave   WHERE Id=@Id", dbParams));

        }
        
        public static int Eliminar(Usuario usuario)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    //SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, usuario.Id),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblUsuario WHERE Id= @Id", dbParams));

        }
    }
}
