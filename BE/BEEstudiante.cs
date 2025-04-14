using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEEstudiante : Usuario
    {
        public int IdEstudiante { get; set; }
        public BEEstudiante(string pIdEstudiante, string pNombre, string pApellido, string pEmail, string pPassword) 
        { 
            IdEstudiante = int.Parse(pIdEstudiante);
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Password = pPassword;
        
        }

        public BEEstudiante( string pNombre, string pApellido, string pEmail, string pPassword)
        {
            
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Password = pPassword;

        }

    }
}
