namespace ctlSvgPlayground.Controller
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing.Text;

    using ctlSvgPlayground.Model;

    /// <summary>
    /// The global ViewController interface.
    /// </summary>
    public interface IViewController
    {
        ArrayList ViewList { get; set; }

        IList<IShape> GetModel();

        void AddView(IViewUpdate view);

        void DeleteView(IViewUpdate view);

        void UpdateViews();
    }
}