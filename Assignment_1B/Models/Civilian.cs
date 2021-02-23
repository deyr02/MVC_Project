using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Assignment_1B.Models
{
    /// <summary>
    /// Extends Person
    /// </summary>
    [Serializable]
    class Civilian:Person
    {
        /// <summary>
        /// Unique attributes
        /// </summary>
        int HandCash;
        public Civilian(string lastName, string firstName, int position_x, int position_y, int cashInHand)
            :base(lastName, firstName, position_x, position_y, "Civilian")
        {
            this.HandCash = cashInHand;
            
        }
        /// <summary>
        /// return object details
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Civilian: " + this.getName() +  "   Located At " + this.getPosition();

        }
        /// <summary>
        /// override the showperson method
        /// Determines which image will be add according  to the value of Hand in Cash
        /// </summary>
        /// <param name="g"></param>
        public override void ShowPerson(Graphics g)
        {
            if(g != null)
            {
                Image newImage = null;
                // Create image.
                if ((HandCash >=0) && (HandCash <= 1000))
                {
                    newImage = Properties.Resources.Civilian1;
                }
                else if ((HandCash > 1000) && (HandCash <= 2000))
                {
                    newImage = Properties.Resources.Civilian2;
                }
                else if ((HandCash > 2000) && (HandCash <= 3000))
                {
                    newImage = Properties.Resources.Civilian3;
                }
                else if ((HandCash > 3000) && (HandCash <= 4000))
                {
                    newImage = Properties.Resources.Civilian4;
                }
                else if ((HandCash > 4000) && (HandCash <= 5000))
                {
                    newImage = Properties.Resources.Civilian;
                }

                // Create rectangle for displaying image.
                Rectangle destRect = new Rectangle(x, y, person_width, this.person_height);
                // Draw image to screen.
                g.DrawImage(newImage, destRect);
            }
            if (Highlight)
            {
                float boarderDiameter = (float)(person_width - 3);
                Pen p = new Pen(Color.Black, 3);
                p.DashStyle = DashStyle.Solid;
                float xfloat = (float)(x + 1.5);
                float yfloat = (float)(y + 1.5);
                g.DrawRectangle(p, new Rectangle(x,y,person_width, person_height));
               // g.DrawEllipse(p, xfloat, yfloat, boarderDiameter, boarderDiameter);
                p.Dispose();
            }
        }
        /// <summary>
        /// get and set value for x
        /// </summary>
        
        public override int x_pos
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        /// <summary>
        /// get and set value for y
        /// </summary>
        public override int y_pos
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
        /// <summary>
        /// getand set image height
        /// </summary>
        public override int person_height
        {
            get
            {
                return Height;
            }

            set
            {
                Height = value;
            }
        }
        /// <summary>
        /// get and set image width
        /// </summary>
        public override int person_width
        {
            get
            {
                return Width;
            }

            set
            {
                Width = value;
            }
        }
        /// <summary>
        /// Determines whether object is selected or not
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public override bool isHighlight(Point p)
        {
            GraphicsPath pth = new GraphicsPath();
            pth.AddEllipse(x, y, person_width, person_height);
            bool retval = pth.IsVisible(p);
            pth.Dispose();
            return retval;
        }

       
    }
}
