using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private object resultado;

        //Property para acceder al lector
        public SqlDataReader Lector {

            get { return lector;  }
        
        }

        //Property para acceder a la funcion hecha
        public object Resultado
        {

            get { return resultado; }

        }

        //metodos generales para acceder a bbdd
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.; database=CATALOGO_DB; Integrated Security=true");
            comando = new SqlCommand();
            
        }


        public void SetearConsulta(string texto_consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText= texto_consulta;
            comando.Connection = conexion;
        }


        //operaciones
        public void EjecutarLectura()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EjecutarAccion()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void CerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();

        }


        //Seteo de Parametros
        public void SetearParametros(string argumento, object objeto)
        {
            comando.Parameters.AddWithValue(argumento, objeto);
        }


        //Para conteo
        public void EjecutarFuncion()
        {
            try
            {
                conexion.Open();
                resultado = comando.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        

    }
}
