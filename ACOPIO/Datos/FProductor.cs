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
    public class FProductor
    {
        public static DataSet GetAll()
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {

                };
            return SQLiteHelper.ExecuteDataSet("select tblProductor.Id, tblProductor.Dni, tblProductor.Nombre, tblProductor.Sexo, tblProductor.Edad, tblProductor.Socio , up.Nombre as UnidadProductiva from tblProductor " +
                "INNER JOIN tblUnidadProductiva up ON tblProductor.UnidadProductivaId= up.Id " +
                "order by tblProductor.id; ", dbParams);

        }
        public static int Insertar(Productor productor)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                     SQLiteHelper.MakeParam("@Dni", DbType.String, 0, productor.Dni),
                     SQLiteHelper.MakeParam("@Nombre", DbType.String, 0, productor.Nombre),
                     SQLiteHelper.MakeParam("@Sexo", DbType.String, 0, productor.Sexo),
                     SQLiteHelper.MakeParam("@Edad", DbType.String, 0, productor.Edad),
                     SQLiteHelper.MakeParam("@Socio", DbType.String, 0, productor.Socio),
                     SQLiteHelper.MakeParam("@UnidadProductivaId", DbType.String, 0, productor.UnidadProductiva.Id),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("insert into tblProductor(Dni,Nombre,Sexo,Edad,Socio,UnidadProductivaId) values(@Dni,@Nombre,@Sexo,@Edad,@Socio,@UnidadProductivaId); select last_insert_rowid();", dbParams));
        }

        public static int Actualizar(Productor productor)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, productor.Id),
                     SQLiteHelper.MakeParam("@Dni", DbType.String, 0, productor.Dni),
                     SQLiteHelper.MakeParam("@Nombre", DbType.String, 0, productor.Nombre),
                     SQLiteHelper.MakeParam("@Sexo", DbType.String, 0, productor.Sexo),
                     SQLiteHelper.MakeParam("@Edad", DbType.String, 0, productor.Edad),
                     SQLiteHelper.MakeParam("@Socio", DbType.String, 0, productor.Socio),
                     SQLiteHelper.MakeParam("@UnidadProductivaId", DbType.String, 0, productor.UnidadProductiva.Id),
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("update tblProductor set Dni=@Dni,Nombre=@Nombre,Sexo=@Sexo,Edad=@Edad,Socio=@Socio,UnidadProductivaId=@UnidadProductivaId   WHERE Id=@Id", dbParams));

        }

        public static int Eliminar(Productor productor)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Id", DbType.Int32, 0, productor.Id), 
                };
            return Convert.ToInt32(SQLiteHelper.ExecuteScalar("DELETE FROM tblProductor WHERE Id= @Id", dbParams));

        }
        public static DataSet Buscar(string dni)
        {
            SQLiteParameter[] dbParams = new SQLiteParameter[]
                {
                    SQLiteHelper.MakeParam("@Dni", DbType.String, 0, dni),
                };
            return SQLiteHelper.ExecuteDataSet(" SELECT p.Id, Dni, p.Nombre, up.Nombre AS 'UnidadProductiva' FROM tblProductor as p INNER JOIN tblUnidadProductiva as up ON  p.UnidadProductivaId= up.Id ", dbParams);

        }
    }
}
