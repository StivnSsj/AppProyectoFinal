using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ProyectoFinal.AccesoDatos
{
    internal class Datos
    {
        string cadenaConexion = "Data Source = localhost; User ID = bases1; Password=oracle";

        //Metodo para ejecutar sentencia DML(Insert, Update o Delete)
        public int ejecutarDML(String consulta)
        {
            int filasAfectadas;
            //Crear una conexion
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            //Crear comando
            OracleCommand comando = new OracleCommand(consulta, miConexion);
            //Abrir Conexion
            miConexion.Open();
            //Ejecutar el cmd este retorna el numero de filas afectadas
            filasAfectadas = comando.ExecuteNonQuery();
            //Cerrar la Conexion
            miConexion.Close();

            return filasAfectadas;
        }

        internal DataSet ejecutarSELECT(string consulta)
        {
            //Crear DataSet vacio
            DataSet ds = new DataSet();
            //Crear un adaptador 
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta,cadenaConexion);
            //Llenar DataSet ds a travez del adaptador
            adaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }
    }
}
