using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        BE.USUARIO usuario;
        BLL.USUARIO gestor;
        BE.JUGADOR jugadorSeleccionado;
        BLL.JUGADOR gestorJugadorSeleccionado = new BLL.JUGADOR();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(BE.USUARIO usuario, BLL.USUARIO gestor) : this()
        {
            this.usuario = usuario ?? new BE.USUARIO();
            this.gestor = gestor ?? new BLL.USUARIO();
            Enlazar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void Enlazar()
        {
            gestor.ListarJugadores(usuario);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuario.Jugadores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestor.InsertarJugador(usuario);
            Enlazar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int estadoPartida = rnd.Next(0, 3);
            switch (estadoPartida)
            {
                case 0:
                    MessageBox.Show("Ganaste!");
                    jugadorSeleccionado.TotalPartidasGanadas++;
                    gestorJugadorSeleccionado.Editar(jugadorSeleccionado);
                    break;
                case 1:
                    MessageBox.Show("Perdiste!");
                    jugadorSeleccionado.TotalPartidasPerdidas++;
                    gestorJugadorSeleccionado.Editar(jugadorSeleccionado);
                    break;
                case 2:
                    MessageBox.Show("Empataste!");
                    jugadorSeleccionado.TotalPartidasEmpatadas++;
                    gestorJugadorSeleccionado.Editar(jugadorSeleccionado);
                    break;
                default:
                    break;
            }
            Enlazar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gestorJugadorSeleccionado.Borrar(jugadorSeleccionado);
            Enlazar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            jugadorSeleccionado = (BE.JUGADOR)dataGridView1.CurrentRow.DataBoundItem;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            /*
            FrmJuego frm = new FrmJuego();
            frm.ShowDialog();
            */
            this.Hide();
            using (FrmJuego frm = new FrmJuego())
            {
                frm.ShowDialog();
            }
            this.Show();
        }
    }
}
