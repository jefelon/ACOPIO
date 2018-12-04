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
   public class FCampania
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("select * from tblCampania order by id; ", dbParams);
        }
        public static int Insertar(Campania campania)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                     SQLiteHelper.MakeParam("@Nombre", DbType.String, 0, campania.Nombre),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblCampania(Nombre) values(@Nombre); select last_insert_rowid();", dbParams));
        }

        public static int Actualizar(Campania campania)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, campania.Id),
                     SQLiteHelper.MakeParam("@Nombre", DbType.String, 0, campania.Nombre),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblCampania set Nombre=@Nombre   WHERE Id=@Id", dbParams));

        }

        public static int Eliminar(Campania campania)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, campania.Id), 
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblCampania WHERE Id= @Id", dbParams));

        }
    }
}
