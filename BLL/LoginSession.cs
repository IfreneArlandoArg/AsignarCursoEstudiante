using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace BLL
{
    public class LoginSession
    {
        
        public Usuario UsuarioActual { get; private set; }


        private static LoginSession instancia;
        public static LoginSession Instancia
        {
            get 
            {
                if(instancia == null)
                    instancia = new LoginSession();  
                
                return instancia; 
            }
            
        }

        private LoginSession()
        { }

        public void Login(Usuario usuario)
        {
            UsuarioActual = usuario;
        }

        public void Logout()
        {
            UsuarioActual = null;
            instancia = null;
        }

        public bool EstaLogueado()
        {
            return UsuarioActual != null;
        }


    }
}