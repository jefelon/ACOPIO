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
   public class FCategoriaColorPrecio
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("SELECT tblCategoriaColorPrecio.RazaId as Raza, tblCategoriaColorPrecio.Id, tblCategoria.Id AS CategoriaId, tblCategoria.Nombre AS Categoria, tblColor.Id AS ColorId, tblColor.Nombre AS Color, tblCategoriaColorPrecio.Precio FROM tblCategoriaColorPrecio INNER JOIN tblCategoria ON tblCategoria.Id = tblCategoriaColorPrecio.CategoriaId INNER JOIN tblColor ON tblCategoriaColorPrecio.ColorId = tblColor.Id order by tblCategoriaColorPrecio.Id; ", dbParams);

        }
        public static int Insertar(CategoriaColorPrecio categoriaColorPrecio)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                     SQLiteHelper.MakeParam("@CategoriaId", DbType.Int32, 0, categoriaColorPrecio.Categoria.Id),
                     SQLiteHelper.MakeParam("@ColorId", DbType.Int32, 0, categoriaColorPrecio.Color.Id),
                     SQLiteHelper.MakeParam("@Precio", DbType.Decimal, 0, categoriaColorPrecio.Precio),
                     SQLiteHelper.MakeParam("@RazaId", DbType.String, 0, categoriaColorPrecio.RazaId),

                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblCategoriaColorPrecio(CategoriaId,ColorId,Precio,RazaId) values(@CategoriaId,@ColorId,@Precio,@RazaId); select last_insert_rowid();", dbParams));
        }

        public static int Actualizar(CategoriaColorPrecio categoriaColorPrecio)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, categoriaColorPrecio.Id),
                    SQLiteHelper.MakeParam("@CategoriaId", DbType.Int32, 0, categoriaColorPrecio.Categoria.Id),
                     SQLiteHelper.MakeParam("@ColorId", DbType.Int32, 0, categoriaColorPrecio.Color.Id),
                     SQLiteHelper.MakeParam("@Precio", DbType.Decimal, 0, categoriaColorPrecio.Precio),
                     SQLiteHelper.MakeParam("@RazaId", DbType.String, 0, categoriaColorPrecio.RazaId),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblCategoriaColorPrecio set Fecha=@Fecha,CentroAcopioId=@CentroAcopioId,CampaniaId=@CampaniaId,Productorid=@ProductorId   WHERE Id=@Id", dbParams));

        }
        public static int ActualizarPrecio(CategoriaColorPrecio categoriaColorPrecio)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, categoriaColorPrecio.Id),
                    SQLiteHelper.MakeParam("@Precio", DbType.Decimal, 0, categoriaColorPrecio.Precio),

                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblCategoriaColorPrecio set Precio=@Precio   WHERE Id=@Id", dbParams));

        }

        public static int Eliminar(CategoriaColorPrecio categoriaColorPrecio)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, categoriaColorPrecio.Id), 
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblCategoriaColorPrecio WHERE Id= @Id", dbParams));

        }
    }
}
