using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class AprobadorHandler
    {
        protected AprobadorHandler SiguienteAprobador;

        public void EstablecerSiguiente(AprobadorHandler siguiente)
        {
            SiguienteAprobador = siguiente;
        }

        public abstract void ProcesarSolicitud(SolicitudPermiso solicitud);
    }

}

