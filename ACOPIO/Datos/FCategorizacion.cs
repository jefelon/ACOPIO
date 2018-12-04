using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using Aqpfact.FDatos;
using ACOPIO.Entidad;

namespace ACOPIO.Datos
{
    public class FCategorizacion
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("select * from tblCategorizacion order by id; ", dbParams);

        }
        public static int Insertar(Categorizacion categorizacion)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                     SQLiteHelper.MakeParam("@Fecha", DbType.DateTime, 0, categorizacion.Fecha),
                     SQLiteHelper.MakeParam("@CentroAcopioId", DbType.Int32, 0, categorizacion.CentroAcopio.Id),
                     SQLiteHelper.MakeParam("@CampaniaId", DbType.Int32, 0, categorizacion.Campania.Id),
                     SQLiteHelper.MakeParam("@UsuarioId", DbType.Int32, 0, categorizacion.UsuarioId)
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblCategorizacion(Fecha,CentroAcopioId,CampaniaId,UsuarioId) values(@Fecha,@CentroAcopioId,@CampaniaId,@UsuarioId); select last_insert_rowid();", dbParams));
        }

        public static int Actualizar(Categorizacion categorizacion)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, categorizacion.Id),
                    SQLiteHelper.MakeParam("@Fecha", DbType.DateTime, 0, categorizacion.Fecha),
                    SQLiteHelper.MakeParam("@CentroAcopioId", DbType.Int32, 0, categorizacion.CentroAcopio.Id),
                    SQLiteHelper.MakeParam("@CampaniaId", DbType.Int32, 0, categorizacion.Campania.Id),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblCategorizacion set Fecha=@Fecha,CentroAcopioId=@CentroAcopioId,CampaniaId=@CampaniaId   WHERE Id=@Id", dbParams));

        }

        public static int Eliminar(Categorizacion categorizacion)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, categorizacion.Id), 
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblCategorizacion WHERE Id= @Id", dbParams));

        }
    }
}
