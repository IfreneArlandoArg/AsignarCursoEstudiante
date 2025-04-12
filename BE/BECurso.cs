using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class BECurso
    {
        public int IdCurso { get; set; }
        public string Titulo { get; set; }
        public string Descripción  { get; set; }

        public BECurso(string pID, string pTitulo, string pDescripción) 
        { 
            IdCurso = int.Parse(pID);
            Titulo = pTitulo;
            Descripción = pDescripción;
        
        }
    }
}