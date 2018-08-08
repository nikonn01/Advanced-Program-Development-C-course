namespace Assignment1B
{
    partial class View1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlShapePlayground1 = new ctlSvgPlayground.ctlShapePlayground();
            this.SuspendLayout();
            // 
            // ctlShapePlayground1
            // 
            this.ctlShapePlayground1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlShapePlayground1.BackColor = System.Drawing.Color.White;
            this.ctlShapePlayground1.Editable = false;
            this.ctlShapePlayground1.Location = new System.Drawing.Point(13, 13);
            this.ctlShapePlayground1.Name = "ctlShapePlayground1";
            this.ctlShapePlayground1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ctlShapePlayground1.Size = new System.Drawing.Size(800, 600);
            this.ctlShapePlayground1.TabIndex = 0;
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 625);
            this.Controls.Add(this.ctlShapePlayground1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "View1";
            this.Text = "View 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlSvgPlayground.ctlShapePlayground ctlShapePlayground1;
    }
}