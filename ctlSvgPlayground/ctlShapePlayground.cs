// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ctlShapePlayground.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ctlShapePlayground type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ctlSvgPlayground
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using ctlSvgPlayground.Controller;
    using ctlSvgPlayground.Model;
    using System.Collections;
    using System.Reflection;
    using System.Globalization;

    /// <summary>
    /// The user control to work with shapes.
    /// </summary>
    public partial class ctlShapePlayground : UserControl
    {
        /// <summary>
        /// The editable state for control.
        /// </summary>
        private bool editable;

        /// <summary>
        /// The check coordinates.
        /// </summary>
        private bool checkCoordinates = false;

        /// <summary>
        /// Sets the view controller.
        /// </summary>
        public IViewController ViewController
        {
            set
            {
                this.viewController = value;
                this.shapeList = (ShapeList)value.GetModel();
            }
        }

        /// <summary>
        /// The editable state trigger for control.
        /// </summary>
        public bool Editable
        {
            get
            {
                return this.editable;
            }

            set
            {
                this.editable = value;
                if (value)
                {
                    this.gpbIShape.Enabled = true;
                    this.gpbShapeColor.Enabled = true;
                    this.gbpShapeCoordintes.Enabled = true;
                    this.btnNewShape.Enabled = true;
                    this.btnUpdateShape.Enabled = true;
                    this.btnDeleteShape.Enabled = true;
                    this.txtXcoordinate.Enabled = true;
                    this.txtYcoordinate.Enabled = true;
                    this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctlShapePlayground_MouseDown);
                    this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ctlShapePlayground_MouseMove);
                    this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ctlShapePlayground_MouseUp);
                }
                else
                {
                    this.gpbIShape.Enabled = true;
                    this.gpbShapeColor.Enabled = false;
                    this.gbpShapeCoordintes.Enabled = false;
                    this.btnNewShape.Enabled = false;
                    this.txtXcoordinate.Enabled = false;
                    this.txtYcoordinate.Enabled = false;
                    this.btnUpdateShape.Enabled = true;
                    this.btnDeleteShape.Enabled = false;
                    this.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.ctlShapePlayground_MouseDown);
                    this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.ctlShapePlayground_MouseMove);
                    this.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.ctlShapePlayground_MouseUp);
                }
            }
        }

        /// <summary>
        /// The offsset mouse position.
        /// </summary>
        private Point offssetMousePos = Point.Empty;

        /// <summary>
        /// The render for SVG engine.
        /// </summary>
        private Svg.ISvgRenderer render = null;

        /// <summary>
        /// The link on Global view controller.
        /// </summary>
        private IViewController viewController;

        /// <summary>
        /// The List contains Shapes.
        /// </summary>
        private ShapeList shapeList = ShapeList.GetInstance();

        /// <summary>
        /// The rectangle for Shape's selection.
        /// </summary>
        private RectangleF selectedRectangle = new RectangleF();

        /// <summary>
        /// Initializes a new instance of the <see cref="ctlShapePlayground"/> class.
        /// </summary>
        public ctlShapePlayground()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            BackColor = Color.White;
        }

        /// <summary>
        /// The on paint event.
        /// </summary>
        /// <param name="e">
        /// The event.
        /// </param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Redraw(e.Graphics);
        }

        /// <summary>
        /// The redraw.
        /// </summary>
        /// <param name="graphics">
        /// The graphics.
        /// </param>
        public void Redraw(Graphics graphics)
        {
            List<IShape> bufList = this.shapeList.ToList();
            foreach (IShape shape in bufList)
            {
                            graphics.DrawPath(new Pen(Brushes.Black, 2), shape.Draw().Path(render));
                            SolidBrush fillBrush = new SolidBrush(shape.color);
                            graphics.FillPath(fillBrush, shape.Draw().Path(render));
            }

            // Rendering frame around active Shape
            RectangleF bufRectangle = (this.shapeList.GetActive() != null) ? shapeList.GetActive().Draw().Path(render).GetBounds() : new RectangleF(0, 0, 0, 0);
            Point point = new Point((int)bufRectangle.X, (int)bufRectangle.Y);
            Size size = new System.Drawing.Size((int)bufRectangle.Size.Width, (int)bufRectangle.Size.Height);
            Rectangle rect = new Rectangle(point, size);
            Pen selectionPen = new Pen(Brushes.Red, 2);
            selectionPen.DashStyle = DashStyle.Dot;
            graphics.DrawRectangle(selectionPen, rect);
        }

        /// <summary>
        /// The mouse down event handler.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ctlShapePlayground_MouseDown(object sender, MouseEventArgs e)
        {
            List<IShape> bufShapeList = this.shapeList.ToList();
            foreach (IShape shape in bufShapeList/*.OrderByDescending(o => o.Active)*/)
            {
                if (shape.Draw().Path(render).IsVisible(e.Location))
                {
                    this.selectedRectangle = shape.Draw().Path(render).GetBounds();
                    Point shapePoint = new Point(shape.translateX, shape.translateY);
                    Point mousePoint = new Point(e.Location.X, e.Location.Y);
                    this.offssetMousePos = new Point(mousePoint.X - shapePoint.X, mousePoint.Y - shapePoint.Y);

                    this.shapeList.SetActive(shape);
                }
                else
                {
                    this.shapeList.MakeInactive(shape);
                }
            }

            this.Invalidate();
            this.viewController.UpdateViews();
        }

        /// <summary>
        /// The mouse up event handler.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ctlShapePlayground_MouseUp(object sender, MouseEventArgs e)
        {
            IShape active = this.shapeList.GetActive();
            this.offssetMousePos = Point.Empty;
            if (active != null && (active is PlaneShape || active is HelicopterShape))
            {
                foreach (IShape shape in this.shapeList)
                {
                    if (shape is Cloud)
                    {
                        RectangleF bounds = active.Draw().Path(render).GetBounds();
                        if (shape.Draw().Path(render).IsVisible(bounds.X, bounds.Y)
                             || shape.Draw().Path(render).IsVisible(bounds.X + bounds.Width, bounds.Y)
                             || shape.Draw().Path(render).IsVisible(bounds.X, bounds.Y + bounds.Height)
                             || shape.Draw().Path(render).IsVisible(bounds.X + bounds.Width, bounds.Y + bounds.Height))
                        {
                            if (((Cloud)shape).GetIn(active))
                            {
                                this.shapeList.SetActive(shape);
                                return;
                            }
                            else
                            {
                                if (shape.Owner == null)
                                {
                                    bounds = shape.Draw().Path(render).GetBounds();
                                    active.translateY = Convert.ToInt32(bounds.Y + bounds.Height);
                                    active.Message = "I can't go in the clouds!";
                                    shape.Message = "HO HO HO... I'm angry cloud \u2607";

                                }
                            }
                        }
                    }
                }
                if (active.Owner != null) ((Cloud)active.Owner).GetOff(active);
                this.Invalidate();
                this.viewController.UpdateViews();
            }
        }

        /// <summary>
        /// The mouse move event handler.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ctlShapePlayground_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0 && this.shapeList.GetActive() != null)
            {
                IShape shape = this.shapeList.GetActive();
                Point prevPoint = new Point(shape.translateX, shape.translateY);

                shape.translateX = e.X - this.offssetMousePos.X;
                shape.translateY = e.Y - this.offssetMousePos.Y;
                this.selectedRectangle.Location = new PointF(shape.translateX + 2, shape.translateY + 2);

                List<IShape> depShapes = this.shapeList.Where(w => w.Owner == shape).ToList();
                foreach (IShape depShape in depShapes)
                {
                    depShape.translateX += shape.translateX - prevPoint.X;
                    depShape.translateY += shape.translateY - prevPoint.Y;
                }

                this.Invalidate();
                this.viewController.UpdateViews();
            }
        }

        /// <summary>
        /// The lbl select color click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void lblSelectColor_Click(object sender, EventArgs e)
        {
            lblSelectColor.BackColor = (sender as Label).BackColor;

            this.Invalidate();
            this.viewController.UpdateViews();
        }

        /// <summary>
        /// The btn new shape click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btnNewShape_Click(object sender, EventArgs e)
        {
            if ((txtXcoordinate.Text.ToString() == string.Empty) ||
                    (txtYcoordinate.Text.ToString() == string.Empty) ||
                    (cmbIShape.Text.ToString() == string.Empty))
                // display error message
                MessageBox.Show
                    ("Please enter Shape Coordinates and Shape Type", "Required Data Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int setx = Convert.ToInt32((txtXcoordinate.Text.Trim().Length == 0) ? "0" : txtXcoordinate.Text);
                int sety = Convert.ToInt32((txtYcoordinate.Text.Trim().Length == 0) ? "0" : txtYcoordinate.Text);
                checkCoordinates = CheckCoordinates(setx, sety);
                if (checkCoordinates)
                {
                    this.selectedRectangle.X = setx + 2;
                    this.selectedRectangle.Y = sety + 2;
                    string shape = cmbIShape.SelectedItem.ToString();
                    if (shape == "Plane Shape")
                    {
                        this.shapeList.Add(
                            new PlaneShape() { color = this.lblSelectColor.BackColor, translateX = setx, translateY = sety });
                    }
                    else if (shape == "Helicopter Shape")
                    {
                        this.shapeList.Add(
                            new HelicopterShape() { color = this.lblSelectColor.BackColor, translateX = setx, translateY = sety });
                    }
                    else if (shape == "Cloud Shape")
                    {
                        this.shapeList.Add(
                            new Cloud() { color = this.lblSelectColor.BackColor, translateX = setx, translateY = sety });
                    }
                    else
                    {
                        return;
                    }
                }
            }

            this.Invalidate();
            this.viewController.UpdateViews();
        }

        //checking coordinates
        /// <summary>
        /// The check coordinates.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool CheckCoordinates(int x, int y)
        {

            int X = this.Height;
            int Y = this.Width;
            checkCoordinates = false;

            // validate data entry is within limits
            if ((x > X) || (y > Y))
                MessageBox.Show("Maximum value for X is " + X.ToString()
                    + "\r\n" + "Maximum value for Y is " + Y.ToString()
                   + "\r\n", "Please Check the Values Entered",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                checkCoordinates = true;
            return checkCoordinates;
        }

        /// <summary>
        /// The btn update shape_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btnUpdateShape_Click(object sender, EventArgs e)
        {
            if (!Editable)
            {
                string filter = string.Empty;
                if (this.cmbIShape.SelectedItem != null)
                {
                    string shape = cmbIShape.SelectedItem.ToString();
                    if (shape == "Plane Shape")
                    {
                        filter = "plane";
                    }
                    else if (shape == "Helicopter Shape")
                    {
                        filter = "helicopter";
                    }
                    else if (shape == "Cloud Shape")
                    {
                        filter = "cloud";
                    }
                }

                this.shapeList.SetFilter(filter);
                this.Invalidate();
                return;
            }

            int setxUpdate = Convert.ToInt32((txtXcoordinate.Text.Trim().Length == 0) ? "0" : txtXcoordinate.Text);
            int setyUpdate = Convert.ToInt32((txtYcoordinate.Text.Trim().Length == 0) ? "0" : txtYcoordinate.Text);
            checkCoordinates = CheckCoordinates(setxUpdate, setyUpdate);

            if (checkCoordinates)
            {
                IShape shapeActive = this.shapeList.GetActive();
                if (shapeActive != null)
                {

                    shapeActive.color = this.lblSelectColor.BackColor;
                    shapeActive.SetPosition(setxUpdate, setyUpdate);
                }
            }

            this.viewController.UpdateViews();
        }

        /// <summary>
        /// The btn delete shape_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btnDeleteShape_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete selected shape?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                IShape shapeActive = this.shapeList.GetActive();
                shapeList.Remove(shapeActive);
                this.viewController.UpdateViews();
            }
        }

        private void cmbIShape_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        /// <summary>method: CheckForNumeric
		/// check for only numbers and backspace key
		/// </summary>
		/// <param name="ch"></param>
		/// <returns></returns>
		static bool CheckForNumeric(char ch)
        {
            int keyInt = (int)ch;
            if ((keyInt < 48 || keyInt > 57) && keyInt != 8)
                return false;
            else
                return true;
        }

        /// <summary> method: txtXpos_KeyPress
        /// allow only numbers and backspace key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtXpos_KeyPress(object sender, KeyPressEventArgs e)
        {
                
            if (CheckForNumeric(e.KeyChar) == false)
                e.Handled = true;
        }
               
    }
}

