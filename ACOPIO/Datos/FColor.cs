using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using Aqpfact.FDatos;
using ACOPIO.Entidad;

namespace ACOPIO.Datos
{
    public class FColor
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("select * from tblColor order by id; ", dbParams);

        }
        public static int Insertar(Color color)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                     SQLiteHelper.MakeParam("@Nombre", DbType.String, 0, color.Nombre),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblColor(Nombre) values(@Nombre); select last_insert_rowid();", dbParams));
        }

        public static int Actualizar(Color color)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, color.Id),
                     SQLiteHelper.MakeParam("@Nombre", DbType.String, 0, color.Nombre),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblColor set Nombre=@Nombre   WHERE Id=@Id", dbParams));

        }

        public static int Eliminar(Color color)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, color.Id), 
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblColor WHERE Id= @Id", dbParams));

        }
    }
}
