using Refuerzo2024.Model.DTO;
using Refuerzo2024.Model.DAO;
using Refuerzo2024.View.Docentes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Refuerzo2024.Controller.Docentes
{
    internal class ControllerDocentes
    {
        private ViewDocentes objDocentes;
        private ControllerDocentes controllerDocentes;  

        public ControllerDocentes(ViewDocentes objDocentes)
        {
            this.objDocentes = objDocentes;
            this.controllerDocentes = new ControllerDocentes(objDocentes); 


           
            objDocentes.btnAgregarDocente.Click += new EventHandler(RegistrarDocente);
            objDocentes.btnActualizarDocente.Click += new EventHandler(ActualizarDocente);
            objDocentes.btnEliminarDocente.Click += new EventHandler(EliminarDocente);
         
        }

      
        private void RegistrarDocente(object sender, EventArgs e)
        {
            try
            {
               
                DTODocentes docente = new DTODocentes
                {
                    NombreDocente = objDocentes.txtNombreDocente.Text,
                    ApellidoDocente = objDocentes.txtApellidoDocente.Text,
                    Dui = objDocentes.txtDuiDocente.Text
                };

               
                bool resultado = controllerDocentes.RegistrarDocente(docente);
                if (resultado)
                {
                    MessageBox.Show("Docente registrado exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al registrar el docente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool RegistrarDocente(DTODocentes docente)
        {
            throw new NotImplementedException();
        }

        private void ActualizarDocente(object sender, EventArgs e)
        {
            try
            {
               
                DTODocentes docente = new DTODocentes
                {
                    IdDocente = int.Parse(objDocentes.txtIdDocente.Text), 
                    NombreDocente = objDocentes.txtNombreDocente.Text,
                    ApellidoDocente = objDocentes.txtApellidoDocente.Text,
                    Dui = objDocentes.txtDuiDocente.Text
                };

               
                bool resultado = controllerDocentes.ActualizarDocente(docente);
                if (resultado)
                {

                    MessageBox.Show("Docente actualizado exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar el docente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool ActualizarDocente(DTODocentes docente)
        {
            throw new NotImplementedException();
        }

        
        private void EliminarDocente(object sender, EventArgs e)
        {
            try
            {
                int idDocente = int.Parse(objDocentes.txtIdDocente.Text);  

                bool resultado = ControllerDocentes.EliminarDocente(idDocente);
                if (resultado)
                {
                    MessageBox.Show("Docente eliminado exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el docente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private static bool EliminarDocente(int idDocente)
        {
            throw new NotImplementedException();
        }

        // Método para buscar un docente
       // private void BuscarDocente(object sender, EventArgs e)
       // {
       //         try
       //     {
       //         string valorBusqueda = objDocentes.txtBuscarDocente.Text;

       //         DataSet resultadoBusqueda = controllerDocentes.BuscarDocente(valorBusqueda);
       //         if (resultadoBusqueda != null && resultadoBusqueda.Tables[0].Rows.Count > 0)
       //         {
       //             // Mostrar los resultados en el DataGridView o algún otro control de UI
       //             objDocentes.dataGridDocentes.DataSource = resultadoBusqueda.Tables[0];
       //         }
       //         else
       //         {
       //             MessageBox.Show("No se encontraron docentes.");
       //         }
       //     }
       //     catch (Exception ex)
       //     {
       //         MessageBox.Show("Error: " + ex.Message);
       //     }
       //} 


        private DataSet BuscarDocente(string valorBusqueda)
        {
            throw new NotImplementedException();
        }

        
        private void LimpiarCampos()
        {
            objDocentes.txtIdDocente.Clear();
            objDocentes.txtNombreDocente.Clear();
            objDocentes.txtApellidoDocente.Clear();
            objDocentes.txtDuiDocente.Clear();
            objDocentes.txtBuscarDocente.Clear();
        }
    }
}
