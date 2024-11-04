using Refuerzo2024.View.Docentes;
using Refuerzo2024.View.Estudiantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refuerzo2024.Controller.Docentes
{
    internal class ControllerDocente
    {
        ViewDocentes objDocentes;

        public ControllerDocente(ViewDocentes objDocentes)
        {
            this.objDocentes = objDocentes;
            //Manejar eventos que surjan en la vista
            objDocentes.btnagregar.Click += new EventHandler(RegistrarDocente);
            objDocentes.btnActualizarDocente.Click += new EventHandler(ActualizarDocente);
            objDocentes.btneliminarDocente.Click += new EventHandler(EliminarDocentes);
            objDocentes.btnBuscarDocente.Click += new EventHandler(BuscarDocente);
        }

    }
}
