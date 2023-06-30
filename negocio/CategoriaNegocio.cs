using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        private List<Categoria> listaCategorias;
        private AccesoDatos acceso;
        public List <Categoria> listarCategorias()
        {
            try
            {
                listaCategorias = new List<Categoria>();
                acceso = new AccesoDatos();

                acceso.SetearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                acceso.EjecutarLectura();

                while (acceso.Lector.Read())
                {
                    Categoria cate = new Categoria();
                    cate.Id = (int) acceso.Lector["Id"];
                    cate.Descripcion = (string) acceso.Lector["Descripcion"];

                    listaCategorias.Add(cate);
                }


                return listaCategorias;

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

        public List <string> listarNombres()
        {
            acceso = new AccesoDatos();
            List<string> listaDeCategorias = new List<string>();
            string nombre;
            try
            {
                acceso.SetearConsulta("SELECT Descripcion FROM CATEGORIAS;");
                acceso.EjecutarLectura();
                while (acceso.Lector.Read())
                {
                    nombre = (string) acceso.Lector["Descripcion"];
                    listaDeCategorias.Add(nombre);
                }
                return listaDeCategorias;
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
    }
}
