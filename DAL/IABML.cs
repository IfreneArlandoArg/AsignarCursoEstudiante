using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace DAL
{
    public interface IABML<T>
    {
        void Alta(T pT);
        void Baja(T pT);
        void Modificar(T pT);
        List<T> Listar();
    }
}