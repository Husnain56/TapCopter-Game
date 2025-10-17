using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TapCopter.Properties;

namespace TapCopter.Models
{
    internal class Obstacle : PictureBox
    {
        public int speed = 8;
        public Obstacle(Point P)
        {
            this.BackColor = Color.DarkCyan;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Size = new Size(50, 140);
            this.Location = P;
            
        }

        public void MoveLeft()
        {
            Point P = this.Location;
            P.X -= speed;
            this.Location = P;
        }
        public void Display(Graphics g)
        {
            g.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(Location.X, Location.Y, this.Width, this.Height));
        }
    }
}
