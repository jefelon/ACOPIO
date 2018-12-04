using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACOPIO.Entidad;
using System.Data;
using System.Data.SQLite;
using Aqpfact.FDatos;

namespace ACOPIO.Datos
{
    public class FAcopioDetalle
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("select * from tblAcopioDetalle order by id; ", dbParams);

        }
        public static int Insertar(AcopioDetalle acopioDetalle)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@AcopioId", DbType.Int32, 0, acopioDetalle.AcopioId),
                    SQLiteHelper.MakeParam("@Cantidad", DbType.Double, 0, acopioDetalle.Cantidad),
                    SQLiteHelper.MakeParam("@Producto", DbType.String, 0, acopioDetalle.Producto),
                    SQLiteHelper.MakeParam("@Calidad", DbType.String, 0, acopioDetalle.Calidad),
                    SQLiteHelper.MakeParam("@Raza", DbType.String, 0, acopioDetalle.Raza),
                    SQLiteHelper.MakeParam("@ColorId", DbType.Int32, 0, acopioDetalle.Color.Id),
                    SQLiteHelper.MakeParam("@ValorUnitario", DbType.Double, 0, acopioDetalle.ValorUnitario)
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblAcopioDetalle(AcopioId,Cantidad,Producto,Calidad,Raza,ColorId,ValorUnitario) values(@AcopioId,@Cantidad,@Producto,@Calidad,@Raza,@ColorId,@ValorUnitario); select last_insert_rowid();", dbParams));
        }

        public static int Actualizar(AcopioDetalle acopioDetalle)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, acopioDetalle.Id),
                    SQLiteHelper.MakeParam("@AcopioId", DbType.Int32, 0, acopioDetalle.AcopioId),
                    SQLiteHelper.MakeParam("@Cantidad", DbType.Double, 0, acopioDetalle.Cantidad),
                    SQLiteHelper.MakeParam("@Producto", DbType.String, 0, acopioDetalle.Producto),
                    SQLiteHelper.MakeParam("@Calidad", DbType.String, 0, acopioDetalle.Calidad),
                    SQLiteHelper.MakeParam("@Raza", DbType.String, 0, acopioDetalle.Raza),
                    SQLiteHelper.MakeParam("@ColorId", DbType.Int32, 0, acopioDetalle.Color.Id),
                    SQLiteHelper.MakeParam("@ValorUnitario", DbType.Double, 0, acopioDetalle.ValorUnitario)
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblAcopioDetalle set AcopioId=@AcopioId,Cantidad=@Cantidad,Producto=@Producto,Calidad=@Calidad,Raza=@Raza,ColorId=@ColorId,ValorUnitario=@ValorUnitario   WHERE Id=@Id", dbParams));

        }

        public static int Eliminar(AcopioDetalle acopioDetalle)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, acopioDetalle.Id), 
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblAcopioDetalle WHERE Id= @Id", dbParams));

        }
    }
}
