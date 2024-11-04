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


        public DataSet ObtenerAsignaturas()
        {
            try
            {
                //Se crea la instrucción de lo que se quiere hacer
                string query = "SELECT * FROM Especialidades";
                //Se crea el comando de tipo Sql que recibe la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, con);
                //ExecuteNonQuery se utiliza para acciones como INSERT, UPDATE, DELETE
                //ExecuteScalar se utiliza para acciones como SELECT
                cmd.ExecuteScalar();
                //Toma los valores y los pone en una tabla generica
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea el objeto según el tipo de dato a retornar
                DataSet ds = new DataSet();
                //Se rellena el objeto a retornar con los datos de la tabla generica
                adp.Fill(ds, "Especialidades");
                //Se retorna el objeto
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool RegistrarDocentes()
        {
            try
            {
                string query = "INSERT INTO Estudiantes VALUES (@param1, @param2, @param3, @param4, @param5)";
                SqlCommand cmdInsert = new SqlCommand(query, con);
                cmdInsert.Parameters.AddWithValue("param1", IdDocente);
                cmdInsert.Parameters.AddWithValue("param2", NombreDocente);
                cmdInsert.Parameters.AddWithValue("param3", ApellidoDocente);
                cmdInsert.Parameters.AddWithValue("param4", Dui);
                cmdInsert.Parameters.AddWithValue("param5", IdAsignatura);
                cmdInsert.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet ObtenerDocentes()
        {
            try
            {
                string query = "SELECT * FROM ViewDocentes";
                SqlCommand cmdObtener = new SqlCommand(query, con);
                cmdObtener.ExecuteScalar();
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmdObtener);
                adp.Fill(ds, "ViewEstudiante");
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool ActualizarDocentes()
        {
            try
            {
                //Crea la instrucción de lo que se quiere hacer
                string query = "UPDATE Docentes SET idDocente = IdDocente, nombreDocente = @nombreDocente, apellidoDocente = @apellidoDocente, dui = @dui, idAsignatura = @idAsignatura WHERE idDocente = @idDocente";
                //Crea el comando con la instrucción y la conexión
                SqlCommand cmdUpdate = new SqlCommand(query, con);
                cmdUpdate.Parameters.AddWithValue("idDocente", IdDocente);
                cmdUpdate.Parameters.AddWithValue("nombreDocente", NombreDocente);
                cmdUpdate.Parameters.AddWithValue("apellidoDocente", ApellidoDocente);
                cmdUpdate.Parameters.AddWithValue("dui", Dui);
                cmdUpdate.Parameters.AddWithValue("idAsignatura", IdAsignatura);
                //Ejecuta la instrucciones
                cmdUpdate.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }
        }

        public bool EliminarDocentes()
        {
            try
            {
                string query = "DELETE FROM Docentes WHERE idDocente = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, con);
                cmdDelete.Parameters.AddWithValue("param1", IdDocente);
                cmdDelete.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
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
                string query = "SELECT * FROM ViewDocentes WHERE nombreDocentes LIKE @param1 OR idDocentes LIKE @param2 OR dui LIKE @param3";
                SqlCommand cmdObtener = new SqlCommand(query, con);
                cmdObtener.Parameters.AddWithValue("param1", "%" + valor + "%");
                cmdObtener.Parameters.AddWithValue("param2", "%" + valor + "%");
                cmdObtener.Parameters.AddWithValue("param3", "%" + valor + "%");
                cmdObtener.ExecuteScalar();
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmdObtener);
                adp.Fill(ds, "ViewEstudiante");
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
