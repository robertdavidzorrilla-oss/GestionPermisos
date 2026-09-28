using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Logger
    {
        private static Logger _instancia;
        private static readonly object _lock = new object();
        private readonly List<string> _bitacoraMemoria;

        // Constructor privado para evitar instanciación externa
        private Logger()
        {
            _bitacoraMemoria = new List<string>();
        }

        // Propiedad de acceso global a la única instancia
        public static Logger Instancia
        {
            get
            {
                lock (_lock)
                {
                    if (_instancia == null)
                    {
                        _instancia = new Logger();
                    }
                    return _instancia;
                }
            }
        }

        // Método para registrar entradas en la bitácora
        public void Registrar(NivelLog nivel, string mensaje)
        {
            string entrada = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{nivel}] - {mensaje}";
            _bitacoraMemoria.Add(entrada);

        
            try
            {
                File.AppendAllText("bitacora_centralizada.log", entrada + Environment.NewLine);
            }
            catch { }
        }

        public List<string> ObtenerHistorial()
        {
            return new List<string>(_bitacoraMemoria);
        }

    }
}
