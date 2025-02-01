using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Videojuego
{
    public class Sprite
    {
        private int frame, interval, width, height;
        private string imgFile;
        private Image img;
        private Timer frameTimer;

        public Sprite (string imgFile, int height)
        {
            this.height = height;
            this.imgFile = imgFile;
            img = new Bitmap(imgFile);
            width = img.Width;
        }
        public void Start(int interval)
        {
            this.interval = interval;
            frameTimer = new Timer();
            frameTimer.Interval = interval;
            frameTimer.Tick += new EventHandler(frameTimer_Tick);
            frameTimer.Start();
        }

        void frameTimer_Tick(object sender, EventArgs e)
        {
            frame++;
            if(frame >= img.Height / height)
                frame= 0;
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

        
    }

}
