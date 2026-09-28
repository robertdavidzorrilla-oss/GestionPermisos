using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public enum EstadoSolicitud
    {
        Pendiente,
        Aprobado,
        Rechazado
    }

    public enum NivelLog
    {
        INFO,
        WARNING,
        ERROR
    }

    public class SolicitudPermiso
    {
        public int Id { get; set; }
        public string Empleado { get; set; }
        public int CantidadDias { get; set; }
        public string Motivo { get; set; }
        public EstadoSolicitud Estado { get; set; }
        public string ComentarioAprobacion { get; set; }

        public SolicitudPermiso(int id, string empleado, int cantidadDias, string motivo)
        {
            Id = id;
            Empleado = empleado;
            CantidadDias = cantidadDias;
            Motivo = motivo;
            Estado = EstadoSolicitud.Pendiente;
        }
    }
}
