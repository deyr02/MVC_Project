using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Assignment_1B.Models
{
    /// <summary>
    /// extends person
    /// </summary>
    [Serializable]
    class Police:Person
    {
        string rank;
        public Police(string lastName, string firstName, int position_x, int position_y, string rank)
            :base(lastName, firstName, position_x, position_y, "Police")
        {
            this.rank = rank;
        }
        /// <summary>
        /// returns details of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Police: " + this.getName() + "   Located At " + this.getPosition();

        }
        /// <summary>
        /// override the showperson method
        /// determine the graphics for object based on rank
        /// </summary>
        /// <param name="g"></param>
        public override void ShowPerson(Graphics g)
        {

            if (g != null)
            {
                Image newImage = null;
                if (Rank == "Surgent")
                {
                    newImage = Properties.Resources.Police1;
                }
               else if (Rank == "Senior Surgent")
                {
                    newImage = Properties.Resources.Police2;
                }
                else if (Rank == "Sub Inspector")
                {
                    newImage = Properties.Resources.Police3;
                }
                else if (Rank == "Inspector")
                {
                    newImage = Properties.Resources.Police4;
                }
                else if (Rank == "Office Incharge")
                {
                    newImage = Properties.Resources.Police;
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
                g.DrawRectangle(p, new Rectangle(x, y, person_width, person_height));
                // g.DrawEllipse(p, xfloat, yfloat, boarderDiameter, boarderDiameter);
                p.Dispose();
            }
        }
        /// <summary>
        /// get adn set Rank
        /// </summary>
        public string Rank
        {
            get
            {
                return rank;
            }
            set
            {
                rank = value;
            }
        }
        /// <summary>
        /// get and set x position of the object
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
        /// get and set y position of the object
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
        /// get and set image height image height
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
        /// get and set image width of image
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
        /// determine whether object is selected or not
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
