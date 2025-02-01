using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videojuego
{
    public partial class Form2 : Form
    {
        public int vHeroe, vVillano;
        public Form2()
        {
            InitializeComponent();
        }

        private void LeerBt_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("Jugador.txt");
            while (!reader.EndOfStream)
            {
                OutPutTB.AppendText(reader.ReadLine());
                OutPutTB.AppendText(Environment.NewLine);
            }
            reader.Close();
        }

        private void GuardarBt_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("Jugador.txt", true);
            if (vHeroe <= 0)
            {
                writer.WriteLine("El jugador " + TBJugador.Text +
              " ha PERDIDO la partida en contra del villano con una vida de " + vVillano);
            }
            if (vVillano <= 0)  
            {
                writer.WriteLine("El jugador " + TBJugador.Text +
              " ha GANADO la partida en contra del villano con una vida de " + vHeroe);
            }
            writer.Close();    
        }
    }
}
