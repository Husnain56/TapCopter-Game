using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapCopter.Models
{
    class Helicopter : PictureBox
    {
        public Helicopter()
        {
            this.Height = this.Width = 50;
        }
        
        public int speed { get; set; } = 5;
        
        public void Display(Graphics g)
        {
            g.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(Location.X, Location.Y, this.Width, this.Height));
        }
    }
}
