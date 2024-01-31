using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace AirsoftMAUI.MVVM.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Puntos { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public List<Compra> Compras { get; set; } = new();

    }
}
