using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirsoftMAUI.MVVM.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public List<ImagenProducto> Imagenes { get; set; } = new List<ImagenProducto>();
        public Categoria Categoria { get; set; }


    }
}
