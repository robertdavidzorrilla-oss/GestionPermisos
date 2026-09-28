using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class FlujoPermisosService
    {
        private readonly AprobadorHandler _cadenaAprobacion;

        public FlujoPermisosService()
        {
            // Configuración de la Cadena de Responsabilidad
            var supervisor = new SupervisorAprobar();
            var gerente = new GerenteAprobador();
            var director = new DirectorGHAprobador();

            supervisor.EstablecerSiguiente(gerente);
            gerente.EstablecerSiguiente(director);

            _cadenaAprobacion = supervisor;
        }

        public void ProcesarPermiso(SolicitudPermiso solicitud)
        {
            Logger.Instancia.Registrar(NivelLog.INFO,
                $"Inicio del flujo de aprobación para la solicitud #{solicitud.Id} del empleado {solicitud.Empleado}.");

            _cadenaAprobacion.ProcesarSolicitud(solicitud);
        }
    }
}
