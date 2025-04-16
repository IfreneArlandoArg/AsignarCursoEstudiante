using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;


namespace BLL
{
    public class BLLCurso : IABML<BECurso>
    {
        DALCurso dalCurso = new DALCurso();
        public void Alta(BECurso pT)
        {
            throw new NotImplementedException();
        }

        public void Baja(BECurso pT)
        {
            dalCurso.Baja(pT);
        }

        public List<BECurso> Listar()
        {
            return dalCurso.Listar();
        }

        public void Modificar(BECurso pT)
        {
            throw new NotImplementedException();
        }
    }
}