using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class MarcaNegocio
    {
        AccesoDatos acceso;
        List<Marca> listaMarcas;
        public List<Marca> listarMarcas()
        {
            try
            {
                listaMarcas = new List<Marca>();
                acceso = new AccesoDatos();

                acceso.SetearConsulta("SELECT Id, Descripcion FROM MARCAS");
                acceso.EjecutarLectura();

                while (acceso.Lector.Read())
                {
                    Marca marc = new Marca();
                    marc.Id = (int)acceso.Lector["Id"];
                    marc.Descripcion = (string)acceso.Lector["Descripcion"];

                    listaMarcas.Add(marc);
                }


                return listaMarcas;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                acceso.CerrarConexion();
            }

        }

        public int devuelveCantidadMarcas ()
        {
            //CONSULTA SQL : SELECT COUNT (Descripcion) FROM MARCAS;
            acceso = new AccesoDatos();
            try
            {
                acceso.SetearConsulta("SELECT COUNT (Descripcion) FROM MARCAS;");
                acceso.EjecutarFuncion();
                return (int)acceso.Resultado;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                acceso.CerrarConexion();
            }
        }

        public List <string> listarNombres() {

            List<string> nombresMarca = new List<string>();
            acceso = new AccesoDatos();
            string nombre;

            try
            {
                //consulta sql : SELECT Descripcion FROM MARCAS;
                acceso.SetearConsulta("SELECT Descripcion FROM MARCAS;");
                acceso.EjecutarLectura();
                while (acceso.Lector.Read())
                {
                    nombre = (string) acceso.Lector["Descripcion"];
                    nombresMarca.Add(nombre);
                }


                return nombresMarca;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }


        }
    }
}

