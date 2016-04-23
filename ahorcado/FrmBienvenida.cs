using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ahorcado
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {

            FrmAhorcado miform = new FrmAhorcado();

            this.Hide();
            miform.ShowDialog();

            //cuando retome el contro se cierra
            this.Close();
            
        }

        //al pinchar la imagen de facebook te lleva a la pagina
        private void pcbFace_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }
        //al pinchar la imagen de twitter te lleva a la pagina
        private void pcbTuit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com");
        }
        //al pinchar la imagen de google+ te lleva a la pagina
        private void pcbGo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://plus.google.com/");
            
        }
    }
}
