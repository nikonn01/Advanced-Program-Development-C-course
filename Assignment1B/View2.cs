// --------------------------------------------------------------------------------------------------------------------
// <copyright file="View2.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the View2 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment1B
{
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using ctlSvgPlayground.Controller;

    /// <summary>
    /// The view 2.
    /// </summary>
    public partial class View2 : Form, IViewUpdate
    {
        /// <summary>
        /// The view controller.
        /// </summary>
        private readonly IViewController viewController;

        /// <summary>
        /// Initializes a new instance of the <see cref="View2"/> class.
        /// </summary>
        /// <param name="controller">
        /// The controller.
        /// </param>
        public View2(IViewController controller)
        {
            this.viewController = controller;
            InitializeComponent();
            this.ctlShapePlayground1.ViewController = controller;
        }

        /// <summary>
        /// The update view.
        /// </summary>
        public void UpdateView()
        {
            Task task = Task.Run(
                () =>
                    {
                        this.ctlShapePlayground1.CreateGraphics().Clear(this.ctlShapePlayground1.BackColor);
                        Graphics graphics = this.ctlShapePlayground1.CreateGraphics();
                        this.ctlShapePlayground1.Redraw(graphics);
                    });
        }

        /// <summary>
        /// The view 2_ form closing.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void View2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.viewController.DeleteView(this);
        }
    }
}
