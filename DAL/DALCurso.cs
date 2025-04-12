using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCurso : IABML<BECurso>
    {
        string connectionString = "Integrated Security = SSPI; Data Source = .; Initial Catalog = DB_11_04_Pract;";
        public void Alta(BECurso pT)
        {
            throw new NotImplementedException();
        }

        public void Baja(BECurso pT)
        {
            throw new NotImplementedException();
        }

        public List<BECurso> Listar()
        {
            List<BECurso> lstTmp = new List<BECurso>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Listar_Cursos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    lstTmp.Add(new BECurso(reader["IDCURSO"].ToString(), reader["TITULO"].ToString(), reader["DESCRIPCION"].ToString()));
                }

            }

            return lstTmp;
        }

        public void Modificar(BECurso pT)
        {
            throw new NotImplementedException();
        }
    }
}