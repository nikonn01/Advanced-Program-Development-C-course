// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewController.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ShapesViewController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment1B
{
    using System.Collections;
    using System.Collections.Generic;

    using ctlSvgPlayground.Controller;
    using ctlSvgPlayground.Model;

    /// <summary>
    /// The Views controller class.
    /// </summary>
    class ShapesViewController : IViewController
    {
        /// <summary>
        /// Gets or sets the views list.
        /// </summary>
        public ArrayList ViewList { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapesViewController"/> class.
        /// </summary>
        public ShapesViewController()
        {
            ViewList = new ArrayList();
        }

        /// <summary>
        /// The get model.
        /// </summary>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        public IList<IShape> GetModel()
        {
            return ShapeList.GetInstance();
        }

        /// <summary>
        /// The add view.
        /// </summary>
        /// <param name="view">
        /// The view.
        /// </param>
        public void AddView(IViewUpdate view)
        {
            ViewList.Add(view);
        }

        /// <summary>
        /// The delete view.
        /// </summary>
        /// <param name="view">
        /// The view.
        /// </param>
        public void DeleteView(IViewUpdate view)
        {
            ViewList.Remove(view);
        }

        /// <summary>
        /// The update views.
        /// </summary>
        public void UpdateViews()
        {
            IViewUpdate[] views = (IViewUpdate[])ViewList.ToArray(typeof(IViewUpdate));
            foreach (IViewUpdate view in views)
            {
                view.UpdateView();
            }
        }
    }
}
