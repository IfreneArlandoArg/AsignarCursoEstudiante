using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;

namespace BLL
{
    public class BLLProfesor : IABML<BEProfesor>
    {
        DALProfesor dALProfesor = new DALProfesor();
        
        public void Alta(BEProfesor pT)
        {
            dALProfesor.Alta(pT);
        }

        public void AltaCurso(BEProfesor pT, BECurso pC)
        {
            dALProfesor.AltaCurso(pT, pC); 
        }

        public void Baja(BEProfesor pT)
        {
            dALProfesor.Baja(pT);
        }

        public List<BEProfesor> Listar()
        {
           return dALProfesor.Listar();
        }

        
        public List<BECurso> ListarCursos(BEProfesor pT)
        {
            return lis
        }

        public void Modificar(BEProfesor pT)
        {
            throw new NotImplementedException();
        }
    }
}