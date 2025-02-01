using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Videojuego
{

    public partial class Form1 : Form
    {
        //Sprite sprite = new Sprite();
        int x = 3, y = 3;
        int xv = 525, yv = 265;
        Image heroe;
        Image villano;
        Image hong;
        Image smg, scar, pump;
        public Random m = new Random();
        int mMax = 5;
        int tMax = 5;
        int mNum, tNum, Arma;
        public Random t = new Random();
        public Timer t1, t2, armaT, t3, tVida, t4;
        public int tiempo;

        Rectangle rectHeroe, rectVillano;
        Rectangle rectSmg, rectScar, rectPump;
        Rectangle alcanceVillano, alcanceHeroe;
        Rectangle rectHongo;
        Rectangle Vida;

        int xrect, yrect, xvrect, yvrect;

        Random arma = new Random();
        Random armax = new Random();
        Random armay = new Random();
        int ArmaX, ArmaY;

        Random hongox = new Random();
        Random hongoy = new Random();
        int HongoX, HongoY;
        bool pintaHongo = false;

        //int xr = 3, yr = 3;
        //int xvr = 525, yvr = 265;
        int rangex = 73, rangey = 110;
        int rangevx = 73, rangevy = 102;
        int widtharma, heightarma, widtharmaV, heightarmaV;

        public int dañoH = 5;
        public int dañoV = 5;

        public int vidaHeroe = 300;
        public int vidaHMax = 300;
        public int vidaVillano = 500;
        public int vidaVMax = 500;


        bool pintaItem = true;
        bool pintaArma = true;
        bool pintaHeroe = true;

        public bool vida = false;

        private void HeroeTB_TextChanged(object sender, EventArgs e)
        {

        }

        Timer timer1 = new Timer();
        Sprite sprite = new Sprite(@"..\..\Resources\florm.png", 42);
        int xVida, vNum;

        Random v = new Random();
        public bool fin = false;
        Timer tFin;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();

            heroe = Image.FromFile(@"..\..\Resources\panther.png");
            villano = Image.FromFile(@"..\..\Resources\killmonger1.png");

            hong = Image.FromFile(@"..\..\Resources\hongo.png");

            smg = Image.FromFile(@"..\..\Resources\smg.png");
            scar = Image.FromFile(@"..\..\Resources\scar.png");
            pump = Image.FromFile(@"..\..\Resources\shotgun.png");

            //*60Hz
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            rectHeroe = new Rectangle(x, y, rangex, rangey);
            rectVillano = new Rectangle(xv, yv, rangevx, rangevy);



            t1 = new Timer();
            t1.Interval = 1000 + tNum * 1000;
            t1.Tick += t1_Tick;
            t1.Start();

            t2 = new Timer();
            t2.Interval = 30;
            t2.Tick += T2_Tick;
            t2.Start();

            t3 = new Timer();
            t3.Interval = 200;
            t3.Tick += T3_Tick;
            t3.Start();

            armaT = new Timer();
            armaT.Interval = 6000;
            armaT.Tick += ArmaT_Tick;
            armaT.Start();

            tVida = new Timer();
            tVida.Interval = 2000;
            tVida.Tick += tVida_Interval;
            t3.Start();

            t4 = new Timer();
            t4.Interval = 6000;
            t4.Tick += t4_Tick;
            t4.Start();

            timer1.Interval = 15;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            sprite.Start(60);

            tFin = new Timer();
            tFin.Interval = 10000;
            tFin.Tick += tFin_Tick;
            tFin.Start();

        }

        private void tFin_Tick(object sender, EventArgs e)
        {
            if (fin == true)
            {
                Form2 f2 = new Form2();
                f2.vHeroe = vidaHeroe;
                f2.vVillano = vidaVillano;
                new Form2().Show();
            }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (xVida < 530)
            {
                xVida += 3;
                Vida.X += 3;
            }
            else
            {
                xVida = 40;
            }
            Vida = new Rectangle(45, 42, xVida, vNum);
            Refresh();
        }

        private void t4_Tick(object sender, EventArgs e)
        {
            vida = true;
            vNum = v.Next(1, 1020);

            HongoX = hongox.Next(1, 450);
            HongoY = hongoy.Next(1, 930);
            rectHongo = new Rectangle(HongoX, HongoY, 60, 60);
            pintaHongo = true;
            Refresh();

        }

        private void tVida_Interval(object sender, EventArgs e)
        {
            vida = false;
            pintaHongo = false;
        }

        private void T3_Tick(object sender, EventArgs e)
        {
            DañoVillano();
        }

        private void ArmaT_Tick(object sender, EventArgs e)
        {
            Arma = arma.Next(1, 4);
            ArmaX = armax.Next(1, 950);
            ArmaY = armay.Next(1, 450);

            rectSmg = new Rectangle(ArmaX, ArmaY, 80, 80);
            rectScar = new Rectangle(ArmaX, ArmaY, 80, 80);
            rectPump = new Rectangle(ArmaX, ArmaY, 80, 80);
            pintaArma = true;
            Refresh();
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            if (mNum == 1 && yv > 100)
            {
                rectVillano.Y -= 5;
                yv -= 5;
            }

            if (mNum == 2 && xv > 20)
            {
                rectVillano.X -= 5;
                xv -= 5;
            }

            if (mNum == 3 && yv < 500)
            {
                rectVillano.Y += 5;
                yv += 5;
            }

            if (mNum == 4 && xv < 1020)
            {
                rectVillano.X += 5;
                xv += 5;
            }
            Refresh();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            tNum = t.Next(1, tMax);
            mNum = m.Next(1, mMax);
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
                rectHeroe.Y -= 10;
            }

            if (e.KeyChar == 'a' && x > 3 || e.KeyChar == 'A' && x > 3)
            {
                x -= 10;
                rectHeroe.X -= 10;
            }

            if (e.KeyChar == 's' && y < 530 || e.KeyChar == 'S' && y < 530)
            {
                y += 10;
                rectHeroe.Y += 10;
            }

            if (e.KeyChar == 'd' && x < 1050 || e.KeyChar == 'D' && x < 1050)
            {
                x += 10;
                rectHeroe.X += 10;
            }

            Point nuevo = new Point(x, y);


            //////////////////
            Refresh();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            alcanceHeroe = new Rectangle(x - xrect, y - yrect, rangex + widtharma, rangey + heightarma);
            alcanceVillano = new Rectangle(xv - xvrect, yv - yvrect, rangevx + widtharmaV, rangevy + heightarmaV);


            //g.DrawImage(heroe, x, y, 73, 110);
            //g.DrawImage(villano, xv, yv, 73, 102);

            if (pintaHeroe == true)
            {
                g.DrawImage(heroe, rectHeroe);
                g.DrawRectangle(Pens.Green, rectHeroe);
                g.DrawRectangle(Pens.Blue, alcanceHeroe);
            }

            if (pintaItem == true)
            {
                g.DrawImage(villano, rectVillano);
                g.DrawRectangle(Pens.Red, rectVillano);
                g.DrawRectangle(Pens.Black, alcanceVillano);
            }

            //Que arma aparece
            if (pintaArma == true)
            {
                //SMG
                if (Arma == 1)
                {
                    g.DrawImage(smg, rectSmg);

                    //Héroe
                    if (rectHeroe.IntersectsWith(rectSmg))
                    {
                        xrect = 10;
                        yrect = 10;
                        widtharma = 20;
                        heightarma = 20;
                        dañoH = 20;
                        pintaArma = false;
                    }

                    //Villano
                    if (rectVillano.IntersectsWith(rectSmg))
                    {
                        xvrect = 10;
                        yvrect = 10;
                        widtharmaV = 20;
                        heightarmaV = 20;
                        dañoV = 20;
                        pintaArma = false;
                    }

                }

                //SCAR
                if (Arma == 2)
                {
                    g.DrawImage(scar, rectScar);

                    //Héroe
                    if (rectHeroe.IntersectsWith(rectScar))
                    {
                        xrect = 20;
                        yrect = 20;
                        widtharma = 40;
                        heightarma = 40;
                        dañoH = 15;
                        pintaArma = false;
                    }

                    //Villano
                    if (rectVillano.IntersectsWith(rectScar))
                    {
                        xvrect = 20;
                        yvrect = 20;
                        widtharmaV = 40;
                        heightarmaV = 40;
                        dañoV = 15;
                        pintaArma = false;
                    }
                }

                //PUMP
                if (Arma == 3)
                {
                    g.DrawImage(pump, rectPump);

                    //Héroe
                    if (rectHeroe.IntersectsWith(rectPump))
                    {
                        xrect = 5;
                        yrect = 5;
                        widtharma = 10;
                        heightarma = 10;
                        dañoH = 25;
                        pintaArma = false;
                    }

                    //Villano
                    if (rectVillano.IntersectsWith(rectPump))
                    {
                        xvrect = 5;
                        yvrect = 5;
                        widtharmaV = 10;
                        heightarmaV = 10;
                        dañoV = 25;
                        pintaArma = false;
                    }
                }


            

            
            }

                if (pintaHongo == true)
                {
                    g.DrawImage(hong, rectHongo);
                    if (rectVillano.IntersectsWith(rectHongo))
                    {
                        vidaVillano += 40;
                        pintaHongo = false;
                    }
                    if (rectHeroe.IntersectsWith(rectHongo))
                    {
                        vidaHeroe += 40;
                        pintaHongo = false;

                    }

                if (vida == true)
                {
                    g.DrawImage(sprite.Paint(g), xVida, vNum);

                    if (rectHeroe.IntersectsWith(Vida))
                    {
                        vidaHeroe += 30;
                        vida = false;
                    }

                    if (rectVillano.IntersectsWith(Vida))
                    {
                        vidaVillano += 40;
                        vida = false;
                    }
                    GameOver();
                }
        }
    } 

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && alcanceHeroe.IntersectsWith(rectVillano) && vidaVillano > 0)
            {
                vidaVillano = vidaVillano - dañoH;
                VillanoTB.Text = vidaVillano.ToString();
             
            }

        }

        public void DañoVillano()
        {
            if (alcanceVillano.IntersectsWith(rectHeroe) && pintaHeroe == true && vidaHeroe > 0)
            {
                vidaHeroe = vidaHeroe - dañoV;
                HeroeTB.Text = vidaHeroe.ToString();
            }
        }

        public void GameOver()
        {
            if (vidaHeroe <= 0)
            {
                pintaHeroe = false;
                fin = true;
            }
            if (vidaVillano <= 0)
            {
                pintaItem = false;
                fin = true;

            }
            
        }

    }
}


