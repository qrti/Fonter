namespace fonter
{
    partial class Form2
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
            this.nudDotSize = new System.Windows.Forms.NumericUpDown();
            this.lblDotSize = new System.Windows.Forms.Label();
            this.lblGapSize = new System.Windows.Forms.Label();
            this.nudGapSize = new System.Windows.Forms.NumericUpDown();
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.rbtSquare = new System.Windows.Forms.RadioButton();
            this.rbtCircle = new System.Windows.Forms.RadioButton();
            this.grbShape = new System.Windows.Forms.GroupBox();
            this.rbtRound = new System.Windows.Forms.RadioButton();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.rbtOrange = new System.Windows.Forms.RadioButton();
            this.rbtYellow = new System.Windows.Forms.RadioButton();
            this.rbtGreen = new System.Windows.Forms.RadioButton();
            this.rbtRed = new System.Windows.Forms.RadioButton();
            this.rbtBlue = new System.Windows.Forms.RadioButton();
            this.rbtBlack = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudDotSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGapSize)).BeginInit();
            this.grbSize.SuspendLayout();
            this.grbShape.SuspendLayout();
            this.grbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudDotSize
            // 
            this.nudDotSize.Location = new System.Drawing.Point(6, 50);
            this.nudDotSize.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudDotSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDotSize.Name = "nudDotSize";
            this.nudDotSize.Size = new System.Drawing.Size(84, 26);
            this.nudDotSize.TabIndex = 0;
            this.nudDotSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDotSize.ValueChanged += new System.EventHandler(this.nudDotSize_ValueChanged);
            // 
            // lblDotSize
            // 
            this.lblDotSize.AutoSize = true;
            this.lblDotSize.Location = new System.Drawing.Point(2, 27);
            this.lblDotSize.Name = "lblDotSize";
            this.lblDotSize.Size = new System.Drawing.Size(35, 20);
            this.lblDotSize.TabIndex = 1;
            this.lblDotSize.Text = "Dot";
            // 
            // lblGapSize
            // 
            this.lblGapSize.AutoSize = true;
            this.lblGapSize.Location = new System.Drawing.Point(2, 79);
            this.lblGapSize.Name = "lblGapSize";
            this.lblGapSize.Size = new System.Drawing.Size(40, 20);
            this.lblGapSize.TabIndex = 3;
            this.lblGapSize.Text = "Gap";
            // 
            // nudGapSize
            // 
            this.nudGapSize.Location = new System.Drawing.Point(4, 102);
            this.nudGapSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGapSize.Name = "nudGapSize";
            this.nudGapSize.Size = new System.Drawing.Size(84, 26);
            this.nudGapSize.TabIndex = 2;
            this.nudGapSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGapSize.ValueChanged += new System.EventHandler(this.nudGapSize_ValueChanged);
            // 
            // grbSize
            // 
            this.grbSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSize.Controls.Add(this.nudDotSize);
            this.grbSize.Controls.Add(this.lblDotSize);
            this.grbSize.Controls.Add(this.nudGapSize);
            this.grbSize.Controls.Add(this.lblGapSize);
            this.grbSize.Location = new System.Drawing.Point(288, 12);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(96, 142);
            this.grbSize.TabIndex = 7;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size";
            // 
            // rbtSquare
            // 
            this.rbtSquare.AutoSize = true;
            this.rbtSquare.Location = new System.Drawing.Point(6, 25);
            this.rbtSquare.Name = "rbtSquare";
            this.rbtSquare.Size = new System.Drawing.Size(86, 24);
            this.rbtSquare.TabIndex = 4;
            this.rbtSquare.TabStop = true;
            this.rbtSquare.Text = "Square";
            this.rbtSquare.UseVisualStyleBackColor = true;
            this.rbtSquare.CheckedChanged += new System.EventHandler(this.rbtSquare_CheckedChanged);
            // 
            // rbtCircle
            // 
            this.rbtCircle.AutoSize = true;
            this.rbtCircle.Location = new System.Drawing.Point(6, 55);
            this.rbtCircle.Name = "rbtCircle";
            this.rbtCircle.Size = new System.Drawing.Size(73, 24);
            this.rbtCircle.TabIndex = 5;
            this.rbtCircle.TabStop = true;
            this.rbtCircle.Text = "Circle";
            this.rbtCircle.UseVisualStyleBackColor = true;
            this.rbtCircle.CheckedChanged += new System.EventHandler(this.rbtCircle_CheckedChanged);
            // 
            // grbShape
            // 
            this.grbShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grbShape.Controls.Add(this.rbtRound);
            this.grbShape.Controls.Add(this.rbtSquare);
            this.grbShape.Controls.Add(this.rbtCircle);
            this.grbShape.Location = new System.Drawing.Point(288, 160);
            this.grbShape.Name = "grbShape";
            this.grbShape.Size = new System.Drawing.Size(96, 119);
            this.grbShape.TabIndex = 8;
            this.grbShape.TabStop = false;
            this.grbShape.Text = "Shape";
            // 
            // rbtRound
            // 
            this.rbtRound.AutoSize = true;
            this.rbtRound.Location = new System.Drawing.Point(6, 85);
            this.rbtRound.Name = "rbtRound";
            this.rbtRound.Size = new System.Drawing.Size(82, 24);
            this.rbtRound.TabIndex = 9;
            this.rbtRound.TabStop = true;
            this.rbtRound.Text = "Round";
            this.rbtRound.UseVisualStyleBackColor = true;
            this.rbtRound.CheckedChanged += new System.EventHandler(this.rbtRound_CheckedChanged);
            // 
            // grbColor
            // 
            this.grbColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grbColor.Controls.Add(this.rbtOrange);
            this.grbColor.Controls.Add(this.rbtYellow);
            this.grbColor.Controls.Add(this.rbtGreen);
            this.grbColor.Controls.Add(this.rbtRed);
            this.grbColor.Controls.Add(this.rbtBlue);
            this.grbColor.Controls.Add(this.rbtBlack);
            this.grbColor.Location = new System.Drawing.Point(12, 191);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(270, 88);
            this.grbColor.TabIndex = 9;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Color";
            // 
            // rbtOrange
            // 
            this.rbtOrange.AutoSize = true;
            this.rbtOrange.Location = new System.Drawing.Point(85, 56);
            this.rbtOrange.Name = "rbtOrange";
            this.rbtOrange.Size = new System.Drawing.Size(87, 24);
            this.rbtOrange.TabIndex = 5;
            this.rbtOrange.TabStop = true;
            this.rbtOrange.Text = "Orange";
            this.rbtOrange.UseVisualStyleBackColor = true;
            this.rbtOrange.CheckedChanged += new System.EventHandler(this.rbtOrange_CheckedChanged);
            // 
            // rbtYellow
            // 
            this.rbtYellow.AutoSize = true;
            this.rbtYellow.Location = new System.Drawing.Point(178, 56);
            this.rbtYellow.Name = "rbtYellow";
            this.rbtYellow.Size = new System.Drawing.Size(80, 24);
            this.rbtYellow.TabIndex = 4;
            this.rbtYellow.TabStop = true;
            this.rbtYellow.Text = "Yellow";
            this.rbtYellow.UseVisualStyleBackColor = true;
            this.rbtYellow.CheckedChanged += new System.EventHandler(this.rbtYellow_CheckedChanged);
            // 
            // rbtGreen
            // 
            this.rbtGreen.AutoSize = true;
            this.rbtGreen.Location = new System.Drawing.Point(85, 25);
            this.rbtGreen.Name = "rbtGreen";
            this.rbtGreen.Size = new System.Drawing.Size(79, 24);
            this.rbtGreen.TabIndex = 3;
            this.rbtGreen.TabStop = true;
            this.rbtGreen.Text = "Green";
            this.rbtGreen.UseVisualStyleBackColor = true;
            this.rbtGreen.CheckedChanged += new System.EventHandler(this.rbtGreen_CheckedChanged);
            // 
            // rbtRed
            // 
            this.rbtRed.AutoSize = true;
            this.rbtRed.Location = new System.Drawing.Point(6, 56);
            this.rbtRed.Name = "rbtRed";
            this.rbtRed.Size = new System.Drawing.Size(64, 24);
            this.rbtRed.TabIndex = 2;
            this.rbtRed.TabStop = true;
            this.rbtRed.Text = "Red";
            this.rbtRed.UseVisualStyleBackColor = true;
            this.rbtRed.CheckedChanged += new System.EventHandler(this.rbtRed_CheckedChanged);
            // 
            // rbtBlue
            // 
            this.rbtBlue.AutoSize = true;
            this.rbtBlue.Location = new System.Drawing.Point(178, 25);
            this.rbtBlue.Name = "rbtBlue";
            this.rbtBlue.Size = new System.Drawing.Size(66, 24);
            this.rbtBlue.TabIndex = 1;
            this.rbtBlue.TabStop = true;
            this.rbtBlue.Text = "Blue";
            this.rbtBlue.UseVisualStyleBackColor = true;
            this.rbtBlue.CheckedChanged += new System.EventHandler(this.rbtBlue_CheckedChanged);
            // 
            // rbtBlack
            // 
            this.rbtBlack.AutoSize = true;
            this.rbtBlack.Location = new System.Drawing.Point(6, 25);
            this.rbtBlack.Name = "rbtBlack";
            this.rbtBlack.Size = new System.Drawing.Size(73, 24);
            this.rbtBlack.TabIndex = 0;
            this.rbtBlack.TabStop = true;
            this.rbtBlack.Text = "Black";
            this.rbtBlack.UseVisualStyleBackColor = true;
            this.rbtBlack.CheckedChanged += new System.EventHandler(this.rbtBlack_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 289);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.grbShape);
            this.Controls.Add(this.grbSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDotSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGapSize)).EndInit();
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.grbShape.ResumeLayout(false);
            this.grbShape.PerformLayout();
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDotSize;
        private System.Windows.Forms.Label lblDotSize;
        private System.Windows.Forms.Label lblGapSize;
        private System.Windows.Forms.NumericUpDown nudGapSize;
        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.RadioButton rbtSquare;
        private System.Windows.Forms.RadioButton rbtCircle;
        private System.Windows.Forms.GroupBox grbShape;
        private System.Windows.Forms.RadioButton rbtRound;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.RadioButton rbtOrange;
        private System.Windows.Forms.RadioButton rbtYellow;
        private System.Windows.Forms.RadioButton rbtGreen;
        private System.Windows.Forms.RadioButton rbtRed;
        private System.Windows.Forms.RadioButton rbtBlue;
        private System.Windows.Forms.RadioButton rbtBlack;
    }
}