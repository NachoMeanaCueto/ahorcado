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

namespace ahorcado
{
    /* --------------------------------------------------------------------------
     * Juego del ahorcado
     * fecha de codificacion: 8/05/2015
     * Autor: Nacho Meana Cueto
     * 
     ---------------------------------------------------------------------------*/
    public partial class FrmAhorcado : Form
    {
        bool fallo;

        string Palabra;
        StringBuilder cadena;

        int contador;//contador para gestionar los fallos
        int aciertos;//contador para gestionar los aciertos

        public FrmAhorcado()
        {
            InitializeComponent();
        }

        //evento click en cualquier boton
        private void btn_Click(object sender, EventArgs e)
        {
            //variable para comparar la letra con las de la palabra
            char letra;
            fallo = true;

            Button miboton = new Button();
            miboton = (Button)sender;

            //al pinchar en una letra se desactiva.
            miboton.Enabled = false;

            //tomo la letra del tag de cada boton
            letra = Convert.ToChar(miboton.Tag);

            //compruebo si la letra coincide con alguna de las contenidas en la palabra
            for (int i = 0; i < Palabra.Length; i++) 
            {
                if (letra ==  char.ToLower(Palabra[i]))
                {
                    fallo = false;
                    cadena[i] = letra;
                    pintaTexto(cadena);
                    aciertos++;
                }
            }

            //si fallas la letra
            if (fallo)
            {
                contador++;

                //establece la imagen segun el contador
                EstableceImagen();

                    //cuando se pierde el juego
                    if (contador == 8)
                    {
                        
                        this.Hide();
                        FrmPerder mifor = new FrmPerder(Palabra);
                        mifor.ShowDialog();
                        this.Close();
                    }
                
            }

            //cuando se gana el juego
            if (aciertos == Palabra.Length) 
            {
                
                this.Hide();
                FrmWin mifor = new FrmWin();
                mifor.ShowDialog();
                this.Close();
            }
           
        }

  

        private void FrmAhorcado_Load(object sender, EventArgs e)
        {
            //creo un vector leyendo todas las lineas del diccionario
            string[] vector = File.ReadAllLines(@"..\..\..\Imagenes\diccionario.txt");
            int maximo = vector.Length;


            //inicializo los aciertos y los fallos
            aciertos = 0;
            contador = 0;
            int numero;

            Random miNum = new Random();
            numero = miNum.Next(maximo);

            Palabra = eliminaAcentos(vector[numero]);

            cadena = new StringBuilder(Palabra);
            try
            {
                //inicializo la cadena con el numero de guiones que corresponda segun la palabra
                for (int i = 0; i < Palabra.Length; i++)
                {
                    cadena[i] = '-';
                }

                pintaTexto(cadena);
            }
            catch { }
        }

        //método para mostrar las imagenes
        private void EstableceImagen() 
        {
            pbxAhorcado.Image = imageList1.Images[contador - 1];
        }

        /*--------------------------------------------------------------------------------------
          * Método Elimina acentos que recibe una cadena de caracteres acentuados y retorna la misma 
          * la misma cadena pero con los caracteres  sin acentuar.
          * Autor: Nacho Meana Cueto.
          * Fecha de codificacion:13/02/2015
          * fecha de verificacion: 13/02/2015
          * Para los juegos de prueba realizados el método funciona correctamente.
          ---------------------------------------------------------------------------------------*/
        private string eliminaAcentos(string MiCadena)
        {
            string cadenaSinAcentos;
            StringBuilder misb = new StringBuilder(MiCadena);

            misb.Replace('á', 'a');
            misb.Replace('Á', 'A');
            misb.Replace('é', 'e');
            misb.Replace('É', 'e');
            misb.Replace('í', 'i');
            misb.Replace('Í', 'I');
            misb.Replace('Ó', 'O');
            misb.Replace('ó', 'o');
            misb.Replace('ú', 'u');
            misb.Replace('Ú', 'U');

            cadenaSinAcentos = Convert.ToString(misb);

            return cadenaSinAcentos;
        }

        //método para pintar el label de la palabra siempre centrado en horizontal
        private void pintaTexto(StringBuilder palabra)
        {
            int puntoMedio;

            //calculo el area del formulario y calculo su punto medio
            Rectangle miArea = this.ClientRectangle;
            puntoMedio = miArea.Width / 2;

            //meto la palabra en el label
            labPalabra.Text = Convert.ToString(palabra);

            //dibujo la etiqueta centrada
            labPalabra.Location = new Point(puntoMedio - labPalabra.Width / 2, labPalabra.Location.Y);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
