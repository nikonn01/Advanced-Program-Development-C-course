using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1B
{
    public interface IShapeView
        {
            void RefreshView();
        }
    class ViewControl
    {
       
            private ArrayList ViewList;

            // constructor
            public ViewControl()
            {
                ViewList = new ArrayList();
            }

            /// <summary>method: AddView
            /// add view to viewlist
            /// </summary>
            /// <param name="aView"></param>
            public void AddView(IShapeView aView)
            {
                ViewList.Add(aView);
            }

            /// <summary>method: UpdateViews
            /// update each view 
            /// </summary>
            public void UpdateViews()
            {
                IShapeView[] theViews = (IShapeView[])ViewList.ToArray(typeof(IShapeView));
                foreach (IShapeView v in theViews)
                {
                    v.RefreshView();
                }
            }
        
    }
}
