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
    /// Super class
    /// </summary>
    [Serializable]
    public abstract class Person
    {
        private int ID = 1000;
        protected string LastName;
        protected string FirstName;
        protected int x;
        protected int y;
        protected int Height = 70;
        protected int Width = 50;
        protected string PType;
        //used to highlight the object
        bool highlight;
       /// <summary>
       /// Constructor for Super Class
       /// </summary>
       /// <param name="lastname"></param>
       /// <param name="firstname"></param>
       /// <param name="Postition_x"></param>
       /// <param name="Position_y"></param>
       /// <param name="personType"></param>
        public Person(string lastname, string firstname, int Postition_x, int Position_y, string personType)
        {
            this.LastName = lastname;
            this.FirstName = firstname;
            this.x = Postition_x;
            this.y = Position_y;
            this.PType = personType;
            ID++;
           
          
        }
        /// <summary>
        /// Return the Type of Person (Civilian, Criminal, Police)
        /// </summary>
        public string getPersonType
        {
            get
            {
                return PType;
            }
        }
        /// <summary> method: Shouperson
        /// abstruct method for showing griphcihs for each object
        /// </summary>
        /// <param name="g"></param>
        public abstract void ShowPerson(Graphics g);
        /// <summary>
        /// Determines whether object is selected or not
        /// </summary>
        public bool Highlight
        {
            get
            {
                return highlight;
            }
            set
            {
                highlight = value;
            }
        }
       /// <summary>Method: getPostion
       /// Return the position of objectect in Stiring format
       /// </summary>
       /// <returns></returns>
        public string getPosition()
        {
            return "(" + x.ToString() + "," + y.ToString() + ")";
        }
        
        /// <summary>
        /// get and set X value for each object
        /// </summary>
        public abstract int x_pos
        {
            get;
            set;
        }
        /// <summary>
        /// get and set Y value
        /// </summary>
        public abstract int y_pos
        {
            get;
            set;
        }
        /// <summary>
        /// get and set LastName
        /// </summary>
        public string LName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        /// <summary>
        /// get and set First Name
        /// </summary>
        public string FName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        /// <summary>
        /// get and set width for  grapphics inmage
        /// </summary>
        public abstract int person_width
        {
            get;
            set;
        }
        /// <summary>
        /// get and set height for graphics Image
        /// </summary>
        public abstract int person_height
        {
            get;
            set;
        }
        /// <summary>Method getName()
        /// return full name
        /// </summary>
        /// <returns></returns>

        public string getName()
        {
            return FirstName + " " + LastName;
        }

       /// <summary>
       /// Define whether object is selected or not
       /// </summary>
       /// <param name="p"></param>
       /// <returns></returns>
        public virtual bool isHighlight(Point p)
        {
            Point pt = new Point(x, y);
            Size size = new Size(100, 100);
            return new Rectangle(pt, size).Contains(p);
        }
    }
}
