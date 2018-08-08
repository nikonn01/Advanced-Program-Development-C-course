namespace Assignment1B
{
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using ctlSvgPlayground.Controller;

    /// <summary>
    /// The view 1.
    /// </summary>
    public partial class View1 : Form, IViewUpdate
    {
        /// <summary>
        /// The view controller.
        /// </summary>
        private readonly IViewController viewController;

        /// <summary>
        /// Initializes a new instance of the <see cref="View1"/> class.
        /// </summary>
        /// <param name="controller">
        /// The controller.
        /// </param>
        public View1(IViewController controller)
        {
            this.viewController = controller;
            InitializeComponent();
            this.ctlShapePlayground1.Editable = true;
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
        /// The view 1_ form closing.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void View1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.viewController.DeleteView(this);
        }
    }
}
