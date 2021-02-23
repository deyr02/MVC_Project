using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using Assignment_1B.Models;
using Assignment_1B.Controllers;

namespace Assignment_1B.Views
{
    public partial class ThirdView : Form, IPersonView
    {
        private PersonModels myModel;
        public ThirdView()
        {
            InitializeComponent();
            cmb_filter.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmb_filter.SelectedIndex = 0;
          
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }
        /// <summary>
        /// set model
        /// </summary>

        public PersonModels MyModel
        {
            set
            {
                myModel = value;
            }
        }
        /// <summary>
        /// clear all object from the canvas
        /// </summary>
        private void ClearPanel()
        {
            Canvas.CreateGraphics().Clear(Canvas.BackColor);
        }
        /// <summary>
        /// Refresh views
        /// </summary>
        public void RefreshView()
        {
            ClearPanel();
            ArrayList thePersonList = myModel.PersonList;
            Person[] thePersons = (Person[])thePersonList.ToArray(typeof(Person));
            Graphics g = this.Canvas.CreateGraphics();

            foreach (Person Per in thePersons)
            {
                Per.ShowPerson(g);
            }
        }
        /// <summary>
        /// Diplay graphics through filtering takes one argument
        /// </summary>
        /// <param name="text"></param>
        public void DisplayPersons(string text)
        {
            ClearPanel();
            ArrayList thePersonList = myModel.PersonList;
            Person[] thePersons = (Person[])thePersonList.ToArray(typeof(Person));
            Graphics g = this.Canvas.CreateGraphics();

            foreach (Person Per in thePersons)
            {
                if (Per.getPersonType.Equals(text))
                {
                    Per.ShowPerson(g);
                }
            }
        }
        /// <summary>
        /// Display graphics through filtering takes two arguments
        /// </summary>
        /// <param name="text"></param>
        /// <param name="text1"></param>
        public void DisplayPersons(string text, string text1)
        {
            ClearPanel();
            ArrayList thePersonList = myModel.PersonList;
            Person[] thePersons = (Person[])thePersonList.ToArray(typeof(Person));
            Graphics g = this.Canvas.CreateGraphics();

            foreach (Person Per in thePersons)
            {
                if (Per.getPersonType.Equals(text) || Per.getPersonType.Equals(text1))
                {
                    Per.ShowPerson(g);
                }
            }
        }
        /// <summary>
        /// combo box click events
        /// return selected item  and filter the  objectes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_filter.SelectedIndex == 0)
            {
                RefreshView();
            }
            else if(cmb_filter.SelectedIndex == 1)
            {
                DisplayPersons("Civilian");
            }
            else if (cmb_filter.SelectedIndex == 2)
            {
                DisplayPersons("Criminal");
            }
            else if (cmb_filter.SelectedIndex == 3)
            {
                DisplayPersons("Police");
            }
            else if (cmb_filter.SelectedIndex == 4)
            {
                DisplayPersons("Civilian", "Police");
            }
            else if (cmb_filter.SelectedIndex == 5)
            {
                DisplayPersons("Criminal", "Police");
            }
        }
    }
}
