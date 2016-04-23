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
    public partial class FrmWin : Form
    {
       

        public FrmWin()
        {
            InitializeComponent();
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAhorcado mifrm1 = new FrmAhorcado();
            mifrm1.ShowDialog();
            this.Close();
        }
    }
}
