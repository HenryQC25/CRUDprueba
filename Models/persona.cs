using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDprueba.Models
{
    public class persona
    {
        public int cui { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set;}
        public string mail { get; set; }
        public string telefono { get; set; }
        public int estado { get; set; }
        public DateTime fechaRegistro { get; set; }


        ////////////////////////////////////////
        string cadena = ConfigurationManager.ConnectionStrings["CNBD"].ConnectionString;
        public List<persona> obtenerPersonas()
        {
            List<persona> ltsPersonas = new List<persona>();
            try
            {
                using (SqlConnection cn= new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_consultarPersonas", cn);
                    SqlDataReader rd;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cn.Open();
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        persona p = new persona();
                        p.cui = rd.GetInt32(0);
                        p.nombre = rd.GetString(1);
                        p.apellido = rd.GetString(2);
                        p.mail = rd.GetString(3);
                        p.telefono = rd.GetString(4); 
                        p.estado = rd.GetInt32(5);
                        p.fechaRegistro = rd.GetDateTime(6);

                        ltsPersonas.Add(p);

                    }
                }

            return ltsPersonas;
            }catch (Exception ex)
            {
                throw;
            }

         
        }


        public int insertarPersona(persona p)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_insertarPersona", cn);
                    cmd.Parameters.AddWithValue("@cui", p.cui);
                    cmd.Parameters.AddWithValue("@nombre", p.nombre);
                    cmd.Parameters.AddWithValue("@apellido", p.apellido);
                    cmd.Parameters.AddWithValue("@mail", p.mail);
                    cmd.Parameters.AddWithValue("@telefono", p.telefono);
                    cmd.Parameters.AddWithValue("@estado", p.estado);
                    cmd.Parameters.AddWithValue("@fechaRegistro", p.fechaRegistro);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                return 1;
            }catch (Exception ex)
            {
                return 0;
            }

        }

        public persona obtenerPersona(int cui)
        {
            persona p=new persona();
            try
            {
                using (SqlConnection cn = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_consultarPersona", cn);
                    cmd.Parameters.AddWithValue("@cui", cui);
                    SqlDataReader rd;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cn.Open();
                    rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                   
                        p.cui = rd.GetInt32(0);
                        p.nombre = rd.GetString(1);
                        p.apellido = rd.GetString(2);
                        p.mail = rd.GetString(3);
                        p.telefono = rd.GetString(4);
                        p.estado = rd.GetInt32(5);
                        p.fechaRegistro = rd.GetDateTime(6);

                        

                    }
                }

                return p ;

            }catch (Exception ex)
            {
                throw;
            }
        }





        ////////////////////////////////////

    }
}