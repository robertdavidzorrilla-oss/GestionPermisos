using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    // Evaluador de permisos de 1 a 2 días
    public class SupervisorAprobar : AprobadorHandler
    {
        public override void ProcesarSolicitud(SolicitudPermiso solicitud)
        {
            if (solicitud.CantidadDias <= 2)
            {
                solicitud.Estado = EstadoSolicitud.Aprobado;
                solicitud.ComentarioAprobacion = "Aprobado por el Supervisor Inmediato.";

                Logger.Instancia.Registrar(NivelLog.INFO,
                    $"Solicitud #{solicitud.Id} ({solicitud.CantidadDias} días) APROBADA por Supervisor Inmediato.");
            }
            else if (SiguienteAprobador != null)
            {
                Logger.Instancia.Registrar(NivelLog.INFO,
                    $"Solicitud #{solicitud.Id} excede límite de Supervisor. Delegando a Gerente...");
                SiguienteAprobador.ProcesarSolicitud(solicitud);
            }
        }
    }

    // Evaluador de permisos de 3 a 5 días
    public class GerenteAprobador : AprobadorHandler
    {
        public override void ProcesarSolicitud(SolicitudPermiso solicitud)
        {
            if (solicitud.CantidadDias >= 3 && solicitud.CantidadDias <= 5)
            {
                solicitud.Estado = EstadoSolicitud.Aprobado;
                solicitud.ComentarioAprobacion = "Aprobado por el Gerente de Departamento (Previo Visto Bueno de Supervisor).";

                Logger.Instancia.Registrar(NivelLog.INFO,
                    $"Solicitud #{solicitud.Id} ({solicitud.CantidadDias} días) APROBADA por Gerente de Departamento.");
            }
            else if (SiguienteAprobador != null)
            {
                Logger.Instancia.Registrar(NivelLog.INFO,
                    $"Solicitud #{solicitud.Id} excede límite de Gerente. Delegando a Director de RRHH...");
                SiguienteAprobador.ProcesarSolicitud(solicitud);
            }
        }
    }

    // Evaluador de permisos de más de 5 días
    public class DirectorGHAprobador : AprobadorHandler
    {
        public override void ProcesarSolicitud(SolicitudPermiso solicitud)
        {
            if (solicitud.CantidadDias > 5)
            {
                solicitud.Estado = EstadoSolicitud.Aprobado;
                solicitud.ComentarioAprobacion = "Aprobado por el Director de Recursos Humanos (Previo Visto Bueno de Supervisor y Gerente).";

                Logger.Instancia.Registrar(NivelLog.INFO,
                    $"Solicitud #{solicitud.Id} ({solicitud.CantidadDias} días) APROBADA por Director de Recursos Humanos.");
            }
            else
            {
                solicitud.Estado = EstadoSolicitud.Rechazado;
                solicitud.ComentarioAprobacion = "Rechazado por el Director de Recursos Humanos.";

                Logger.Instancia.Registrar(NivelLog.WARNING,
                    $"Solicitud #{solicitud.Id} RECHAZADA por el Director de Recursos Humanos.");
            }
        }
    }
}
