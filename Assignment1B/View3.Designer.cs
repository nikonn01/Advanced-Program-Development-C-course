namespace Assignment1B
{
    partial class View3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNewShape = new System.Windows.Forms.Button();
            this.gbpShapeCoordintes = new System.Windows.Forms.GroupBox();
            this.txtYcoordinate = new System.Windows.Forms.TextBox();
            this.txtXcoordinate = new System.Windows.Forms.TextBox();
            this.lblXcoordinate = new System.Windows.Forms.Label();
            this.lblYcoordinate = new System.Windows.Forms.Label();
            this.gpbShapeColor = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectColor = new System.Windows.Forms.Label();
            this.gpbIShape = new System.Windows.Forms.GroupBox();
            this.cmbIShape = new System.Windows.Forms.ComboBox();
            this.btnUpdateShape = new System.Windows.Forms.Button();
            this.btnDeleteShape = new System.Windows.Forms.Button();
            this.gbpShapeCoordintes.SuspendLayout();
            this.gpbShapeColor.SuspendLayout();
            this.gpbIShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(20, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(969, 464);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // btnNewShape
            // 
            this.btnNewShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewShape.Location = new System.Drawing.Point(1026, 529);
            this.btnNewShape.Name = "btnNewShape";
            this.btnNewShape.Size = new System.Drawing.Size(152, 37);
            this.btnNewShape.TabIndex = 10;
            this.btnNewShape.Text = "New Shape ";
            this.btnNewShape.UseVisualStyleBackColor = true;
            this.btnNewShape.Click += new System.EventHandler(this.btnNewShape_Click);
            // 
            // gbpShapeCoordintes
            // 
            this.gbpShapeCoordintes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbpShapeCoordintes.Controls.Add(this.txtYcoordinate);
            this.gbpShapeCoordintes.Controls.Add(this.txtXcoordinate);
            this.gbpShapeCoordintes.Controls.Add(this.lblXcoordinate);
            this.gbpShapeCoordintes.Controls.Add(this.lblYcoordinate);
            this.gbpShapeCoordintes.Location = new System.Drawing.Point(21, 516);
            this.gbpShapeCoordintes.Name = "gbpShapeCoordintes";
            this.gbpShapeCoordintes.Size = new System.Drawing.Size(332, 131);
            this.gbpShapeCoordintes.TabIndex = 13;
            this.gbpShapeCoordintes.TabStop = false;
            this.gbpShapeCoordintes.Text = "Shape Coordinates";
            // 
            // txtYcoordinate
            // 
            this.txtYcoordinate.Location = new System.Drawing.Point(6, 91);
            this.txtYcoordinate.Name = "txtYcoordinate";
            this.txtYcoordinate.Size = new System.Drawing.Size(158, 26);
            this.txtYcoordinate.TabIndex = 1;
            this.txtYcoordinate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXpos_KeyPress);
            // 
            // txtXcoordinate
            // 
            this.txtXcoordinate.Location = new System.Drawing.Point(6, 35);
            this.txtXcoordinate.Name = "txtXcoordinate";
            this.txtXcoordinate.Size = new System.Drawing.Size(158, 26);
            this.txtXcoordinate.TabIndex = 0;
            this.txtXcoordinate.Text = " ";
            this.txtXcoordinate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXpos_KeyPress);
            // 
            // lblXcoordinate
            // 
            this.lblXcoordinate.AutoSize = true;
            this.lblXcoordinate.Location = new System.Drawing.Point(189, 42);
            this.lblXcoordinate.Name = "lblXcoordinate";
            this.lblXcoordinate.Size = new System.Drawing.Size(119, 20);
            this.lblXcoordinate.TabIndex = 2;
            this.lblXcoordinate.Text = "X Start Position";
            // 
            // lblYcoordinate
            // 
            this.lblYcoordinate.AutoSize = true;
            this.lblYcoordinate.Location = new System.Drawing.Point(189, 91);
            this.lblYcoordinate.Name = "lblYcoordinate";
            this.lblYcoordinate.Size = new System.Drawing.Size(119, 20);
            this.lblYcoordinate.TabIndex = 5;
            this.lblYcoordinate.Text = "Y Start Position";
            // 
            // gpbShapeColor
            // 
            this.gpbShapeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbShapeColor.Controls.Add(this.label34);
            this.gpbShapeColor.Controls.Add(this.label33);
            this.gpbShapeColor.Controls.Add(this.label32);
            this.gpbShapeColor.Controls.Add(this.label31);
            this.gpbShapeColor.Controls.Add(this.label30);
            this.gpbShapeColor.Controls.Add(this.label29);
            this.gpbShapeColor.Controls.Add(this.label28);
            this.gpbShapeColor.Controls.Add(this.label27);
            this.gpbShapeColor.Controls.Add(this.label26);
            this.gpbShapeColor.Controls.Add(this.label25);
            this.gpbShapeColor.Controls.Add(this.label24);
            this.gpbShapeColor.Controls.Add(this.label23);
            this.gpbShapeColor.Controls.Add(this.label22);
            this.gpbShapeColor.Controls.Add(this.label21);
            this.gpbShapeColor.Controls.Add(this.label20);
            this.gpbShapeColor.Controls.Add(this.label19);
            this.gpbShapeColor.Controls.Add(this.label18);
            this.gpbShapeColor.Controls.Add(this.label17);
            this.gpbShapeColor.Controls.Add(this.label16);
            this.gpbShapeColor.Controls.Add(this.label15);
            this.gpbShapeColor.Controls.Add(this.label14);
            this.gpbShapeColor.Controls.Add(this.label13);
            this.gpbShapeColor.Controls.Add(this.label12);
            this.gpbShapeColor.Controls.Add(this.label11);
            this.gpbShapeColor.Controls.Add(this.label10);
            this.gpbShapeColor.Controls.Add(this.label9);
            this.gpbShapeColor.Controls.Add(this.label8);
            this.gpbShapeColor.Controls.Add(this.label7);
            this.gpbShapeColor.Controls.Add(this.label6);
            this.gpbShapeColor.Controls.Add(this.label5);
            this.gpbShapeColor.Controls.Add(this.label4);
            this.gpbShapeColor.Controls.Add(this.label3);
            this.gpbShapeColor.Controls.Add(this.label2);
            this.gpbShapeColor.Controls.Add(this.label1);
            this.gpbShapeColor.Controls.Add(this.lblSelectColor);
            this.gpbShapeColor.Location = new System.Drawing.Point(681, 516);
            this.gpbShapeColor.Name = "gpbShapeColor";
            this.gpbShapeColor.Size = new System.Drawing.Size(308, 145);
            this.gpbShapeColor.TabIndex = 12;
            this.gpbShapeColor.TabStop = false;
            this.gpbShapeColor.Text = "Shape Color";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(46, 122);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(113, 20);
            this.label34.TabIndex = 34;
            this.label34.Text = "Selected Color";
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Silver;
            this.label33.Location = new System.Drawing.Point(6, 29);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(20, 20);
            this.label33.TabIndex = 33;
            this.label33.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Bisque;
            this.label32.Location = new System.Drawing.Point(268, 91);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(20, 20);
            this.label32.TabIndex = 32;
            this.label32.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Thistle;
            this.label31.Location = new System.Drawing.Point(242, 91);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 20);
            this.label31.TabIndex = 31;
            this.label31.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label30.Location = new System.Drawing.Point(216, 91);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 20);
            this.label30.TabIndex = 30;
            this.label30.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.MistyRose;
            this.label29.Location = new System.Drawing.Point(190, 91);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(20, 20);
            this.label29.TabIndex = 29;
            this.label29.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.SpringGreen;
            this.label28.Location = new System.Drawing.Point(164, 91);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(20, 20);
            this.label28.TabIndex = 28;
            this.label28.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.BlueViolet;
            this.label27.Location = new System.Drawing.Point(138, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 20);
            this.label27.TabIndex = 27;
            this.label27.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Indigo;
            this.label26.Location = new System.Drawing.Point(112, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(20, 20);
            this.label26.TabIndex = 26;
            this.label26.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label25.Location = new System.Drawing.Point(86, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 20);
            this.label25.TabIndex = 25;
            this.label25.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Brown;
            this.label24.Location = new System.Drawing.Point(60, 91);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 20);
            this.label24.TabIndex = 24;
            this.label24.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Gainsboro;
            this.label23.Location = new System.Drawing.Point(34, 91);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 20);
            this.label23.TabIndex = 23;
            this.label23.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label22.Location = new System.Drawing.Point(8, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 20);
            this.label22.TabIndex = 22;
            this.label22.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.DeepPink;
            this.label21.Location = new System.Drawing.Point(268, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 20);
            this.label21.TabIndex = 21;
            this.label21.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.SlateBlue;
            this.label20.Location = new System.Drawing.Point(242, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 20);
            this.label20.TabIndex = 20;
            this.label20.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Salmon;
            this.label19.Location = new System.Drawing.Point(216, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 20);
            this.label19.TabIndex = 19;
            this.label19.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(190, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 20);
            this.label18.TabIndex = 18;
            this.label18.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.MintCream;
            this.label17.Location = new System.Drawing.Point(164, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 20);
            this.label17.TabIndex = 17;
            this.label17.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(138, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 20);
            this.label16.TabIndex = 16;
            this.label16.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.DarkMagenta;
            this.label15.Location = new System.Drawing.Point(112, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 20);
            this.label15.TabIndex = 15;
            this.label15.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Plum;
            this.label14.Location = new System.Drawing.Point(86, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 20);
            this.label14.TabIndex = 14;
            this.label14.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(60, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 20);
            this.label13.TabIndex = 13;
            this.label13.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.NavajoWhite;
            this.label12.Location = new System.Drawing.Point(34, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 20);
            this.label12.TabIndex = 12;
            this.label12.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(8, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 20);
            this.label11.TabIndex = 11;
            this.label11.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(268, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 20);
            this.label10.TabIndex = 10;
            this.label10.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(242, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 20);
            this.label9.TabIndex = 9;
            this.label9.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(216, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 8;
            this.label8.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(190, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 7;
            this.label7.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(164, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 6;
            this.label6.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Location = new System.Drawing.Point(138, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 5;
            this.label5.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(112, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 4;
            this.label4.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(86, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(60, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // lblSelectColor
            // 
            this.lblSelectColor.BackColor = System.Drawing.Color.Black;
            this.lblSelectColor.Location = new System.Drawing.Point(8, 122);
            this.lblSelectColor.Name = "lblSelectColor";
            this.lblSelectColor.Size = new System.Drawing.Size(20, 20);
            this.lblSelectColor.TabIndex = 0;
            // 
            // gpbIShape
            // 
            this.gpbIShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbIShape.Controls.Add(this.cmbIShape);
            this.gpbIShape.Location = new System.Drawing.Point(377, 516);
            this.gpbIShape.Name = "gpbIShape";
            this.gpbIShape.Size = new System.Drawing.Size(262, 131);
            this.gpbIShape.TabIndex = 11;
            this.gpbIShape.TabStop = false;
            this.gpbIShape.Text = "Shape Type";
            // 
            // cmbIShape
            // 
            this.cmbIShape.FormattingEnabled = true;
            this.cmbIShape.Items.AddRange(new object[] {
            "Plane Shape",
            "Helicopter Shape",
            "Cloud Shape"});
            this.cmbIShape.Location = new System.Drawing.Point(6, 37);
            this.cmbIShape.Name = "cmbIShape";
            this.cmbIShape.Size = new System.Drawing.Size(218, 28);
            this.cmbIShape.TabIndex = 2;
            // 
            // btnUpdateShape
            // 
            this.btnUpdateShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateShape.Location = new System.Drawing.Point(1026, 578);
            this.btnUpdateShape.Name = "btnUpdateShape";
            this.btnUpdateShape.Size = new System.Drawing.Size(152, 37);
            this.btnUpdateShape.TabIndex = 14;
            this.btnUpdateShape.Text = "Update Shape";
            this.btnUpdateShape.UseVisualStyleBackColor = true;
            this.btnUpdateShape.Click += new System.EventHandler(this.btnUpdateShape_Click);
            // 
            // btnDeleteShape
            // 
            this.btnDeleteShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteShape.Location = new System.Drawing.Point(1026, 624);
            this.btnDeleteShape.Name = "btnDeleteShape";
            this.btnDeleteShape.Size = new System.Drawing.Size(152, 37);
            this.btnDeleteShape.TabIndex = 14;
            this.btnDeleteShape.Text = "Delete";
            this.btnDeleteShape.UseVisualStyleBackColor = true;
            this.btnDeleteShape.Click += new System.EventHandler(this.btnDeleteShape_Click);
            // 
            // View3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 694);
            this.Controls.Add(this.btnDeleteShape);
            this.Controls.Add(this.btnUpdateShape);
            this.Controls.Add(this.btnNewShape);
            this.Controls.Add(this.gbpShapeCoordintes);
            this.Controls.Add(this.gpbShapeColor);
            this.Controls.Add(this.gpbIShape);
            this.Controls.Add(this.listBox1);
            this.Name = "View3";
            this.Text = "View 3";
            this.gbpShapeCoordintes.ResumeLayout(false);
            this.gbpShapeCoordintes.PerformLayout();
            this.gpbShapeColor.ResumeLayout(false);
            this.gpbShapeColor.PerformLayout();
            this.gpbIShape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNewShape;
        private System.Windows.Forms.GroupBox gbpShapeCoordintes;
        private System.Windows.Forms.TextBox txtYcoordinate;
        private System.Windows.Forms.TextBox txtXcoordinate;
        private System.Windows.Forms.Label lblXcoordinate;
        private System.Windows.Forms.Label lblYcoordinate;
        private System.Windows.Forms.GroupBox gpbShapeColor;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblSelectColor;
        private System.Windows.Forms.GroupBox gpbIShape;
        private System.Windows.Forms.ComboBox cmbIShape;
        private System.Windows.Forms.Button btnUpdateShape;
        private System.Windows.Forms.Button btnDeleteShape;
    }
}