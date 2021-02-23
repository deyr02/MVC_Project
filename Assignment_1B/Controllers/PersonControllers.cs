using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_1B.Controllers
{
    /// <summary>
    /// interface class for each object
    /// </summary>
    public interface IPersonView
    {
        void RefreshView();
    }
    
    public class PersonControllers
    {
        /// <summary>
        /// store all viewlist
        /// </summary>
        private ArrayList ViewList;
        /// <summary>
        /// controller constructer
        /// </summary>
        public PersonControllers()
        {
            ViewList = new ArrayList();
        }
        /// <summary>
        /// add views in the controller
        /// </summary>
        /// <param name="aView"></param>
        public void addView(IPersonView aView)
        {
            ViewList.Add(aView);
        }
        /// <summary>
        /// update views
        /// </summary>
        public void updateViews()
        {
            IPersonView[] theViews = (IPersonView[])ViewList.ToArray(typeof(IPersonView));
            foreach(IPersonView v in theViews)
            {
                v.RefreshView();
            }
        }
    }
}
