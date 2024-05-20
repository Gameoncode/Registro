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
    public partial class RegistroUsuario : Form
    {

        private Timer ti;
        public RegistroUsuario()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }


        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            lblRelog.Text = hoy.ToString("hh:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBNombre.Clear();
            TBPass.Clear();
            
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
             
            try
            {
                TextWriter RegistrarUsuario = new StreamWriter(@"C:\Users\Gameon\Documents\Registro\bin\Debug\" + TBNombre.Text + ".txt", true);
                RegistrarUsuario.WriteLine(TBPass.Text);
               RegistrarUsuario.WriteLine(lblRelog.Text);
                
                RegistrarUsuario.Close();
           
                MessageBox.Show("Te has registrado " + TBNombre.Text);


            }

            catch (Exception x) 
            {
                MessageBox.Show("Hubo un error" + x, "Error");
                //Introducir Parametros Correctos
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio VentanaInicio = new FRMInicio();
            VentanaInicio.Show();
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            //FDGUFDHUIFRHUIFD


            if (System.Text.RegularExpressions.Regex.IsMatch(TBPass.Text, "^ [0-9]")) {
                TBPass.Text = "";
            }
            
        }

        private void TBPass_TextChanged(object sender, EventArgs e)
        {
            TBPass.PasswordChar = '⬤';
            
        }

        private void lblRelog_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextWriter RegistrarSalida = new StreamWriter(@"C:\Users\Gameon\Documents\Registro\bin\Release\" + TBNombre.Text + ".txt", true);
            RegistrarSalida.WriteLine(TBPass.Text);
            RegistrarSalida.WriteLine(lblRelog.Text);

            RegistrarSalida.Close();

            
            MessageBox.Show("Haz salido " + TBNombre.Text);
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

