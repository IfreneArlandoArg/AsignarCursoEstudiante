using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLLEstudiante : IABML<BEEstudiante>
    {
        DALEstudiante dalEstudiante =  new DALEstudiante();
        public BEEstudiante EstudianteLogeado { get; set; }


        public void Alta(BEEstudiante pT)
        {
            dalEstudiante.Alta(pT);
        }

        public void AltaCurso(BEEstudiante pT, BECurso pC) 
        { 
           dalEstudiante.AltaCurso(pT, pC);
        }
        public void Baja(BEEstudiante pT)
        {
            throw new NotImplementedException();
        }

        public List<BEEstudiante> Listar()
        {
            return dalEstudiante.Listar();
        }

        public List<BECurso> ListarCursos(BEEstudiante pT)
        {
            return dalEstudiante.ListarCursos(pT);
        }

        public void Modificar(BEEstudiante pT)
        {
            throw new NotImplementedException();
        }

        public bool Registrado(string pEmail, string pPassword)
        {
            bool registrado = false;

            foreach(BEEstudiante itemEstudiante in dalEstudiante.Listar()) 
            {
                if (itemEstudiante.Email == pEmail && itemEstudiante.Password == pPassword)
                { 
                    registrado = true; 
                    EstudianteLogeado = itemEstudiante;
                }
            }

            return registrado;
        }





    }
}
