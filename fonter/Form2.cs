using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace fonter
{
    public partial class Form2 : Form
    {
        System.Drawing.Graphics formGraphics;
        System.Drawing.SolidBrush delBrush;

        Brush brush = Brushes.Black;

        private readonly Form1 form1;

        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            formGraphics = this.CreateGraphics();
            delBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromName("Control"));
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        const int BORDER = 7;

        protected override void OnPaint(PaintEventArgs e)
        {
            int w =  form1.fontWidth;
            int h =  form1.fontHeight;
            int dot = (int)nudDotSize.Value;
            int gap = (int)nudGapSize.Value;
            
            e.Graphics.FillRectangle(Brushes.LightGray, BORDER, BORDER, w * (dot + gap) - gap, h * (dot + gap) - gap);

            for(int x=0; x<w; x++){
                for(int y=0; y<h; y++){
                    if(form1.grid[x, y] != 0){
                        int xc = BORDER + x * (dot + gap);
                        int yc = BORDER + y * (dot + gap);   

                        if(rbtSquare.Checked){
                            e.Graphics.FillRectangle(brush, xc, yc, dot, dot);
                        }
                        else if(rbtCircle.Checked){
                            e.Graphics.FillEllipse(brush, xc, yc, dot, dot);
                        }
                        else if(rbtRound.Checked){
                            int r = dot/3 == 0 ? 1 : dot/3;
                            drawRoundedRectangle(e.Graphics, brush, new Rectangle(xc, yc, dot, dot), r);
                        }
                    }
                }
            }            
        }

        public void changeSize()
        {
            int dot = (int)nudDotSize.Value;
            int gap = (int)nudGapSize.Value;
            int sx = grbColor.Width;
            int sy = grbSize.Height + BORDER + grbShape.Height - grbColor.Height;
            int dx = form1.fontWidth * (dot + gap);
            int dy = form1.fontHeight * (dot + gap);

            this.ClientSize = new Size(dx < sx ? 3 * BORDER + grbColor.Width + grbSize.Width : 3 * BORDER + dx + grbSize.Width, 
                                       dy < sy ? 3 * BORDER + grbSize.Height + grbShape.Height : 3 * BORDER + dy + grbColor.Height);

            Refresh();

        }

        private void nudDotSize_ValueChanged(object sender, EventArgs e) 
        {
            changeSize();
        }

        private void nudGapSize_ValueChanged(object sender, EventArgs e) 
        {
            changeSize();
        }

        private void rbtBlack_CheckedChanged(object sender, EventArgs e) 
        {
            brush = Brushes.Black;
            Refresh();
        }

        private void rbtRed_CheckedChanged(object sender, EventArgs e) 
        {
            brush = Brushes.Red;
            Refresh();
        }

        private void rbtGreen_CheckedChanged(object sender, EventArgs e) 
        {
            brush = Brushes.Green;
            Refresh();
        }

        private void rbtOrange_CheckedChanged(object sender, EventArgs e) 
        {
            brush = Brushes.Orange;
            Refresh();
        }

        private void rbtBlue_CheckedChanged(object sender, EventArgs e) 
        {
            brush = Brushes.Blue;
            Refresh();
        }

        private void rbtYellow_CheckedChanged(object sender, EventArgs e) 
        {
            brush = Brushes.Yellow;
            Refresh();
        }

        private void rbtSquare_CheckedChanged(object sender, EventArgs e) 
        {
            Refresh();
        }

        private void rbtCircle_CheckedChanged(object sender, EventArgs e) 
        {
            Refresh();
        }

        private void rbtRound_CheckedChanged(object sender, EventArgs e) 
        {
            Refresh();
        }

        private void drawRoundedRectangle(Graphics g, Brush b, Rectangle rect, int r)
        {
            var path = new GraphicsPath();
            var r2 = (int)r / 2;
            rect.Location = new Point(rect.X - 1, rect.Y - 1);

            path.AddArc(rect.Left, rect.Top, r, r, 180, 90);
            path.AddLine(rect.Left + r2, rect.Top, rect.Right - r2 - 1, rect.Top);

            path.AddArc(rect.Right - r - 1, rect.Top, r, r, 270, 90);
            path.AddLine(rect.Right, rect.Top + r2, rect.Right, rect.Bottom - r2);

            path.AddArc(rect.Right - r - 1, rect.Bottom - r - 1, r, r, 0, 90);
            path.AddLine(rect.Right - r2, rect.Bottom, rect.Left + r2, rect.Bottom);

            path.AddArc(rect.Left, rect.Bottom - r - 1, r, r, 90, 90);
            path.AddLine(rect.Left, rect.Bottom - r2, rect.Left, rect.Top + r2);

            g.FillPath(b, path);
            path.Dispose();
        }

        public int dotSize{
            get { return (int)nudDotSize.Value; }
            set { nudDotSize.Value = value; }
        }

        public int gapSize{
            get { return (int)nudGapSize.Value; }
            set { nudGapSize.Value = value; }
        }

        public int shape{
            get { return rbtSquare.Checked ? 0 : (rbtCircle.Checked ? 1 : 2); }

            set { if(value == 0)      rbtSquare.Checked = true; 
                  else if(value == 1) rbtCircle.Checked = true;
                  else                rbtRound.Checked = true; }
        }

        public int color{
            get { if(rbtBlack.Checked)       return 0;
                  else if(rbtRed.Checked)    return 1;
                  else if(rbtGreen.Checked)  return 2;
                  else if(rbtOrange.Checked) return 3;
                  else if(rbtBlue.Checked)   return 4;
                  else                       return 5; }

            set { if(value == 0)      rbtBlack.Checked = true; 
                  else if(value == 1) rbtRed.Checked = true;
                  else if(value == 2) rbtGreen.Checked = true;
                  else if(value == 3) rbtOrange.Checked = true;
                  else if(value == 4) rbtBlue.Checked = true;
                  else                rbtYellow.Checked = true; }
        }
    }
}
