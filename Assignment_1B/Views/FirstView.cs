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
    public partial class FirstView : Form, IPersonView
    {
        private PersonModels myModel;
       
        Person topPerson;

 

        public FirstView()
        {
            InitializeComponent();
            cmb_rank.DropDownStyle = ComboBoxStyle.DropDownList;
            pnl_update.Visible = false;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }
      /*  
        protected override void Disponse(bool disposing)
        {
            if (disposing)
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        */
        /// <summary>
        /// return model
        /// </summary>
        public PersonModels MyModel
        {
            set
            {
                myModel = value;
            }
        }
        /*
        private void ClearPanel()
        {
            Canvas.CreateGraphics().Clear(Canvas.BackColor);
        }*/
        /// <summary>
        /// Refresh views
        /// </summary>
        public void RefreshView()
        {
            listBox1.Items.Clear();
            ArrayList thePersonList = myModel.PersonList;
            Person[] thePersons = (Person[])thePersonList.ToArray(typeof(Person));
           // Graphics g = this.Canvas.CreateGraphics();

            foreach(Person Per in thePersons)
            {
                listBox1.Items.Add(Per);
            }
        }
        /// <summary>
        /// add person into model and display it in all views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addPerson_Click(object sender, EventArgs e)
        {
            Person aPerson;
            if(rbCivilian.Checked == true)
            {
                if ((checkXandY()) && (validateCivilian(txt_Cash.Text)))
                {
                    aPerson = new Civilian(txt_lastName.Text, txt_firstName.Text, Convert.ToInt32(txt_x.Text), Convert.ToInt32(txt_y.Text), Convert.ToInt32(txt_Cash.Text));

                    myModel.AddPerson(aPerson);
                    clearFields();
                }
            }
           
          else if(rbCriminal.Checked == true)
            {
                if ((checkXandY())&& (validateCriminal(txt_charges.Text)))
                {
                    aPerson = new Criminal(txt_lastName.Text, txt_firstName.Text, Convert.ToInt32(txt_x.Text), Convert.ToInt32(txt_y.Text), Convert.ToInt32(txt_charges.Text));

                    myModel.AddPerson(aPerson);
                    clearFields();
                }
            }
            else if (rbPolice.Checked == true)
            {
                if ((checkXandY()) && (validateRank(cmb_rank.Text)))
                {
                    aPerson = new Police(txt_lastName.Text, txt_firstName.Text, Convert.ToInt32(txt_x.Text), Convert.ToInt32(txt_y.Text), cmb_rank.Text);

                    myModel.AddPerson(aPerson);
                    clearFields();
                }
            }

        }




        /// <summary>
        /// validate x,y, lastname, firstname
        /// </summary>
        /// <returns></returns>

        private bool checkXandY()
        {
            bool check = false;
            try
            {
                if (txt_x.Text == "" || txt_y.Text == "" || txt_lastName.Text == "" || txt_firstName.Text == "")

                {
                    if (txt_x.Text == "")
                    {
                        check = false;
                        MessageBox.Show("Please input value for 'x'");
                    }
                    if (txt_y.Text == "")
                    {
                        check = false;
                        MessageBox.Show("Please input value for 'y'");
                    }
                    if (txt_lastName.Text == "")
                    {
                        check = false;
                        MessageBox.Show("Last Name Can not be empty");
                    }
                    if (txt_firstName.Text == "")
                    {
                        check = false;
                        MessageBox.Show("Last Name Can not be empty");
                    }

                }
                else if ((Convert.ToInt32(txt_x.Text) > 530) || (Convert.ToInt32(txt_x.Text) < 0))
                {
                    MessageBox.Show("The value for 'X' can not be greater than 530 or less than 0");
                    check = false;
                }
                else if ((Convert.ToInt32(txt_y.Text) > 300) || (Convert.ToInt32(txt_y.Text) < 0))
                {
                    MessageBox.Show("The value for 'Y' can not be greater than 300 or less than 0");

                    check = false;
                }
                else if ((!checkNumber(txt_x.Text)) || (!checkNumber(txt_y.Text)))
                {
                    MessageBox.Show("Please input integer value for x and Y ");
                    check = false;

                }
                else
                {
                    check = true;
                }
            }
            catch (FormatException)
            {
                check = false;
                MessageBox.Show(" X and Y Value should be integer");
            }

            return check;
        }
        /// <summary>
        /// validate whether string contains any integer or not
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool checkNumber(string text)
        {
            bool check = false;
            for(int i =0; i< text.Length; i++)
            {
                if (!char.IsNumber(text[i]))
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }
        /// <summary>
        /// validate field cash in hand
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool validateCivilian(string text)
        {
            bool check = false;

            try
            {
                if (text == "")
                {
                    check = false;
                    MessageBox.Show("Cash in Hand can not be empty");

                }
                else if (Convert.ToInt32(text) > 5000)
                {
                    check = false;
                    MessageBox.Show("Chash in Hand can not be greater than 5000");
                }
                else if (Convert.ToInt32(text) <= 0)
                {
                    check = false;
                    MessageBox.Show("Chash in Hand can not be less than or equal 0");
                }
                else
                {
                    check = true;
                }
            }
            catch (FormatException)
            {
                check = false;
                MessageBox.Show("The input value for 'Cash in Hand' should be Integer");
            }
          

            return check;

        }
        /// <summary>
        /// validate total charges
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool validateCriminal(string text)
        {
            bool check = false;

            try
            {
                if (text == "")
                {
                    check = false;
                    MessageBox.Show("Total charges can not be empty");

                }
                else if (Convert.ToInt32(text) > 10)
                {
                    check = false;
                    MessageBox.Show("Total Charges can not be greater than 10");
                }
                else if (Convert.ToInt32(text) <= 0)
                {
                    check = false;
                    MessageBox.Show("Total Charges  can not be less than or equal 0");
                }
                else
                {
                    check = true;
                }
            }
            catch (FormatException)
            {
                check = false;
                MessageBox.Show("The input value for 'Total Charges' should be Integer");
            }


            return check;

        }
        /// <summary>
        /// validate rank
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool validateRank(string text)
        {
            bool check;
            if (text == "")
            {
                check = false;
                MessageBox.Show("Please select a Rank for Police");

            }
            else
            {
                check = true;
            }
            return check;
        }
        /// <summary>
        /// click events for civilian radion button
        /// display civilian panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCivilian_Click(object sender, EventArgs e)
        {
            rbCivilian.Checked = true;
            rbCriminal.Checked = false;
            rbPolice.Checked = false;
            pnl_Civilian.Visible = true;
            pnl_criminal.Visible = false;
            pnl_police.Visible = false;

        }
        /// <summary>
        /// click events for criminal radion button
        /// Display criminal panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCriminal_Click(object sender, EventArgs e)
        {
            rbCivilian.Checked = false;
            rbCriminal.Checked = true;
            rbPolice.Checked = false;
           
            pnl_criminal.Visible = true;
            pnl_Civilian.Visible = false;
            pnl_police.Visible = false;
        }
        /// <summary>
        /// click events for police radio button
        /// display police panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbPolice_Click(object sender, EventArgs e)
        {
            rbCivilian.Checked = false;
            rbCriminal.Checked = false;
            rbPolice.Checked = true;
            pnl_police.Visible = true;
            pnl_criminal.Visible = false;
            pnl_Civilian.Visible = false;
            
        }
        /// <summary>
        /// clear all textfields
        /// </summary>
        private void clearFields()
        {
            txt_x.Text = "";
            txt_y.Text = "";
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_Cash.Text = "";
            txt_charges.Text = "";
            cmb_rank.Text = "";
        }
        /// <summary>
        /// refresh vies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myModel.UpdateViews();
        }
        /// <summary>
        /// Edit selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(topPerson != null)
            {
                MessageBox.Show("You may only update Persons Position and  persons LastName and FirstName");
               
                txt_x.Text = topPerson.x_pos.ToString();
                txt_y.Text = topPerson.y_pos.ToString();
                txt_firstName.Text = topPerson.FName;
                txt_lastName.Text = topPerson.LName;

                pnl_update.Visible = true;
                btn_addPerson.Visible = false;

                pnl_police.Visible = false;
                pnl_criminal.Visible = false;
                pnl_Civilian.Visible = false;

                rbCivilian.Enabled = false;
                rbCriminal.Enabled = false;
                rbPolice.Enabled = false;
               
            }
        }
        /// <summary>
        /// event for cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clearFields();
            rbCivilian.Enabled = true;
            rbCriminal.Enabled = true;
            rbPolice.Enabled = true;

            pnl_update.Visible = false;
            btn_addPerson.Visible = true;

            if(rbCivilian.Checked == true)
            {
                pnl_police.Visible = false;
                pnl_criminal.Visible = false;
                pnl_Civilian.Visible = true;
            }
            else if(rbCriminal.Checked == true)
            {
                pnl_police.Visible = false;
                pnl_criminal.Visible = true;
                pnl_Civilian.Visible = false;
            }
            else if(rbPolice.Checked == true)
            {
                pnl_police.Visible = true;
                pnl_criminal.Visible = false;
                pnl_Civilian.Visible = false;
            }
        }
        /// <summary>
        /// button events for update button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (checkXandY())
            {
                Person p = topPerson;
                p.x_pos = Convert.ToInt32(txt_x.Text);
                p.y_pos = Convert.ToInt32(txt_y.Text);
                p.LName = txt_lastName.Text;
                p.FName = txt_firstName.Text;
                MessageBox.Show("The selected person details has been updated successfully");
                myModel.UpdateViews();
                btn_cancel_Click(sender, e);
               
            }
        }
        /// <summary>
        /// delete objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(topPerson != null)
            {
                
                myModel.DeletePerson(topPerson);
                MessageBox.Show("The selected person has been deleted successfully");
            }
            myModel.UpdateViews();
        }
        /// <summary>
        /// click events for list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            int i = 0;
            foreach(Person p in myModel.PersonList)
            {
                if(i == index)
                {
                    topPerson = p;
                    break;
                }
                i++;
            }
        }
    }
}
