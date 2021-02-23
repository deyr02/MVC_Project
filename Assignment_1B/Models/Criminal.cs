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
    /// extends person class
    /// </summary>
    [Serializable]
    class Criminal:Person
    {
        int numberofCharges;
        bool currentCharges = false;
        public Criminal(string lastName, string firstName, int position_x, int position_y, int NumberOfCharges)
            :base(lastName, firstName, position_x, position_y, "Criminal")
        {
            this.numberofCharges = NumberOfCharges;
        }
        /// <summary>
        /// return object details
        /// </summary>
        /// <returns></returns>
    public override string ToString()
    {
        return "Criminal: " + this.getName() + "   Located At " + this.getPosition();

    }
    /// <summary>
    /// get and set value for current charges
    /// </summary>
    public bool CurrentCharges
        {
            get
            {
                return currentCharges;
            }
            set
            {
                currentCharges = value;
            }
        }
        /// <summary>
        /// get and set number of charges
        /// </summary>
    public int NumberOfCharge
        {
            get
            {
                return numberofCharges;
            }
            set
            {
                numberofCharges = value;
            }
        }
    /// <summary>
    /// override  the shouPerson method
    /// determine the graphics for criminal based on number of charges
    /// </summary>
    /// <param name="g"></param>
        public override void ShowPerson(Graphics g)
        {
            if (g != null)
            {
                Image newImage = null;
                if((numberofCharges>=0) && (numberofCharges <= 2))
                {
                    newImage = Properties.Resources.Criminal3;
                }
                else if ((numberofCharges > 2) && (numberofCharges <= 4))
                {
                    newImage = Properties.Resources.Criminal4;
                }
                else if ((numberofCharges > 4) && (numberofCharges <= 6))
                {
                    newImage = Properties.Resources.Criminal2;
                }
                else if ((numberofCharges > 6) && (numberofCharges <= 8))
                {
                    newImage = Properties.Resources.Criminal1;
                }
                else if ((numberofCharges > 8) && (numberofCharges <= 10))
                {
                    newImage = Properties.Resources.Criminal;
                }
               
                // Create image.
              
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
        /// override the X position of the object
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
        /// Override the y postion of the object
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
        /// override the graphics height
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
        /// overridet the graphics width
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
        /// Detemines whether object is selected or not
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
