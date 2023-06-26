using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {

        private decimal precio;
        public int Id { get; set; }


        [DisplayName("Código")]
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set;}

        public Marca Marca { get; set; }


        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }

        public string ImagenUrl { get; set; }

        //Property sin validacion
        /*public decimal Precio
            { get; set; }*/
        


        public decimal Precio {
            get 
            {
                return this.precio;
            
            }

            set
            {
                precio = Math.Round(value, 2);
            }
        
        
        }

        public override string ToString()
        {
            return "ID:" + Id +"   - CODIGO: " + Codigo + "  - NOMBRE:" + Nombre+" - DESCRIPCION:" + Descripcion + " - ID MARCA: " + Marca.Id + "  - MARCA: " + Marca.Descripcion + "  - ID CATEGORIA: " + Categoria.Id +" - CATEGORIA: " + Categoria.Descripcion + " - LINK URL:" + ImagenUrl + "  - PRECIO:" + Precio;
        }
    }
}
