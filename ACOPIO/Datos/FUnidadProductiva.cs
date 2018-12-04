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
    public class FUnidadProductiva
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("select * from tblUnidadProductiva order by id; ", dbParams);

        }
        public static int Insertar(UnidadProductiva unidadProductiva)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                     SQLiteHelper.MakeParam("@Nombre", DbType.String, 0, unidadProductiva.Nombre),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblUnidadProductiva(Nombre) values(@Nombre); select last_insert_rowid();", dbParams));
        }

        public static int Actualizar(UnidadProductiva unidadProductiva)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, unidadProductiva.Id),
                     SQLiteHelper.MakeParam("@Nombre", DbType.String, 0, unidadProductiva.Nombre),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblUnidadProductiva set Nombre=@Nombre   WHERE Id=@Id", dbParams));

        }

        public static int Eliminar(UnidadProductiva unidadProductiva)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, unidadProductiva.Id), 
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblUnidadProductiva WHERE Id= @Id", dbParams));

        }
    }
}
