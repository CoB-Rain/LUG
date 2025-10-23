using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Form1 : Form
    {
        BLL.Juego juego;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            juego = new BLL.Juego();
            juego.EnviarFicha += Juego_EnviarFicha;
            juego.Acierto += Juego_Acierto;
            juego.Error += Juego_Error;
            juego.Ganar += Juego_Ganar;
            juego.IniciarJuego(100, 4);
        }

        private void Juego_Ganar()
        {
            MessageBox.Show("GANASTE");
        }

        private void Juego_Error()
        {
            
            timer1.Start();

        }

        private void Juego_Acierto()
        {

        }

        private void Juego_EnviarFicha(BE.FICHA unaFicha)
        {
            MiPictureBox pic = new MiPictureBox();
            pic.Location = new Point(unaFicha.Posicion.X,unaFicha.Posicion.Y);
            pic.Size = new Size(100, 100);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Ficha = unaFicha;
            pic.Ocultar();            
            pic.Click += Pic_Click;
            this.Controls.Add(pic); 
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            var pic = sender as MiPictureBox;
            juego.DescubrirFicha(pic.Ficha);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is MiPictureBox)
                {
                    ((MiPictureBox)control).Ocultar();
                }

            }
            timer1.Stop();
            BLL.Juego.PERMITEJUGAR = true;
        }
    }
}
