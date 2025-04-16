using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DALEstudiante : IABML<BEEstudiante>
    {

        string connectionString = "Integrated Security = SSPI; Data Source = .; Initial Catalog = DB_11_04_Pract;";

        public void Alta(BEEstudiante pT)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ALTA_ESTUDIANTE", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@NOMBRE",pT.Nombre));
                cmd.Parameters.Add(new SqlParameter("@APELLIDO", pT.Apellido));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", pT.Email));
                cmd.Parameters.Add(new SqlParameter("@PASSWORD", pT.Password));

                conn.Open();

                cmd.ExecuteNonQuery();
            }
            
        }

        public void AltaCurso(BEEstudiante pT, BECurso pC)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ALTA_ESTUDIANTE_Curso", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IDESTUDIANTE", pT.IdEstudiante));
                cmd.Parameters.Add(new SqlParameter("@IDCURSO", pC.IdCurso));

                conn.Open();

                cmd.ExecuteNonQuery();
            }

        }

        //Baja Lógica...
        public void Baja(BEEstudiante pT)
        {
            throw new NotImplementedException();
        }

        public List<BEEstudiante> Listar()
        {
            List<BEEstudiante> lstTmp = new List<BEEstudiante>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Listar_Estudiantes", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                
                while (reader.Read())
                {
                    lstTmp.Add(new BEEstudiante(reader["IDESTUDIANTE"].ToString(), reader["NOMBRE"].ToString(), reader["APELLIDO"].ToString(), reader["EMAIL"].ToString(), reader["PASSWORD"].ToString(), reader["ACTIVO"].ToString()));
                }

            }

            return lstTmp;
        }

        public List<BECurso> ListarCursos(BEEstudiante pT)
        {
            List<BECurso> lstTmp = new List<BECurso>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Listar_Cursos_Estudiante", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IDESTUDIANTE", pT.IdEstudiante));
                

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstTmp.Add(new BECurso(reader["IDCURSO"].ToString(), reader["TITULO"].ToString(), reader["DESCRIPCION"].ToString(), reader["ACTIVO"].ToString()));
                }

            }

            return lstTmp;
        }

        public void Modificar(BEEstudiante pT)
        {
            throw new NotImplementedException();
        }
    }
}
