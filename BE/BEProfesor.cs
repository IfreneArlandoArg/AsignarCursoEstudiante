using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class BEProfesor : Usuario
    {
        public int IdProfesor { get; set; }

        public BEProfesor(string pIdProfesor,string pNombre, string pApellido, string pEmail, string pPassword) 
        { 
            IdProfesor = int.Parse(pIdProfesor);
        }
    }
}