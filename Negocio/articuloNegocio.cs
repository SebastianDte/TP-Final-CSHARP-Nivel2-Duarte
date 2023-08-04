using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class articuloNegocio
    {
        AccesoDatos datos = new AccesoDatos();
        public List<Articulo> lista()
        {
            List<Articulo> lista = new List<Articulo>();
            


            try
            {

                datos.setearConsulta("select a.Id as articuloId, Codigo, Nombre, a.Descripcion as articuloDescripcion, imagenUrl, Precio, m.Descripcion as marcaDescripcion, c.Descripcion as categoriaDescripcion,a.IdMarca,a.IdCategoria From ARTICULOS a, MARCAS m, CATEGORIAS c where a.IdMarca = m.id and a.IdCategoria = c.id");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.id = (int)datos.Lector["articuloId"];
                    auxiliar.codigo = (string)datos.Lector["Codigo"];
                    auxiliar.nombre = (string)datos.Lector["Nombre"];
                    auxiliar.descripcion = (string)datos.Lector["articuloDescripcion"];
                    auxiliar.precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["imagenUrl"] is DBNull))
                        auxiliar.urlImagen = (string)datos.Lector["imagenUrl"];
                    auxiliar.marca = new Marca();
                    auxiliar.marca.descripcion = (string)datos.Lector["marcaDescripcion"];
                    auxiliar.marca.id = (int)datos.Lector["IdMarca"];
                    auxiliar.categoria = new Categoria();
                    auxiliar.categoria.descripcion = (string)datos.Lector["categoriaDescripcion"];
                    auxiliar.categoria.id = (int)datos.Lector["IdCategoria"];
                    lista.Add(auxiliar);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, ImagenUrl, Precio,IdMarca,IdCategoria) values('" + nuevo.codigo + "', '"+nuevo.nombre+"', '"+nuevo.descripcion+"', '"+nuevo.urlImagen+"', "+ nuevo.precio+",@IdMarca,@IdCategoria)");
                datos.setearParametro("@IdMarca", nuevo.marca.id);
                datos.setearParametro("@IdCategoria", nuevo.categoria.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void modificar(Articulo modificar)
        {
            
            try
            {
                datos.setearConsulta("update Articulos set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, ImagenUrl = @urlImagen,Precio = @precio,IdMarca = @idMarca, IdCategoria = @idCategoria where Id = @id; ");
                datos.setearParametro("@codigo", modificar.codigo);
                datos.setearParametro("@nombre", modificar.nombre);
                datos.setearParametro("@descripcion", modificar.descripcion);
                datos.setearParametro("@urlImagen", modificar.urlImagen);
                datos.setearParametro("@precio",modificar.precio);
                datos.setearParametro("@idMarca", modificar.marca.id);
                datos.setearParametro("@idCategoria", modificar.categoria.id);
                datos.setearParametro("@id", modificar.id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }

        public void eliminar(int id)
        {
            datos.setearConsulta("delete from ARTICULOS where id = @id");
            datos.setearParametro("@id", id);
            datos.ejecutarAccion();
            
        }

        public List<Articulo> filtrar(string campo,string criterio,string filtro)
        {
            List<Articulo> lista = new List<Articulo> ();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select a.Id as articuloId, Codigo, Nombre, a.Descripcion as articuloDescripcion, imagenUrl, Precio, m.Descripcion as marcaDescripcion, c.Descripcion as categoriaDescripcion,a.IdMarca,a.IdCategoria From ARTICULOS a, MARCAS m, CATEGORIAS c where a.IdMarca = m.id and a.IdCategoria = c.id and ";
                switch (campo)
                {
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "a.Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "a.Precio < " + filtro;
                                break;
                            default:
                                consulta += "a.Precio = " + filtro;
                                break;
                        }
                        break;
                    case "Marca":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "m.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "m.Descripcion like '%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += "m.Descripcion like '%" + filtro + "%'";
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Categoria":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "c.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "c.Descripcion like '%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += "c.Descripcion like '%" + filtro + "%'";
                                break;
                            default:
                                break;
                        }
                    break;
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.id = (int)datos.Lector["articuloId"];
                    auxiliar.codigo = (string)datos.Lector["Codigo"];
                    auxiliar.nombre = (string)datos.Lector["Nombre"];
                    auxiliar.descripcion = (string)datos.Lector["articuloDescripcion"];
                    auxiliar.precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["imagenUrl"] is DBNull))
                        auxiliar.urlImagen = (string)datos.Lector["imagenUrl"];
                    auxiliar.marca = new Marca();
                    auxiliar.marca.descripcion = (string)datos.Lector["marcaDescripcion"];
                    auxiliar.marca.id = (int)datos.Lector["IdMarca"];
                    auxiliar.categoria = new Categoria();
                    auxiliar.categoria.descripcion = (string)datos.Lector["categoriaDescripcion"];
                    auxiliar.categoria.id = (int)datos.Lector["IdCategoria"];
                    lista.Add(auxiliar);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
                    
                        







        

      
