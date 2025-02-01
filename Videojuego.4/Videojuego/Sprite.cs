using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videojuego
{
    class Sprite
    {
        /*private int frame, interval, width, height;
        private string imgFile;
        private Image img;
        //private Timer frameTimer;

        public Sprite (int height, string imgFile)
        {
            this.height = height;
            this.imgFile = imgFile;
            img = new Bitmap(imgFile);
            width = img.Width;
        }
        /*public void Start(int interval)
        {
            this.interval = interval;
            frameTimer = new Timer();
            frameTimer.Interval = interval;
            frameTimer.Tick += new EventHandler(frameTimer_tick);
            frameTimer.Start();
        }

        public Bitmap Paint (Graphics g)
        {
            Bitmap temp;
            Graphics tempGraphics;

            temp = new Bitmap(width, height, g);
            tempGraphics = Graphics.FromImage(temp);

            tempGraphics.DrawImageUnscaled(img, 0, 0 - (height * frame));

            tempGraphics.Dispose();
            return temp;
        }

        /*void frameTimer_Ticker(object sender, EventArgs e)
        {
            this.interval = interval;
            frameTimer = new Timer();
            frameTimer.Interval = interval;
            frameTimer.Tick += new EventHandler(frameTimer_Ticker);
            frameTimer.Start();
        }*/
    }

}
