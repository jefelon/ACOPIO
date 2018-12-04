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
    public class FCentroAcopio
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("select * from tblCentroAcopio order by id; ", dbParams);

        }
        public static int Insertar(CentroAcopio centroAcopio)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                     SQLiteHelper.MakeParam("@Nombre", DbType.String, 0, centroAcopio.Nombre),
                     SQLiteHelper.MakeParam("@Ubicacion", DbType.String, 0, centroAcopio.Ubicacion),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblCentroAcopio(Nombre,Ubicacion) values(@Nombre,@Ubicacion); select last_insert_rowid();", dbParams));
        }

        public static int Actualizar(CentroAcopio centroAcopio)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, centroAcopio.Id),
                    SQLiteHelper.MakeParam("@Nombre", DbType.String, 0, centroAcopio.Nombre),
                    SQLiteHelper.MakeParam("@Ubicacion", DbType.String, 0, centroAcopio.Ubicacion),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblCentroAcopio set Nombre=@Nombre, Ubicacion=@Ubicacion  WHERE Id=@Id", dbParams));

        }

        public static int Eliminar(CentroAcopio centroAcopio)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, centroAcopio.Id), 
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblCentroAcopio WHERE Id= @Id", dbParams));

        }
    }
}
