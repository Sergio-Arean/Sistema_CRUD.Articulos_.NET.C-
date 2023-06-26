using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        private List<Articulo> listaArticulos;
        private List<Articulo> listaFiltrada;
        private AccesoDatos acceso;


        /// <summary>
        /// Obtiene una coleccion de tipo List en la que se listan los articulos presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Articulo> ListarArticulos()
        {
            //objetivo : traer lista de articulos apd lectura bbdd
            acceso = new AccesoDatos();
            listaArticulos = new List<Articulo>();
            try
            {
                
                acceso.SetearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id as IDMarca, M.Descripcion as Marca, C.Id as IDCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio FROM  ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdMarca=M.Id AND A.IdCategoria=C.Id;");
                acceso.EjecutarLectura();

                while (acceso.Lector.Read())
                {
                    Articulo arti = new Articulo();
                    if (!(acceso.Lector["Id"] is DBNull))
                    {
                        arti.Id = (int)acceso.Lector["Id"];
                    }

                    if (!(acceso.Lector["Codigo"] is DBNull))
                    {
                        arti.Codigo = (string)acceso.Lector["Codigo"];
                    }

                    if (!(acceso.Lector["Nombre"] is DBNull))
                    {
                        arti.Nombre = (string)acceso.Lector["Nombre"];
                    }

                    if (!(acceso.Lector["Descripcion"] is DBNull))
                    {
                        arti.Descripcion = (string)acceso.Lector["Descripcion"];
                    }

                    arti.Marca = new Marca();

                    if (!(acceso.Lector["IdMarca"] is DBNull))
                    {
                        arti.Marca.Id = (int)acceso.Lector["IdMarca"];

                    }

                    if (!(acceso.Lector["Marca"] is DBNull))
                    {
                        arti.Marca.Descripcion = (string)acceso.Lector["Marca"];
                    }

                    arti.Categoria = new Categoria();
                    if (!(acceso.Lector["IdCategoria"] is DBNull))
                    {
                        arti.Categoria.Id = (int)acceso.Lector["IdCategoria"];
                    }

                    if (!(acceso.Lector["Categoria"] is DBNull))
                    {
                        arti.Categoria.Descripcion = (string)acceso.Lector["Categoria"];
                    }

                    if (!(acceso.Lector["ImagenUrl"] is DBNull))
                    {
                        arti.ImagenUrl = (string)acceso.Lector["ImagenUrl"];
                    }

                    if (!(acceso.Lector["Precio"] is DBNull))
                    {
                        arti.Precio = (decimal)acceso.Lector["Precio"];
                    }


                    
                    listaArticulos.Add(arti);
                }
                return listaArticulos;
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

        /// <summary>
        /// Obtiene una lista filtrada por nombre,categoria o marca que se envie por parametro.
        /// </summary>
        /// <returns></returns>
        public List<Articulo> DevuelveListaFiltrada(List <Articulo> lista,string filtro)
        {
            
            try
            {
                //filtro es por : nombre/categoria/marca
                listaFiltrada = lista.FindAll(item => item.Nombre.ToUpper().Contains(filtro.ToUpper()) || item.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || item.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                return listaFiltrada;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Ordena de forma ascendente la lista que se envie por parametro.
        /// </summary>
        /// <returns>La lista ordenada por criterio ascendente</returns>
        public List <Articulo> OrdenarListaAscendente (List<Articulo> lista)
        {

            try
            {
                lista.Sort(criterioAscendente);
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private int criterioAscendente (Articulo x, Articulo y)
        {
            if (x.Precio < y.Precio)
            {
                return -1;
            }
            else if (x.Precio == y.Precio)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        private int criterioDescendente(Articulo x, Articulo y)
        {
            if (x.Precio < y.Precio)
            {
                return 1;
            }
            else if (x.Precio == y.Precio)
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }

        /// <summary>
        /// Ordena de forma descendente la lista que se envie por parametro.
        /// </summary>
        /// <returns>La lista ordenada por criterio descendente</returns>
        public List<Articulo> OrdenarListaDescendente(List<Articulo> lista)
        {

            try
            {
                lista.Sort(criterioDescendente);
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Inserta en la base de datos el articulo enviado por parametro.
        /// </summary>
        /// <param name="arti"></param>
        public void AgregarArticulo(Articulo arti)
        {
            acceso = new AccesoDatos(); //conexion a base de datos
            try
            {
                
                acceso.SetearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@LinkUrl,@Precio);"); //consulta sql de insercion pendiente

                //seteo de parametros
                //@Codigo','@Nombre','@Descripcion',@IdMarca,@IdCategoria,'@LinkUrl',@Precio//
                acceso.SetearParametros("@Codigo",arti.Codigo);
                acceso.SetearParametros("@Nombre",arti.Nombre);
                acceso.SetearParametros("@Descripcion",arti.Descripcion);
                acceso.SetearParametros("@IdMarca",arti.Marca.Id);
                acceso.SetearParametros("@IdCategoria",arti.Categoria.Id);
                acceso.SetearParametros("@LinkUrl",arti.ImagenUrl);
                acceso.SetearParametros("@Precio",arti.Precio);

                acceso.EjecutarAccion();
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

        public void ModificarArticulo(Articulo arti) {
            acceso = new AccesoDatos();

            try
            {
                acceso.SetearConsulta("UPDATE ARTICULOS SET Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, IdMarca=@IdMarca, IdCategoria=@IdCategoria, ImagenUrl=@ImagenUrl, Precio=@Precio WHERE ID=@IdArticulo;"); //string consulta

                //Seteo de Parametros
                //@Codigo  @Nombre  @Descripcion @IdMarca @IdCategoria @ImagenUrl @Precio @IdArticulo
                acceso.SetearParametros("@Codigo",arti.Codigo);
                acceso.SetearParametros("@Nombre",arti.Nombre);
                acceso.SetearParametros("@Descripcion",arti.Descripcion);
                acceso.SetearParametros("@IdMarca",arti.Marca.Id);
                acceso.SetearParametros("@IdCategoria",arti.Categoria.Id);
                acceso.SetearParametros("@ImagenUrl",arti.ImagenUrl);
                acceso.SetearParametros("@Precio",arti.Precio);
                acceso.SetearParametros("@IdArticulo",arti.Id);

                acceso.EjecutarAccion();
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

        public void EliminarArticulo(int idArticulo)
        {
            acceso = new AccesoDatos();
            try
            {
                acceso.SetearConsulta("DELETE FROM ARTICULOS WHERE ID=@IdArticulo;");
                acceso.SetearParametros("@IdArticulo", idArticulo);
                acceso.EjecutarAccion();
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

        public string SetearConsultaAvanzada(string criterio1, string criterio2, string criterio3,bool minimo, bool maximo,string valor_minimo, string valor_maximo)
        {
            string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id as IDMarca, M.Descripcion as Marca, C.Id as IDCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio FROM  ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdMarca=M.Id AND A.IdCategoria=C.Id AND ";
            try
            {
                switch (criterio1)
                {
                    case "Nombre":
                        switch (criterio2)
                        {
                            case "Comienza con": 
                                consulta += "A.Nombre like '" + criterio3 + "%' ";
                                break;

                            case "Termina con": consulta += "A.Nombre like '%" + criterio3 + "' ";
                                break;

                            case "Contiene": consulta += "A.Nombre like '%"+criterio3+"%' ";
                                break;

                            default:
                                break;
                        }
                        break;

                    case "Categoria":
                        consulta += " C.Descripcion = '" + criterio2 + "'"; 
                        if (criterio3 != "Todos")  //si no eligio todos, concateno con la marca, del 3er cb
                        {
                            consulta += " AND M.Descripcion = '" + criterio3 + "'";
                        }
                        break;


                    case "Marca":
                        consulta += " M.Descripcion = '"+criterio2+"' ";
                        if (criterio3 != "Todos")
                        {
                            consulta += " AND C.Descripcion = '"+criterio3+"' ";
                        }
                        break;


                    default:
                        break;
                }
                    if (minimo)
                    {
                        consulta += " AND A.Precio >="+ valor_minimo;
                    }
                    if (maximo)
                    {
                        consulta += " AND A.Precio <="+ valor_maximo+";";
                    }

                return consulta;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List <Articulo> listar_BusquedaAvanzada (string consulta)
        {

            List <Articulo> listaAvanzada = new List <Articulo>();
            acceso = new AccesoDatos();
            try
            {   
                acceso.SetearConsulta(consulta);
                acceso.EjecutarLectura();

                while (acceso.Lector.Read())
                {
                    Articulo arti = new Articulo();
                    arti.Id = (int)acceso.Lector["Id"];
                    arti.Codigo = (string)acceso.Lector["Codigo"];
                    arti.Nombre = (string)acceso.Lector["Nombre"];
                    arti.Descripcion = (string)acceso.Lector["Descripcion"];

                    arti.Marca = new Marca();
                    arti.Marca.Id = (int)acceso.Lector["IdMarca"];
                    arti.Marca.Descripcion = (string)acceso.Lector["Marca"];

                    arti.Categoria = new Categoria();
                    arti.Categoria.Id = (int)acceso.Lector["IdCategoria"];
                    arti.Categoria.Descripcion = (string)acceso.Lector["Categoria"];

                    arti.ImagenUrl = (string)acceso.Lector["ImagenUrl"];
                    arti.Precio = (decimal)acceso.Lector["Precio"];

                    listaAvanzada.Add(arti);
                }

                return listaAvanzada;
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

        /// <summary>
        /// Permite validar que el codigo del nuevo articulo que se esta ingresando no se corresponda con el codigo de un articulo ya presente en la base de datos.
        /// </summary>
        /// <returns></returns>
       public int ValidarArticuloRepetido(string codigo)
        {
            acceso = new AccesoDatos();
            try
            {
                acceso.SetearConsulta("SELECT CASE WHEN EXISTS(SELECT * FROM ARTICULOS WHERE Codigo =@Codigo) THEN 1 ELSE 0 END;");
                acceso.SetearParametros("@Codigo",codigo);
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

        /// <summary>
        /// Valida que el codigo del articulo que se esta modificando no se corresponda con algun codigo ya existente en el listado de articulos.
        /// </summary>
        /// <returns></returns>

        public int ValidarArticuloRepetido(string codigo,Articulo articulo_a_modificar)
        {
            List <Articulo> articulos = ListarArticulos(); //lista original
            List<Articulo> articulos_a_evaluar = new List<Articulo>(); //en esta lista van a estar todos los articulos, excepto el que quiero modificar
            int rta;

            if (codigo.Equals(articulo_a_modificar.Codigo))
            {
                rta = 0;
            }
            else
            {
                rta =  ValidarArticuloRepetido(codigo);
            }

            return rta;
        }

        public void InsertarArticulosIniciales()
        {
            /*Metodo de prueba: inserta los articulos iniciales de la BBDD*/
            acceso = new AccesoDatos();
            try
            {
                acceso.SetearConsulta("insert into ARTICULOS values ('S01', 'Galaxy S10', 'Una canoa cara', 1, 1, 'https://images.samsung.com/is/image/samsung/assets/ar/p6_gro2/p6_initial_mktpd/smartphones/galaxy-s10/specs/galaxy-s10-plus_specs_design_colors_prism_black.jpg?$163_346_PNG$', 69.999),\r\n('M03', 'Moto G Play 7ma Gen', 'Ya siete de estos?', 5, 1, 'https://www.motorola.cl/arquivos/moto-g7-play-img-product.png?v=636862863804700000', 15699),\r\n('S99', 'Play 4', 'Ya no se cuantas versiones hay', 3, 3, 'sin_imagen_para_que_de_error....muejeje', 35000),\r\n('S56', 'Bravia 55', 'Alta tele', 3, 2, 'https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450', 49500),\r\n('A23', 'Apple TV', 'lindo loro', 2, 3, 'https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/rfb-apple-tv-4k?wid=1144&hei=1144&fmt=jpeg&qlt=80&.v=1513897159574', 7850);");
                acceso.EjecutarAccion();
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

        public void EliminarTodosLosArticulos()
        {
            /*Metodo de prueba: elimina todos los articulos. Pensado para la funcionalidad de indicar al usuario como comenzar a operar*/
            acceso = new AccesoDatos();
            try
            {
                acceso.SetearConsulta("DELETE FROM ARTICULOS;");
                acceso.EjecutarAccion();
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
