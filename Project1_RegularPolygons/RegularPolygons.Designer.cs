namespace Project1_RegularPolygons
{
    partial class RegularPolygons
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularPolygons));
            this.mnuPolygons = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberSides = new System.Windows.Forms.Label();
            this.lblLengthSides = new System.Windows.Forms.Label();
            this.lblInteriorAngle = new System.Windows.Forms.Label();
            this.lblCircumradius = new System.Windows.Forms.Label();
            this.lblApothem = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCircCirc = new System.Windows.Forms.Label();
            this.lblAreaCirc = new System.Windows.Forms.Label();
            this.lblErrorPerimeter = new System.Windows.Forms.Label();
            this.lblErrorArea = new System.Windows.Forms.Label();
            this.lblCtrAngle = new System.Windows.Forms.Label();
            this.lblDiagonals = new System.Windows.Forms.Label();
            this.txtNumberSides = new System.Windows.Forms.TextBox();
            this.txtLengthSides = new System.Windows.Forms.TextBox();
            this.txtIntAngle = new System.Windows.Forms.TextBox();
            this.txtCircumradius = new System.Windows.Forms.TextBox();
            this.txtApothem = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtCircCirc = new System.Windows.Forms.TextBox();
            this.txtCircArea = new System.Windows.Forms.TextBox();
            this.txtErrorPerimeter = new System.Windows.Forms.TextBox();
            this.txtErrorArea = new System.Windows.Forms.TextBox();
            this.txtCtrAngle = new System.Windows.Forms.TextBox();
            this.txtDiagonals = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ttpPolygons = new System.Windows.Forms.ToolTip(this.components);
            this.pdPolygons = new System.Drawing.Printing.PrintDocument();
            this.ppdPolygons = new System.Windows.Forms.PrintPreviewDialog();
            this.picPoly = new System.Windows.Forms.PictureBox();
            this.lblPrecision = new System.Windows.Forms.Label();
            this.cboPrecision = new System.Windows.Forms.ComboBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.mnuPolygons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPolygons
            // 
            this.mnuPolygons.BackColor = System.Drawing.Color.MediumAquamarine;
            this.mnuPolygons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuPolygons.Location = new System.Drawing.Point(0, 0);
            this.mnuPolygons.Name = "mnuPolygons";
            this.mnuPolygons.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuPolygons.Size = new System.Drawing.Size(884, 25);
            this.mnuPolygons.TabIndex = 7;
            this.mnuPolygons.Text = "menuStrip2";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileClear,
            this.mnuFilePrint,
            this.mnuFileExit});
            this.mnuFile.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(39, 21);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileClear
            // 
            this.mnuFileClear.Name = "mnuFileClear";
            this.mnuFileClear.Size = new System.Drawing.Size(103, 22);
            this.mnuFileClear.Text = "C&lear";
            this.mnuFileClear.Click += new System.EventHandler(this.mnuFileClear_Click);
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.Size = new System.Drawing.Size(103, 22);
            this.mnuFilePrint.Text = "&Print";
            this.mnuFilePrint.ToolTipText = "Print form as GUI";
            this.mnuFilePrint.Click += new System.EventHandler(this.mnuFilePrint_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(103, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Font = new System.Drawing.Font("Calibri", 10F);
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(46, 21);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // lblNumberSides
            // 
            this.lblNumberSides.AutoSize = true;
            this.lblNumberSides.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberSides.Location = new System.Drawing.Point(362, 52);
            this.lblNumberSides.Name = "lblNumberSides";
            this.lblNumberSides.Size = new System.Drawing.Size(119, 19);
            this.lblNumberSides.TabIndex = 2;
            this.lblNumberSides.Text = "Number of sides:";
            // 
            // lblLengthSides
            // 
            this.lblLengthSides.AutoSize = true;
            this.lblLengthSides.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthSides.Location = new System.Drawing.Point(362, 83);
            this.lblLengthSides.Name = "lblLengthSides";
            this.lblLengthSides.Size = new System.Drawing.Size(140, 19);
            this.lblLengthSides.TabIndex = 3;
            this.lblLengthSides.Text = "Length of each side:";
            // 
            // lblInteriorAngle
            // 
            this.lblInteriorAngle.AutoSize = true;
            this.lblInteriorAngle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteriorAngle.Location = new System.Drawing.Point(362, 145);
            this.lblInteriorAngle.Name = "lblInteriorAngle";
            this.lblInteriorAngle.Size = new System.Drawing.Size(211, 19);
            this.lblInteriorAngle.TabIndex = 4;
            this.lblInteriorAngle.Text = "Measurement of interior angle:";
            // 
            // lblCircumradius
            // 
            this.lblCircumradius.AutoSize = true;
            this.lblCircumradius.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumradius.Location = new System.Drawing.Point(362, 176);
            this.lblCircumradius.Name = "lblCircumradius";
            this.lblCircumradius.Size = new System.Drawing.Size(98, 19);
            this.lblCircumradius.TabIndex = 5;
            this.lblCircumradius.Text = "Circumradius:";
            // 
            // lblApothem
            // 
            this.lblApothem.AutoSize = true;
            this.lblApothem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApothem.Location = new System.Drawing.Point(362, 207);
            this.lblApothem.Name = "lblApothem";
            this.lblApothem.Size = new System.Drawing.Size(71, 19);
            this.lblApothem.TabIndex = 6;
            this.lblApothem.Text = "Apothem:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(362, 238);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(148, 19);
            this.lblPerimeter.TabIndex = 7;
            this.lblPerimeter.Text = "Perimeter of polygon:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(362, 269);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(115, 19);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area of polygon:";
            // 
            // lblCircCirc
            // 
            this.lblCircCirc.AutoSize = true;
            this.lblCircCirc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircCirc.Location = new System.Drawing.Point(362, 300);
            this.lblCircCirc.Name = "lblCircCirc";
            this.lblCircCirc.Size = new System.Drawing.Size(206, 19);
            this.lblCircCirc.TabIndex = 9;
            this.lblCircCirc.Text = "Circumference of circumcircle:";
            // 
            // lblAreaCirc
            // 
            this.lblAreaCirc.AutoSize = true;
            this.lblAreaCirc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaCirc.Location = new System.Drawing.Point(362, 331);
            this.lblAreaCirc.Name = "lblAreaCirc";
            this.lblAreaCirc.Size = new System.Drawing.Size(142, 19);
            this.lblAreaCirc.TabIndex = 10;
            this.lblAreaCirc.Text = "Area of circumcircle:";
            // 
            // lblErrorPerimeter
            // 
            this.lblErrorPerimeter.AutoSize = true;
            this.lblErrorPerimeter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPerimeter.Location = new System.Drawing.Point(362, 362);
            this.lblErrorPerimeter.Name = "lblErrorPerimeter";
            this.lblErrorPerimeter.Size = new System.Drawing.Size(152, 19);
            this.lblErrorPerimeter.TabIndex = 11;
            this.lblErrorPerimeter.Text = "Error in perimeter (%):";
            // 
            // lblErrorArea
            // 
            this.lblErrorArea.AutoSize = true;
            this.lblErrorArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorArea.Location = new System.Drawing.Point(362, 393);
            this.lblErrorArea.Name = "lblErrorArea";
            this.lblErrorArea.Size = new System.Drawing.Size(118, 19);
            this.lblErrorArea.TabIndex = 12;
            this.lblErrorArea.Text = "Error in area (%):";
            // 
            // lblCtrAngle
            // 
            this.lblCtrAngle.AutoSize = true;
            this.lblCtrAngle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtrAngle.Location = new System.Drawing.Point(362, 424);
            this.lblCtrAngle.Name = "lblCtrAngle";
            this.lblCtrAngle.Size = new System.Drawing.Size(209, 19);
            this.lblCtrAngle.TabIndex = 13;
            this.lblCtrAngle.Text = "Measurement of central angle:";
            // 
            // lblDiagonals
            // 
            this.lblDiagonals.AutoSize = true;
            this.lblDiagonals.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonals.Location = new System.Drawing.Point(362, 455);
            this.lblDiagonals.Name = "lblDiagonals";
            this.lblDiagonals.Size = new System.Drawing.Size(200, 19);
            this.lblDiagonals.TabIndex = 14;
            this.lblDiagonals.Text = "Number of distinct diagonals:";
            // 
            // txtNumberSides
            // 
            this.txtNumberSides.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberSides.Location = new System.Drawing.Point(597, 49);
            this.txtNumberSides.Name = "txtNumberSides";
            this.txtNumberSides.Size = new System.Drawing.Size(260, 27);
            this.txtNumberSides.TabIndex = 0;
            this.ttpPolygons.SetToolTip(this.txtNumberSides, "Enter number between 3 and 1,000,000");
            // 
            // txtLengthSides
            // 
            this.txtLengthSides.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLengthSides.Location = new System.Drawing.Point(597, 80);
            this.txtLengthSides.Name = "txtLengthSides";
            this.txtLengthSides.Size = new System.Drawing.Size(260, 27);
            this.txtLengthSides.TabIndex = 1;
            this.ttpPolygons.SetToolTip(this.txtLengthSides, "Enter number > 0 <= 1,000,000");
            // 
            // txtIntAngle
            // 
            this.txtIntAngle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntAngle.Location = new System.Drawing.Point(597, 142);
            this.txtIntAngle.Name = "txtIntAngle";
            this.txtIntAngle.ReadOnly = true;
            this.txtIntAngle.Size = new System.Drawing.Size(260, 27);
            this.txtIntAngle.TabIndex = 17;
            // 
            // txtCircumradius
            // 
            this.txtCircumradius.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCircumradius.Location = new System.Drawing.Point(597, 173);
            this.txtCircumradius.Name = "txtCircumradius";
            this.txtCircumradius.ReadOnly = true;
            this.txtCircumradius.Size = new System.Drawing.Size(260, 27);
            this.txtCircumradius.TabIndex = 18;
            // 
            // txtApothem
            // 
            this.txtApothem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApothem.Location = new System.Drawing.Point(597, 204);
            this.txtApothem.Name = "txtApothem";
            this.txtApothem.ReadOnly = true;
            this.txtApothem.Size = new System.Drawing.Size(260, 27);
            this.txtApothem.TabIndex = 19;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimeter.Location = new System.Drawing.Point(597, 235);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(260, 27);
            this.txtPerimeter.TabIndex = 20;
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(597, 266);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(260, 27);
            this.txtArea.TabIndex = 21;
            // 
            // txtCircCirc
            // 
            this.txtCircCirc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCircCirc.Location = new System.Drawing.Point(597, 297);
            this.txtCircCirc.Name = "txtCircCirc";
            this.txtCircCirc.ReadOnly = true;
            this.txtCircCirc.Size = new System.Drawing.Size(260, 27);
            this.txtCircCirc.TabIndex = 22;
            // 
            // txtCircArea
            // 
            this.txtCircArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCircArea.Location = new System.Drawing.Point(597, 328);
            this.txtCircArea.Name = "txtCircArea";
            this.txtCircArea.ReadOnly = true;
            this.txtCircArea.Size = new System.Drawing.Size(260, 27);
            this.txtCircArea.TabIndex = 23;
            // 
            // txtErrorPerimeter
            // 
            this.txtErrorPerimeter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorPerimeter.Location = new System.Drawing.Point(597, 359);
            this.txtErrorPerimeter.Name = "txtErrorPerimeter";
            this.txtErrorPerimeter.ReadOnly = true;
            this.txtErrorPerimeter.Size = new System.Drawing.Size(260, 27);
            this.txtErrorPerimeter.TabIndex = 24;
            // 
            // txtErrorArea
            // 
            this.txtErrorArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorArea.Location = new System.Drawing.Point(597, 390);
            this.txtErrorArea.Name = "txtErrorArea";
            this.txtErrorArea.ReadOnly = true;
            this.txtErrorArea.Size = new System.Drawing.Size(260, 27);
            this.txtErrorArea.TabIndex = 25;
            // 
            // txtCtrAngle
            // 
            this.txtCtrAngle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtrAngle.Location = new System.Drawing.Point(597, 421);
            this.txtCtrAngle.Name = "txtCtrAngle";
            this.txtCtrAngle.ReadOnly = true;
            this.txtCtrAngle.Size = new System.Drawing.Size(260, 27);
            this.txtCtrAngle.TabIndex = 26;
            // 
            // txtDiagonals
            // 
            this.txtDiagonals.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagonals.Location = new System.Drawing.Point(597, 452);
            this.txtDiagonals.Name = "txtDiagonals";
            this.txtDiagonals.ReadOnly = true;
            this.txtDiagonals.Size = new System.Drawing.Size(260, 27);
            this.txtDiagonals.TabIndex = 27;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ink Free", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 39);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Regular Polygons";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(53, 502);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 35);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(395, 502);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(566, 502);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 35);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "P&rint";
            this.ttpPolygons.SetToolTip(this.btnPrint, "Print form as GUI");
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(737, 502);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pdPolygons
            // 
            this.pdPolygons.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPolygons_PrintPage);
            // 
            // ppdPolygons
            // 
            this.ppdPolygons.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdPolygons.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdPolygons.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdPolygons.Document = this.pdPolygons;
            this.ppdPolygons.Enabled = true;
            this.ppdPolygons.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdPolygons.Icon")));
            this.ppdPolygons.Name = "ppdPolygons";
            this.ppdPolygons.Visible = false;
            // 
            // picPoly
            // 
            this.picPoly.Image = ((System.Drawing.Image)(resources.GetObject("picPoly.Image")));
            this.picPoly.Location = new System.Drawing.Point(22, 108);
            this.picPoly.Name = "picPoly";
            this.picPoly.Size = new System.Drawing.Size(320, 320);
            this.picPoly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPoly.TabIndex = 33;
            this.picPoly.TabStop = false;
            // 
            // lblPrecision
            // 
            this.lblPrecision.AutoSize = true;
            this.lblPrecision.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecision.Location = new System.Drawing.Point(362, 114);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(199, 19);
            this.lblPrecision.TabIndex = 34;
            this.lblPrecision.Text = "Precision (in decimal places):";
            // 
            // cboPrecision
            // 
            this.cboPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrecision.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrecision.FormattingEnabled = true;
            this.cboPrecision.Items.AddRange(new object[] {
            "Default",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.cboPrecision.Location = new System.Drawing.Point(597, 111);
            this.cboPrecision.MinimumSize = new System.Drawing.Size(170, 0);
            this.cboPrecision.Name = "cboPrecision";
            this.cboPrecision.Size = new System.Drawing.Size(260, 27);
            this.cboPrecision.TabIndex = 2;
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDraw.Enabled = false;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(224, 502);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 35);
            this.btnDraw.TabIndex = 36;
            this.btnDraw.Text = "&Draw";
            this.ttpPolygons.SetToolTip(this.btnDraw, "Draw polygon up to 100 sides");
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // picDraw
            // 
            this.picDraw.Location = new System.Drawing.Point(22, 108);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(320, 320);
            this.picDraw.TabIndex = 37;
            this.picDraw.TabStop = false;
            // 
            // RegularPolygons
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.cboPrecision);
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.picPoly);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDiagonals);
            this.Controls.Add(this.txtCtrAngle);
            this.Controls.Add(this.txtErrorArea);
            this.Controls.Add(this.txtErrorPerimeter);
            this.Controls.Add(this.txtCircArea);
            this.Controls.Add(this.txtCircCirc);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.txtApothem);
            this.Controls.Add(this.txtCircumradius);
            this.Controls.Add(this.txtIntAngle);
            this.Controls.Add(this.txtLengthSides);
            this.Controls.Add(this.txtNumberSides);
            this.Controls.Add(this.lblDiagonals);
            this.Controls.Add(this.lblCtrAngle);
            this.Controls.Add(this.lblErrorArea);
            this.Controls.Add(this.lblErrorPerimeter);
            this.Controls.Add(this.lblAreaCirc);
            this.Controls.Add(this.lblCircCirc);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblApothem);
            this.Controls.Add(this.lblCircumradius);
            this.Controls.Add(this.lblInteriorAngle);
            this.Controls.Add(this.lblLengthSides);
            this.Controls.Add(this.lblNumberSides);
            this.Controls.Add(this.mnuPolygons);
            this.Controls.Add(this.picDraw);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegularPolygons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mnuPolygons.ResumeLayout(false);
            this.mnuPolygons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPolygons;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClear;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.Label lblNumberSides;
        private System.Windows.Forms.Label lblLengthSides;
        private System.Windows.Forms.Label lblInteriorAngle;
        private System.Windows.Forms.Label lblCircumradius;
        private System.Windows.Forms.Label lblApothem;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCircCirc;
        private System.Windows.Forms.Label lblAreaCirc;
        private System.Windows.Forms.Label lblErrorPerimeter;
        private System.Windows.Forms.Label lblErrorArea;
        private System.Windows.Forms.Label lblCtrAngle;
        private System.Windows.Forms.Label lblDiagonals;
        private System.Windows.Forms.TextBox txtNumberSides;
        private System.Windows.Forms.TextBox txtLengthSides;
        private System.Windows.Forms.TextBox txtIntAngle;
        private System.Windows.Forms.TextBox txtCircumradius;
        private System.Windows.Forms.TextBox txtApothem;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtCircCirc;
        private System.Windows.Forms.TextBox txtCircArea;
        private System.Windows.Forms.TextBox txtErrorPerimeter;
        private System.Windows.Forms.TextBox txtErrorArea;
        private System.Windows.Forms.TextBox txtCtrAngle;
        private System.Windows.Forms.TextBox txtDiagonals;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip ttpPolygons;
        private System.Drawing.Printing.PrintDocument pdPolygons;
        private System.Windows.Forms.PrintPreviewDialog ppdPolygons;
        private System.Windows.Forms.PictureBox picPoly;
        private System.Windows.Forms.Label lblPrecision;
        private System.Windows.Forms.ComboBox cboPrecision;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox picDraw;
    }
}

