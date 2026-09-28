using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using System;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
      

        private readonly FlujoPermisosService _flujoService;
        private int _contadorSolicitudes = 1;

        public Form1()
        {
            InitializeComponent();
            _flujoService = new FlujoPermisosService();
        }

        private void ActualizarBitacoraUI()
        {
            lstBitacora.Items.Clear();
            foreach (var log in Logger.Instancia.ObtenerHistorial())
            {
                lstBitacora.Items.Add(log);
            }
        }

        private void LimpiarFormulario()
        {
            txtEmpleado.Clear();
            txtMotivo.Clear();
            numDias.Value = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarBitacoraUI();

        }

        private void btnSolicitarpermiso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpleado.Text) || string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Logger.Instancia.Registrar(NivelLog.WARNING, "Intento de registro de solicitud con campos vacíos.");
                ActualizarBitacoraUI();
                return;
            }

            // Crear modelo de la solicitud
            var solicitud = new SolicitudPermiso(
                _contadorSolicitudes++,
                txtEmpleado.Text.Trim(),
                (int)numDias.Value,
                txtMotivo.Text.Trim()
            );

            // Procesar la solicitud en la Capa de Negocio
            _flujoService.ProcesarPermiso(solicitud);

            // Mostrar resultado en pantalla
            MessageBox.Show(
                $"Estado final: {solicitud.Estado}\nDetalle: {solicitud.ComentarioAprobacion}",
                "Resultado de Solicitud",
                MessageBoxButtons.OK,
                solicitud.Estado == EstadoSolicitud.Aprobado ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            ActualizarBitacoraUI();
            LimpiarFormulario();
        }

      
    }
    
}
