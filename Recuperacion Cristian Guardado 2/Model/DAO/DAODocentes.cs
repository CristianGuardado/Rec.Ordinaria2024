using Refuerzo2024.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuerzo2024.Model.DAO
{
    internal class DAODocentes : DTODocentes
    {
         SqlConnection con  = obtenerConexion();


        public DataSet ObtenerAsignatura()
        {
            try
            {
                string query = "SELECT * FROM Docentes";  
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Docentes");
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                return null;
            }
            finally
            {
                con.Close();  
            }
        }

        public bool RegistrarDocente()
        {
            try
            {
                string query = "INSERT INTO Docentes (idDocente,nombreDocente, apellidoDocente, dui) VALUES (@idDocente,@nombreDocente, @apellidoDocente, @dui)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idDocente", IdDocente);
                cmd.Parameters.AddWithValue("@nombreDocente", NombreDocente);
                cmd.Parameters.AddWithValue("@apellidoDocente", ApellidoDocente);
                cmd.Parameters.AddWithValue("@dui", Dui);

                con.Open();  
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
                return false;
            }
            finally
            {
                con.Close(); 
            }
        }

        public bool ActualizarDocente()
        {
            try
            {
                string query = "UPDATE Docentes SET nombreDocente = @nombre, apellidoDocente = @apellido, dui = @dui WHERE idDocente = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", IdDocente);
                cmd.Parameters.AddWithValue("@nombre", NombreDocente);
                cmd.Parameters.AddWithValue("@apellido", ApellidoDocente);
                cmd.Parameters.AddWithValue("@dui", Dui);

                con.Open();  
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
                return false;
            }
            finally
            {
                con.Close();  
            }
        }

       
        public bool EliminarDocente()
        {
            try
            {
                string query = "DELETE FROM Docentes WHERE idDocente = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", IdDocente);

                con.Open(); 
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
                return false;
            }
            finally
            {
                con.Close();  
            }
        }

        public DataSet BuscarDocentes(string valor)
        {
            try
            {
                string query = "SELECT * FROM Docentes WHERE nombreDocente LIKE @valor OR idDocente LIKE @valor OR dui LIKE @valor";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Docentes");
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
                return null;
            }
            finally
            {
                con.Close(); 
            }
        }
    }
}
