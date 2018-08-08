// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Form1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace Assignment1B
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using ctlSvgPlayground.Controller;
    using ctlSvgPlayground.Model;

    public partial class Form1 : Form
    {
        /// <summary>
        /// The global shapes view controller.
        /// </summary>
        private readonly ShapesViewController shapesViewController;

        /// <summary>
        /// The view form 1.
        /// </summary>
        private View1 viewForm1;

        /// <summary>
        /// The view form 2.
        /// </summary>
        private View2 viewForm2;

        /// <summary>
        /// The view form 3.
        /// </summary>
        private View3 viewForm3;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.shapesViewController = new ShapesViewController();
        }

        /// <summary>
        /// The btn new_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            // make views
            this.viewForm1 = new View1(this.shapesViewController);
            this.viewForm2 = new View2(this.shapesViewController);
            this.viewForm3 = new View3(this.shapesViewController);


            //show views
            this.viewForm3.Show();
            this.viewForm2.Show();
            this.viewForm1.Show();

            this.shapesViewController.AddView(this.viewForm2);
            this.shapesViewController.AddView(this.viewForm1);
            this.shapesViewController.AddView(this.viewForm3);
            this.shapesViewController.UpdateViews();
        }

        /// <summary>
        /// The btn save_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + @"\data.dat";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    ((ShapeList)this.shapesViewController.GetModel()).SaveCollections(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: could not write data file. Original message: " + ex.Message);
                return;
            }

            MessageBox.Show($"File {path} is saved");
        }

        /// <summary>
        /// The btn load_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + @"\data.dat";
            if (!File.Exists(path))
            {
                MessageBox.Show($"File {path} not found");
            }
            else
            {
                try
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        ((ShapeList)this.shapesViewController.GetModel()).LoadCollections(fs);
                    }

                    this.shapesViewController.UpdateViews();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: could not load data file. Original error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// The btn exit_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
