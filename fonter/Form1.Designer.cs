namespace fonter
{
    partial class Form1
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
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.nudCell = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.chkDB = new System.Windows.Forms.CheckBox();
            this.rdbZeroX = new System.Windows.Forms.RadioButton();
            this.rdbDollar = new System.Windows.Forms.RadioButton();
            this.nudDataWidth = new System.Windows.Forms.NumericUpDown();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClipAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbOrigin = new System.Windows.Forms.GroupBox();
            this.rdbHXY = new System.Windows.Forms.RadioButton();
            this.rdbTLY07R = new System.Windows.Forms.RadioButton();
            this.rdbTLX40 = new System.Windows.Forms.RadioButton();
            this.rdbTLY07 = new System.Windows.Forms.RadioButton();
            this.chkBitmap = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataWidth)).BeginInit();
            this.grbOrigin.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudWidth
            // 
            this.nudWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWidth.Location = new System.Drawing.Point(668, 160);
            this.nudWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudWidth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 26);
            this.nudWidth.TabIndex = 0;
            this.nudWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // nudHeight
            // 
            this.nudHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHeight.Location = new System.Drawing.Point(668, 220);
            this.nudHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudHeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 26);
            this.nudHeight.TabIndex = 1;
            this.nudHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(663, 135);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(50, 20);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(663, 195);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(56, 20);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(456, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 26);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(452, 14);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Set";
            // 
            // lblCell
            // 
            this.lblCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(663, 255);
            this.lblCell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(35, 20);
            this.lblCell.TabIndex = 7;
            this.lblCell.Text = "Cell";
            // 
            // nudCell
            // 
            this.nudCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCell.Location = new System.Drawing.Point(668, 280);
            this.nudCell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCell.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCell.Name = "nudCell";
            this.nudCell.Size = new System.Drawing.Size(120, 26);
            this.nudCell.TabIndex = 6;
            this.nudCell.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudCell.ValueChanged += new System.EventHandler(this.nudCell_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(668, 320);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(668, 78);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 35);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(668, 365);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(688, 645);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(456, 511);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(330, 126);
            this.txtData.TabIndex = 12;
            this.txtData.WordWrap = false;
            // 
            // chkDB
            // 
            this.chkDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDB.AutoSize = true;
            this.chkDB.Location = new System.Drawing.Point(460, 477);
            this.chkDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDB.Name = "chkDB";
            this.chkDB.Size = new System.Drawing.Size(58, 24);
            this.chkDB.TabIndex = 13;
            this.chkDB.Text = "DB";
            this.chkDB.UseVisualStyleBackColor = true;
            this.chkDB.CheckedChanged += new System.EventHandler(this.chkDB_CheckedChanged);
            // 
            // rdbZeroX
            // 
            this.rdbZeroX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbZeroX.AutoSize = true;
            this.rdbZeroX.Checked = true;
            this.rdbZeroX.Location = new System.Drawing.Point(530, 477);
            this.rdbZeroX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbZeroX.Name = "rdbZeroX";
            this.rdbZeroX.Size = new System.Drawing.Size(50, 24);
            this.rdbZeroX.TabIndex = 14;
            this.rdbZeroX.TabStop = true;
            this.rdbZeroX.Text = "0x";
            this.rdbZeroX.UseVisualStyleBackColor = true;
            this.rdbZeroX.CheckedChanged += new System.EventHandler(this.rdbZeroX_CheckedChanged);
            // 
            // rdbDollar
            // 
            this.rdbDollar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDollar.AutoSize = true;
            this.rdbDollar.Location = new System.Drawing.Point(593, 477);
            this.rdbDollar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbDollar.Name = "rdbDollar";
            this.rdbDollar.Size = new System.Drawing.Size(43, 24);
            this.rdbDollar.TabIndex = 15;
            this.rdbDollar.TabStop = true;
            this.rdbDollar.Text = "$";
            this.rdbDollar.UseVisualStyleBackColor = true;
            // 
            // nudDataWidth
            // 
            this.nudDataWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDataWidth.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudDataWidth.Location = new System.Drawing.Point(668, 471);
            this.nudDataWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudDataWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudDataWidth.Name = "nudDataWidth";
            this.nudDataWidth.Size = new System.Drawing.Size(120, 26);
            this.nudDataWidth.TabIndex = 16;
            this.nudDataWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudDataWidth.ValueChanged += new System.EventHandler(this.nudDataWidth_ValueChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(513, 14);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.MinimumSize = new System.Drawing.Size(270, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(270, 20);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClipAll
            // 
            this.btnClipAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipAll.Location = new System.Drawing.Point(564, 645);
            this.btnClipAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClipAll.Name = "btnClipAll";
            this.btnClipAll.Size = new System.Drawing.Size(100, 35);
            this.btnClipAll.TabIndex = 18;
            this.btnClipAll.Text = "Clip";
            this.btnClipAll.UseVisualStyleBackColor = true;
            this.btnClipAll.Click += new System.EventHandler(this.btnClipAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(668, 409);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grbOrigin
            // 
            this.grbOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbOrigin.Controls.Add(this.rdbHXY);
            this.grbOrigin.Controls.Add(this.rdbTLY07R);
            this.grbOrigin.Controls.Add(this.rdbTLX40);
            this.grbOrigin.Controls.Add(this.rdbTLY07);
            this.grbOrigin.Location = new System.Drawing.Point(18, 612);
            this.grbOrigin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbOrigin.Name = "grbOrigin";
            this.grbOrigin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbOrigin.Size = new System.Drawing.Size(429, 68);
            this.grbOrigin.TabIndex = 20;
            this.grbOrigin.TabStop = false;
            this.grbOrigin.Text = "Origin";
            // 
            // rdbHXY
            // 
            this.rdbHXY.AutoSize = true;
            this.rdbHXY.Checked = true;
            this.rdbHXY.Location = new System.Drawing.Point(344, 29);
            this.rdbHXY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbHXY.Name = "rdbHXY";
            this.rdbHXY.Size = new System.Drawing.Size(68, 24);
            this.rdbHXY.TabIndex = 3;
            this.rdbHXY.TabStop = true;
            this.rdbHXY.Text = "HXY";
            this.rdbHXY.UseVisualStyleBackColor = true;
            this.rdbHXY.CheckedChanged += new System.EventHandler(this.rdbHXY_CheckedChanged);
            // 
            // rdbTLY07R
            // 
            this.rdbTLY07R.AutoSize = true;
            this.rdbTLY07R.Location = new System.Drawing.Point(104, 29);
            this.rdbTLY07R.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTLY07R.Name = "rdbTLY07R";
            this.rdbTLY07R.Size = new System.Drawing.Size(93, 24);
            this.rdbTLY07R.TabIndex = 2;
            this.rdbTLY07R.Text = "TLY07R";
            this.rdbTLY07R.UseVisualStyleBackColor = true;
            this.rdbTLY07R.CheckedChanged += new System.EventHandler(this.rdbTLY07R_CheckedChanged);
            // 
            // rdbTLX40
            // 
            this.rdbTLX40.AutoSize = true;
            this.rdbTLX40.Location = new System.Drawing.Point(210, 29);
            this.rdbTLX40.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTLX40.Name = "rdbTLX40";
            this.rdbTLX40.Size = new System.Drawing.Size(132, 24);
            this.rdbTLX40.TabIndex = 1;
            this.rdbTLX40.Text = "TLX40 (DOG)";
            this.rdbTLX40.UseVisualStyleBackColor = true;
            this.rdbTLX40.CheckedChanged += new System.EventHandler(this.rdbTLX40_CheckedChanged);
            // 
            // rdbTLY07
            // 
            this.rdbTLY07.AutoSize = true;
            this.rdbTLY07.Checked = true;
            this.rdbTLY07.Location = new System.Drawing.Point(9, 29);
            this.rdbTLY07.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTLY07.Name = "rdbTLY07";
            this.rdbTLY07.Size = new System.Drawing.Size(81, 24);
            this.rdbTLY07.TabIndex = 0;
            this.rdbTLY07.TabStop = true;
            this.rdbTLY07.Text = "TLY07";
            this.rdbTLY07.UseVisualStyleBackColor = true;
            this.rdbTLY07.CheckedChanged += new System.EventHandler(this.rdbTLY07_CheckedChanged);
            // 
            // chkBitmap
            // 
            this.chkBitmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBitmap.AutoSize = true;
            this.chkBitmap.Location = new System.Drawing.Point(460, 651);
            this.chkBitmap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBitmap.Name = "chkBitmap";
            this.chkBitmap.Size = new System.Drawing.Size(85, 24);
            this.chkBitmap.TabIndex = 22;
            this.chkBitmap.Text = "Bitmap";
            this.chkBitmap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 698);
            this.Controls.Add(this.chkBitmap);
            this.Controls.Add(this.grbOrigin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClipAll);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.nudDataWidth);
            this.Controls.Add(this.rdbDollar);
            this.Controls.Add(this.rdbZeroX);
            this.Controls.Add(this.chkDB);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCell);
            this.Controls.Add(this.nudCell);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWidth);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Fonter V1.5 160515 qland.de";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataWidth)).EndInit();
            this.grbOrigin.ResumeLayout(false);
            this.grbOrigin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.NumericUpDown nudCell;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.CheckBox chkDB;
        private System.Windows.Forms.RadioButton rdbZeroX;
        private System.Windows.Forms.RadioButton rdbDollar;
        private System.Windows.Forms.NumericUpDown nudDataWidth;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClipAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbOrigin;
        private System.Windows.Forms.RadioButton rdbTLX40;
        private System.Windows.Forms.RadioButton rdbTLY07;
        private System.Windows.Forms.RadioButton rdbTLY07R;
        private System.Windows.Forms.RadioButton rdbHXY;
        private System.Windows.Forms.CheckBox chkBitmap;
    }
}

