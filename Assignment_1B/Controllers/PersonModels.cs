using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Assignment_1B.Models;

namespace Assignment_1B.Controllers
{
    public class PersonModels
    {
        /// <summary>
        /// store all object 
        /// </summary>
        private ArrayList personList;
        private PersonControllers theController;
        /// <summary>
        /// model constructor
        /// </summary>
        /// <param name="aController"></param>
        public PersonModels(PersonControllers aController)
        {
            personList = new ArrayList();
            theController = aController;
        }
        /// <summary>
        /// return person list
        /// </summary>
        public ArrayList PersonList
        {
            get
            {
                return personList;
            }
        }
        /// <summary>
        /// add object int arraylist
        /// update all views
        /// </summary>
        /// <param name="aPerson"></param>
        public void AddPerson(Person aPerson)
        {
            personList.Add(aPerson);
            UpdateViews();
        }
        /// <summary>
        /// Update objects
        /// </summary>
        /// <param name="aPerson"></param>
        public void UpdatePerson(Person aPerson)
        {
            UpdateViews();
        }
        /// <summary>
        /// delete selected object
        /// </summary>
        /// <param name="aPerson"></param>
        public void DeletePerson(Person aPerson)
        {
            personList.Remove(aPerson);
            UpdateViews();
        }
        /// <summary>
        /// Send object to back
        /// </summary>
        /// <param name="aPerson"></param>
        public void sendtoBack(Person aPerson)
        {
            ArrayList sortList = new ArrayList();
            int max = personList.IndexOf(aPerson);
            sortList.Add(aPerson);

            for (int i = 0; i < max; i++)
            {
                sortList.Add(personList[i]);
            }
            for(int i =0; i<sortList.Count; i++)
            {
                personList[i] = sortList[i];
            }
            UpdateViews();
        }
        /// <summary>
        /// bring object to the front
        /// </summary>
        /// <param name="aPerson"></param>
        public void BringToFront(Person aPerson)
        {
            ArrayList sortList = new ArrayList(personList);
            int max = personList.IndexOf(aPerson);

            int length = personList.Count;

            for(int i = max +1; i<length; i++)
            {
                sortList[i - 1] = personList[i];
            }
            sortList[length - 1] = personList[max];
            for (int i = 0; i < sortList.Count; i++)
            {
                personList[i] = sortList[i];
            }
            UpdateViews();

        }
        /// <summary>
        /// updates all views that have added in the controller.
        /// </summary>
        public void UpdateViews()
        {
            theController.updateViews();
        }
    }
}
