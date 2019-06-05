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
    public class FAcopio
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("SELECT        tblAcopio.Id, tblAcopio.Fecha, tblCentroAcopio.Nombre AS CentroAcopio, tblCampania.Nombre AS Campania, tblProductor.Dni, tblProductor.Nombre FROM            tblAcopio INNER JOIN tblProductor ON tblAcopio.ProductorId = tblProductor.Id INNER JOIN tblCampania ON tblAcopio.CampaniaId = tblCampania.Id INNER JOIN tblCentroAcopio ON tblAcopio.CentroAcopioId = tblCentroAcopio.Id ORDER BY tblAcopio.Id; ", dbParams);

        }
        public static int Insertar(Acopio acopio)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                     SQLiteHelper.MakeParam("@Fecha", DbType.DateTime, 0, acopio.Fecha),
                     SQLiteHelper.MakeParam("@CentroAcopioId", DbType.Int32, 0, acopio.CentroAcopio.Id),
                     SQLiteHelper.MakeParam("@CampaniaId", DbType.Int32, 0, acopio.Campania.Id),
                     SQLiteHelper.MakeParam("@ProductorId", DbType.Int32, 0, acopio.Productor.Id),
                     SQLiteHelper.MakeParam("@UsuarioId", DbType.Int32, 0, acopio.UsuarioId)
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblAcopio(Fecha,CentroAcopioId,CampaniaId,Productorid,UsuarioId) values(@Fecha,@CentroAcopioId,@CampaniaId,@Productorid,@UsuarioId); select last_insert_rowid();", dbParams));
        }

        public static int Actualizar(Acopio acopio)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, acopio.Id),
                    SQLiteHelper.MakeParam("@Fecha", DbType.DateTime, 0, acopio.Fecha),
                    SQLiteHelper.MakeParam("@CentroAcopioId", DbType.Int32, 0, acopio.CentroAcopio.Id),
                    SQLiteHelper.MakeParam("@CampaniaId", DbType.Int32, 0, acopio.Campania.Id),
                    SQLiteHelper.MakeParam("@ProductorId", DbType.Int32, 0, acopio.Productor.Id)
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblAcopio set Fecha=@Fecha,CentroAcopioId=@CentroAcopioId,CampaniaId=@CampaniaId,Productorid=@ProductorId   WHERE Id=@Id", dbParams));

        }

        public static int Eliminar(Acopio acopio)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, acopio.Id), 
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblAcopio WHERE Id= @Id", dbParams));

        }
    }
}
