using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videojuego
{
    public partial class Form1 : Form
    {
        //Sprite sprite = new Sprite();
        int x = 3, y = 3;
        int xv = 525, yv = 265;
        Image imagen;
        Image villano;
        public Random m = new Random();
        int mMax = 10;
        int tMax = 6;
        int mNum, tNum;
        public Random t = new Random();
        public Timer t1;
        public int tiempo;


        public Form1()
        {
            InitializeComponent();
            CenterToScreen();

            imagen = Image.FromFile(@"..\..\Resources\panther.png");
            villano = Image.FromFile(@"..\..\Resources\killmonger1.png");


            //*60Hz
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            t1 = new Timer();
            t1.Interval = 200;
            t1.Tick += t1_Tick;
            t1.Start();

            /*timer1Tick += new EventHandler(timer1_Tick);*/
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < tMax; i++)
            {
                tNum = t.Next(1, tMax);             
            }
            for (int i = 0; i < mMax; i++)
            {
                mNum = m.Next(1, mMax);
            }
            
                if (mNum == 1 && yv > 100)
                {
                    for (int i = 0; i < tNum * 1000; i += 1000)
                    {
                        yv -= 3 + 2*tNum;
                    Point nuevov = new Point(xv, yv);
                    }
                }

                if (mNum == 2 && xv > 20)
                {
                    for (int i = 0; i < tNum * 1000; i += 1000)
                    {
                        xv -= 3 + 2*tNum;
                        Point nuevov = new Point(xv, yv);

                    }
                }

                if (mNum == 3 && yv < 500)
                {
                    for (int i = 0; i < tNum * 1000; i+= 1000)
                    {
                        yv += 3 + 2 * tNum;
                    Point nuevov = new Point(xv, yv);
    
                    }

                }

                if (mNum == 4 && xv < 1020)
                {
                    for (int i = 0; i < tNum * 1000; i+= 1000)
                    {
                        xv += 3 + 2*tNum;
                        Point nuevov = new Point(xv, yv);
                    }
                }

            Refresh(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            if (e.KeyChar == 'w' && y > 3 || e.KeyChar == 'W' && y > 3)
            {
                y -= 10;
            }

            if (e.KeyChar == 'a' && x > 3 || e.KeyChar == 'A' && x > 3)
            {
                x -= 10;
            }

            if (e.KeyChar == 's' && y < 530 || e.KeyChar == 'S' && y < 530)
            {
                y += 10;
            }

            if (e.KeyChar == 'd' && x < 1050 || e.KeyChar == 'D' && x < 1050)
            {
                x += 10;
            }

            Point nuevo = new Point(x, y);

            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(imagen, x, y, 73, 110);
            g.DrawImage(villano, xv, yv, 73, 102);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        public void Villano()
        {
            

                  

        }

    }
}
