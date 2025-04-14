using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using BE;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALProfesor : IABML<BEProfesor>
    {
        string connectionString = "Integrated Security = SSPI; Data Source =.; Initial Catalog = DB_11_04_Pract;";
        public void Alta(BEProfesor pT)
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                SqlCommand cmd = new SqlCommand("ALTA_PROFESOR", conn);

                cmd.Parameters.AddWithValue("@Nombre", pT.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", pT.Apellido);
                cmd.Parameters.AddWithValue("@Email", pT.Email);
                cmd.Parameters.AddWithValue("@Password", pT.Password);

                conn.Open();

                cmd.ExecuteNonQuery();

            }
        }

        public void AltaCurso(BEProfesor pT, BECurso pC)
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                SqlCommand cmd = new SqlCommand("ALTA_PROFESOR_CURSO",conn);

                cmd.Parameters.AddWithValue("@IdProfesor", pT.IdProfesor);
                cmd.Parameters.AddWithValue("@IdCurso", pC.IdCurso);

                conn.Open();

                cmd.ExecuteNonQuery();


            }
        }

        public void Baja(BEProfesor pT)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("BAJA_PROFESOR", conn);

                cmd.Parameters.AddWithValue("@IdProfesor", pT.IdProfesor);
                
                conn.Open();

                cmd.ExecuteNonQuery();

            }
        }

        public List<BEProfesor> Listar()
        {
            List<BEProfesor> lstTemp = new List<BEProfesor>();

            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                SqlCommand cmd = new SqlCommand("LISTAR_PROFESORES", conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstTemp.Add(new BEProfesor( 
                        reader["IDPROFESOR"].ToString(), 
                        reader["NOMBRE"].ToString(), 
                        reader["APELLIDO"].ToString(), 
                        reader["EMAIL"].ToString(), 
                        reader["PASSWORD"].ToString() ));
                }

            }



                return lstTemp;

        }

        public List<BECurso> ListarCursos(BEProfesor pT)
        {
            throw new NotImplementedException();
        }


        public void Modificar(BEProfesor pT)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("MODIFICAR_PROFESOR", conn);

                cmd.Parameters.AddWithValue("@IdProfesor", pT.IdProfesor);

                cmd.Parameters.AddWithValue("@Nombre", pT.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", pT.Apellido);
                cmd.Parameters.AddWithValue("@Email", pT.Email);
                cmd.Parameters.AddWithValue("@Password", pT.Password);

                conn.Open();

                cmd.ExecuteNonQuery();

            }
        }
    }
}