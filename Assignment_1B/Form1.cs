using System;
using System.Windows.Forms;
using Assignment_1B.Models;
using Assignment_1B.Controllers;
using Assignment_1B.Views;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;


namespace Assignment_1B
{
    public partial class Form1 : Form
    {
        private BinaryFormatter formatter;
     
        private PersonModels theModel;
        private PersonControllers theController;
        private SecondView view2;
        private FirstView view1;
        private ThirdView view3;

        private bool isViewCreated = false;
        /// <summary>
        /// intialize controller, model, views and display views
        /// </summary>
        private void CompleteSetUp()
        {

            theController = new PersonControllers();
            theModel = new PersonModels(theController);
            view2 = new SecondView();
            view1 = new FirstView();
            view3 = new ThirdView();
            view2.MyModel = theModel;
            view1.MyModel = theModel;
            view3.MyModel = theModel;

            theController.addView(view2);
            theController.addView(view1);
            theController.addView(view3);
            view2.Show();
            view1.Show();
            view3.Show();
            isViewCreated = true;
        }
        public Form1()
        {
            InitializeComponent();
            /// intialize binary formatter
            formatter = new BinaryFormatter();
           //ompleteSetUp();
        }
        /// <summary>
        /// button click events for creat controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_controller_Click(object sender, EventArgs e)
        {
            theController = new PersonControllers();
        }
        /// <summary>
        /// button click event for create model
        /// check whether controller is created or not
        /// if not return message
        /// if controller is created than create models
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(theController == null)
            {
                MessageBox.Show("Please Make the Controller First by clicking on 'Create Controller' button. ");
            }
            else
            {
                theModel = new PersonModels(theController);
            }
        }
        /// <summary>
        /// button click events for create views 
        /// check whether controller and model are created or not
        /// if not display error message
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_views_Click(object sender, EventArgs e)
        {
            if (theController == null)
            {
                MessageBox.Show("Please Make the Controller First by clicking on 'Create Controller'. ");
            }
            else
            {
                if (theModel == null)
                {
                    MessageBox.Show("Please Make the Model by clicking on 'Create Model' button");
                }
                else
                {
                    isViewCreated = true;
                    view2 = new SecondView();
                    view1 = new FirstView();
                    view3 = new ThirdView();
                    view2.MyModel = theModel;
                    view1.MyModel = theModel;
                    view3.MyModel = theModel;

                    theController.addView(view2);
                    theController.addView(view1);
                    theController.addView(view3);
                }
            }
        }
        /// <summary>
        /// Display all views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_show_views_Click(object sender, EventArgs e)
        {
            if (theController == null)
            {
                MessageBox.Show("Please Make the Controller First by clicking on 'Create Controller' button. ");
            }
            else
            {
                if (theModel == null)
                {
                    MessageBox.Show("Please Make the Model by clicking on 'Create Model' button");
                }
                else
                {
                    if (!isViewCreated)
                    {
                        MessageBox.Show("please Create views by clicking on 'Create Views' button");
                    }
                    else
                    {
                        view2.Show();
                        view1.Show();
                        view3.Show();
                    }
                   
                }
            }
        }
        /// <summary>
        /// Save views into a binary file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!isViewCreated)
            {
                MessageBox.Show("There is nothing to save, Please create views First");
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Thread thread = new Thread(new ThreadStart(SaveData));
                    thread.Start();
                }
            }
            

        }
        /// <summary>
        /// save data using serialization and thread
        /// </summary>
        private void SaveData()
        {
           
            FileInfo fileinfo = new FileInfo(saveFileDialog1.FileName);
            Stream strm;
            strm = fileinfo.Open(FileMode.Create, FileAccess.ReadWrite);
            Thread.Sleep(3000);
            foreach(Person p in theModel.PersonList)
            {
                formatter.Serialize(strm, p);
            }
            strm.Close();
        }
        /// <summary>
        /// load views from binary file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (!isViewCreated)
            {
                CompleteSetUp();
                LoadData();
            }

            else
            {
                LoadData();
            }
            
        }
        /// <summary>
        /// load data from file
        /// </summary>
        private void LoadData()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theModel.PersonList.Clear();
                FileInfo finfo = new FileInfo(openFileDialog1.FileName);
                Stream strm = finfo.Open(FileMode.Open);
                while (strm.Position != strm.Length)
                {
                    theModel.PersonList.Add(formatter.Deserialize(strm));
                }
                strm.Close();
                theModel.UpdateViews();
            }
        }
        /// <summary>
        ///  button events for close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
