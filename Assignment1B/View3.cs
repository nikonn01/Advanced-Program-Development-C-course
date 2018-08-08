// --------------------------------------------------------------------------------------------------------------------
// <copyright file="View3.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the View3 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace Assignment1B
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using ctlSvgPlayground.Controller;
    using ctlSvgPlayground.Model;

    /// <summary>
    /// The view 3.
    /// </summary>
    public partial class View3 : Form, IViewUpdate
    {
        /// <summary>
        /// The view controller.
        /// </summary>
        private readonly IViewController viewController;

        /// <summary>
        /// The shape list.
        /// </summary>
        private readonly ShapeList shapeList;

        /// <summary>
        /// The check coordinates.
        /// </summary>
        private bool checkCoordinates = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="View3"/> class.
        /// </summary>
        /// <param name="controller">
        /// The controller.
        /// </param>
        public View3(IViewController controller)
        {
            shapeList = (ShapeList)controller.GetModel();
            this.viewController = controller;

            InitializeComponent();

        }

        /// <summary>
        /// The update view.
        /// </summary>
        public void UpdateView()
        {
            listBox1.Items.Clear();
            int i = 0;
            List<IShape> bufShapeList = this.shapeList.ToList();
            IShape active = this.shapeList.GetActive();
            foreach (IShape shape in bufShapeList)
            {
                string data = "Shape: " + shape.ToString + ", X:" + shape.translateX + ", Y:" + shape.translateY + ", Color:" + shape.color + ", Message: " + shape.Message;

                //string data = shape.Id.ToString();
                listBox1.Items.Add(data);
                if (shape.Active)
                {
                    listBox1.SetSelected(i, true);
                    break;
                }
                i++;
            }
        }

        /// <summary>
        /// The view 3_ form closing.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void View3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.viewController.DeleteView(this);
        }

        /// <summary>
        /// The lbl select color_ click.
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
        private bool CheckCoordinates(int x, int y)
        {
            int X = this.Width;
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
        /// The btn new shape_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btnNewShape_Click(object sender, EventArgs e)
        {
            if ((txtXcoordinate.Text.ToString() == "") ||
                 (txtYcoordinate.Text.ToString() == "") ||
                 (cmbIShape.Text.ToString() == ""))
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
                }
            }

            this.viewController.UpdateViews();
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

        /// <summary>
        /// The list box 1_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void listBox1_Click(object sender, EventArgs e)
        {
            int ii = 0;
            int n = listBox1.SelectedIndex;
            List<IShape> bufShapeList = this.shapeList.ToList();
            foreach (IShape shape in bufShapeList)
            {
                if (ii == n)
                {
                    this.shapeList.SetActive(shape);
                    break;
                }

                ii++;
            }

            this.viewController.UpdateViews();
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
