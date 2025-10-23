using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    internal class MiPictureBox:PictureBox
    {
		private BE.FICHA ficha;

		public BE.FICHA Ficha
		{
			get { return ficha; }
			set { ficha = value; }
		}

        public void Ocultar()
        {
            if(ficha.estado == BE.Estado.Oculto) { 
                this.ImageLocation = "Img\\CARTA.jpg";
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (BLL.Juego.PERMITEJUGAR)
            { 
                if (ficha.estado == BE.Estado.Descubierto)
                {
                    MessageBox.Show("La ficha esta descubierta");
                }
                else
                { 
                    ficha.estado = BE.Estado.Descubierto;
                    this.ImageLocation = "Img\\" + ficha.Imagen;
                }
                base.OnClick(e);
            }
        }
    }
}
