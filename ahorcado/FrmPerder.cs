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
    public partial class FrmPerder : Form
    {
        private string palabra;

        public FrmPerder(string Palabra)
        {
            InitializeComponent();
            this.palabra = Palabra;
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            //oculta el formulario
            this.Hide();

            //llama un nuevo form principal
            FrmAhorcado mifrm = new FrmAhorcado();
            mifrm.ShowDialog();

            //al volver a tener el este se cierra
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //salir del juego
            Application.Exit();
        }

        private void FrmPerder_Load(object sender, EventArgs e)
        {

            pintaTexto();
            
        }

        //método para pintar el label de la palabra siempre centrado en horizontal
        private void pintaTexto ()
        {
            int puntoMedio;

            //calculo el area del formulario y calculo su punto medio
            Rectangle miArea = this.ClientRectangle;
            puntoMedio = miArea.Width / 2;

            //meto la palabra en el label
            labPalabra.Text = palabra;

            //dibujo la etiqueta centrada
            labPalabra.Location = new Point(puntoMedio - labPalabra.Width / 2, labPalabra.Location.Y);
        }
    }
}
