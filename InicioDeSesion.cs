using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
namespace Registro
{
    public partial class InicioDeSesion : Form
    {
        private DateTime horaInicioSesion;
        private string rutaArchivo;
        private string directorioCuentas = @"C:\Users\Gameon\Documents\Registro\bin\Debug\";

        public InicioDeSesion()
        {
            InitializeComponent();
            // Crear el directorio si no existe
            if (!Directory.Exists(directorioCuentas))
            {
                Directory.CreateDirectory(directorioCuentas);
            }
        }

        private void BTIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TBNombre.Text;
            string password = TBPass.Text;
            rutaArchivo = Path.Combine(directorioCuentas, nombreUsuario + ".txt");

            try
            {
                using (TextReader inicio = new StreamReader(rutaArchivo))
                {
                    if (inicio.ReadLine() == password)
                    {
                        // Registrar la hora de salida de la sesión anterior, si existe
                        using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                        {
                            sw.WriteLine($"Su salida fue a las {DateTime.Now:HH:mm:ss tt}");
                        }

                        // Registrar la nueva hora de inicio de sesión
                        horaInicioSesion = DateTime.Now;
                        using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                        {
                            sw.WriteLine($"Has iniciado sesión a las {horaInicioSesion:HH:mm:ss tt}");
                        }

                        MessageBox.Show("Se inició sesión");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo iniciar sesión");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message, "Error");
            }
        }

        private void BTCerrarSesion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rutaArchivo))
            {
                DateTime horaSalida = DateTime.Now;

                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    sw.WriteLine($"Has cerrado sesión a las {horaSalida:HH:mm:ss tt}");
                }

                MessageBox.Show("Has cerrado sesión");
            }
            else
            {
                MessageBox.Show("No hay ninguna sesión iniciada.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio VentanaInicio = new FRMInicio();
            VentanaInicio.Show();
        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBNombre.Clear();
            TBPass.Clear();
        }
    }
}