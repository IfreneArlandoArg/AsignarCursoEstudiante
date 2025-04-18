using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEEstudiante : Usuario
    {
        
        public BEEstudiante(string pIdEstudiante, string pNombre, string pApellido, string pEmail, string pPassword, string pActivo) 
        { 
            Id = int.Parse(pIdEstudiante);
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Password = pPassword;
            Activo = bool.Parse(pActivo);
        
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
