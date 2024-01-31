using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirsoftMAUI.MVVM.Models.Responses
{
    public class LoginResponse
    {
        public Usuario Usuario { get; set; }
        public string Token { get; set; } = string.Empty;
    }
}
