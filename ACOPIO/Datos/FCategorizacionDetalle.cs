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
    public class FCategorizacionDetalle
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("select * from tblCategorizacionDetalle order by id; ", dbParams);

        }
        public static DataSet GetNroSaco()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("select max(NroSaco) as NroSaco from tblCategorizacionDetalle; ", dbParams);

        }
        public static int Insertar(CategorizacionDetalle categorizacionDetalle)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@NroSaco", DbType.Int32, 0, categorizacionDetalle.NroSaco),
                    SQLiteHelper.MakeParam("@CategorizacionId", DbType.Int32, 0, categorizacionDetalle.CategorizacionId),
                    SQLiteHelper.MakeParam("@Cantidad", DbType.Double, 0, categorizacionDetalle.Cantidad),
                    SQLiteHelper.MakeParam("@Producto", DbType.String, 0, categorizacionDetalle.Producto),
                    SQLiteHelper.MakeParam("@CategoriaId", DbType.Int32, 0, categorizacionDetalle.Categoria.Id),
                    SQLiteHelper.MakeParam("@Raza", DbType.String, 0, categorizacionDetalle.Raza),
                    SQLiteHelper.MakeParam("@ColorId", DbType.Int32, 0, categorizacionDetalle.Color.Id),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblCategorizacionDetalle(NroSaco,CategorizacionId,Cantidad,Producto,CategoriaId,Raza,ColorId) values(@NroSaco,@CategorizacionId,@Cantidad,@Producto,@CategoriaId,@Raza,@ColorId); select last_insert_rowid();", dbParams));
        }

        public static int Actualizar(CategorizacionDetalle categorizacionDetalle)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, categorizacionDetalle.Id),
                    SQLiteHelper.MakeParam("@NroSaco", DbType.Int32, 0, categorizacionDetalle.NroSaco),
                    SQLiteHelper.MakeParam("@CategorizacionId", DbType.Int32, 0, categorizacionDetalle.CategorizacionId),
                    SQLiteHelper.MakeParam("@Cantidad", DbType.Double, 0, categorizacionDetalle.Cantidad),
                    SQLiteHelper.MakeParam("@Producto", DbType.String, 0, categorizacionDetalle.Producto),
                    SQLiteHelper.MakeParam("@CategoriaId", DbType.Int32, 0, categorizacionDetalle.Color.Id),
                    SQLiteHelper.MakeParam("@Raza", DbType.String, 0, categorizacionDetalle.Raza),
                    SQLiteHelper.MakeParam("@ColorId", DbType.Int32, 0, categorizacionDetalle.Color.Id),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblCategorizacionDetalle set NroSaco=@NroSaco,CategorizacionId=@CategorizacionId,Cantidad=@Cantidad,Producto=@Producto,CategoriaId=@CategoriaId,Raza=@Raza,ColorId=@ColorId  WHERE Id=@Id", dbParams));

        }

        public static int Eliminar(CategorizacionDetalle categorizacionDetalle)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, categorizacionDetalle.Id), 
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblCategorizacionDetalle WHERE Id= @Id", dbParams));

        }
    }
}
