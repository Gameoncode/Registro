using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class FRMInicio : Form
    {

        private Timer ti;
        public FRMInicio()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            lbgrelog.Text = hoy.ToString("hh:mm:ss tt");
        }


        private void BTRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario VentanaRegistro = new RegistroUsuario();
            VentanaRegistro.Show();
        }

        /*private void BTInicioSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioDeSesion VentanaSesion = new InicioDeSesion();
            VentanaSesion.Show();
        }
        */

        private void FRMInicio_Load(object sender, EventArgs e)
        {

        }

        private void lblRelog_Click(object sender, EventArgs e)
        {

        }

        private void FRMInicio_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario VentanaInicio = new RegistroUsuario();
            VentanaInicio.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
