﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class BEProfesor : Usuario
    {
        public int IdProfesor { get; set; }

        public BEProfesor(string pIdProfesor,string pNombre, string pApellido, string pEmail, string pPassword, string pActivo) 
        { 
            IdProfesor = int.Parse(pIdProfesor);
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Password = pPassword;
            Activo = bool.Parse(pActivo);
        }

        public BEProfesor( string pNombre, string pApellido, string pEmail, string pPassword)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Password = pPassword;
            
        }
    }
}