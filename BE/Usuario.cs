using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Usuario
    {
        
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Activo { get; set; }

        public int Id { get; set; }
    }
}