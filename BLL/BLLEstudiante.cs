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
            dalEstudiante.Baja(pT);
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
            foreach (BEEstudiante estudiante in dalEstudiante.Listar())
            {
                if (estudiante.Email == pEmail && estudiante.Password == pPassword)
                {
                    LoginSession.Instancia.Login(estudiante); 
                    return true;
                }
            }
            return false;
        }

        public bool Inscripto(BEEstudiante pT, BECurso pC) 
        { 
           bool inscripto = false;

            foreach (BECurso itemCurso in dalEstudiante.ListarCursos(pT))
            {
                if (itemCurso == pC)
                 inscripto = true;
            }

            return inscripto;

        }



    }
}
