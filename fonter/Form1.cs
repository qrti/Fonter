// fonter V1.5 qrt 160515 qrt@qland.de

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Drawing.Drawing2D;     // smoothing etc.
using fonter.Properties;            // Properties.Settings... -> Settings...
using System.Diagnostics;           // debug output

namespace fonter
{
    public partial class Form1 : Form
    {
        string fontPath;
        string bitmapPath;

        const int GRID_LEFT = 10;
        const int GRID_TOP = 10;
        const int GRID_SIZE = 256;

        const int ASC_SPACE = 18;
        const int ASC_CHAPL = 7;
        const int ASC_FONSI = 12;

        Form2 form2;
        System.Drawing.Graphics formGraphics;
        System.Drawing.SolidBrush delBrush;

        public byte[,] grid; 
        int curasc = 48;
        byte[] exdat;
        bool ascdbl = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formGraphics = this.CreateGraphics();
            delBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromName("Control"));
            grid = new byte[GRID_SIZE, GRID_SIZE];
            exdat = new byte[128-32];

            string appPath;

            if(Directory.GetParent(Application.StartupPath).Name == "bin")
                appPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName;
            else 
                appPath = Application.StartupPath;
            
            fontPath = appPath + "\\" + "font" + "\\";
            bitmapPath = appPath + "\\" + "bitmap" + "\\";
        }       

        private void Form1_Shown(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            form2.Left = Left + txtData.Left - 80;
            form2.Top = Top + 40;
            form2.Show();

            if(Settings.Default.lastName != null){
                txtName.Text = Settings.Default.lastName;
                refreshExdat();
            }

            form2.dotSize = Settings.Default.dotSize;
            form2.gapSize = Settings.Default.gapSize;
            form2.shape = Settings.Default.shape;
            form2.color = Settings.Default.color;

            calcData();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.lastName = txtName.Text;

            Settings.Default.dotSize = form2.dotSize;
            Settings.Default.gapSize = form2.gapSize;
            Settings.Default.shape = form2.shape;
            Settings.Default.color = form2.color;

            Settings.Default.Save();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDraw(e.X, e.Y, e.Button);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if(ascdbl){
                if(txtName.Text == ""){
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "error: missing filename";
                    return;
                }

                string fn = fontPath + txtName.Text + String.Format("_{0:x2}.dat", curasc); 

                if(checkFilename(fn)){
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "error: invalid filename";
                    return;
                }

                if(!File.Exists(fn)){
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "error: file not found";
                    return;
                }

                System.IO.BinaryReader fp = new System.IO.BinaryReader(File.Open(fn, FileMode.Open));
            
                int v = fp.ReadInt16();
                if(v<0 || v>=GRID_SIZE) v = 8;
                nudWidth.Value = v;

                v = fp.ReadInt16();
                if(v<0 || v>=GRID_SIZE) v = 16;
                nudHeight.Value = v;
  
                v = fp.ReadInt16();
                v = fp.ReadInt16();
                v = fp.ReadInt16();
                v = fp.ReadInt16();

                int w = (int)nudWidth.Value;
                int h = (int)nudHeight.Value;

                for(int x=0; x<w; x++)
                    for(int y=0; y<h; y++)
                        grid[x, y] = fp.ReadByte();

                fp.Close();

                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "loading OK";

                drawGrid();
                drawAsctab();

                if(rdbHXY.Checked){
                    txtData.Text = "";
                    hxycnt = 0;
                    lastx = -1;
                    lasty = -1;
                }
                else{
                    calcData();
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left || e.Button==MouseButtons.Right)
                mouseDraw(e.X, e.Y, e.Button);
        }
 
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if(formGraphics != null)
                formGraphics.Dispose();

            formGraphics = this.CreateGraphics();
        }       

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(form2!=null && WindowState==FormWindowState.Minimized)
                form2.WindowState = FormWindowState.Minimized;
            else if(form2!=null && WindowState==FormWindowState.Normal)
                form2.WindowState = FormWindowState.Normal;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(e.GetType() == typeof(PaintEventArgs)){
                drawGrid();
                drawAsctab();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            grid = new byte[GRID_SIZE, GRID_SIZE];
            drawGrid();
            drawAsctab();

            if(rdbHXY.Checked){
                txtData.Text = "";
                hxycnt = 0;
                lastx = -1;
                lasty = -1;
            }
            else{
                calcData();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            refreshExdat();
            drawGrid();

            int lc = drawAsctab();

            if(lc < 128){
                curasc = lc;
                ascdbl = true;
                Form1_DoubleClick(null, null);
                ascdbl = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text == ""){
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "error: missing filename";
                return;
            }
 
            string fn = fontPath + txtName.Text + String.Format("_{0:x2}.dat", curasc); 
            
            if(checkFilename(fn)){
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "error: invalid filename";
                return;
            }           
            
            System.IO.BinaryWriter fp = new System.IO.BinaryWriter(File.Open(fn, FileMode.Create));
            
            fp.Write((Int16)nudWidth.Value);
            fp.Write((Int16)nudHeight.Value);
            fp.Write((Int16)0);
            fp.Write((Int16)0);
            fp.Write((Int16)0);
            fp.Write((Int16)0);
            
            int w = (int)nudWidth.Value;
            int h = (int)nudHeight.Value;

            for(int x=0; x<w; x++)
                for(int y=0; y<h; y++)
                    fp.Write(grid[x, y]);

            fp.Close();

            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "saving OK";

            refreshExdat();
            drawGrid();
            drawAsctab();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtName.Text == ""){
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "error: missing filename";
                return;
            }
 
            string fn = fontPath + txtName.Text + String.Format("_{0:x2}.dat", curasc); 
            
            if(checkFilename(fn)){
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "error: invalid filename";
                return;
            }           

            if(File.Exists(fn)){
                File.Delete(fn);

                curasc = 48;
                refreshExdat();
                drawGrid();
                drawAsctab();

                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "char deleted";
            }
            else{
               lblMessage.ForeColor = Color.Red;
               lblMessage.Text = "nothing to delete";
            }
        }

        const int dotw = 20;
        const int dots = 5;
        const int chas = 20;

        private void btnClipAll_Click(object sender, EventArgs e)
        {
            if(rdbHXY.Checked){
                clipSet(txtData.Text);
                return;
            }

            if(txtName.Text == ""){
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "error: missing filename";
                return;
            }

            if(checkFilename(txtName.Text)){
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "error: invalid filename";
                return;
            }

            //..................................................................

            Bitmap bitmap = null;
            Graphics graphics = null;
            Brush brush = null;

            if(chkBitmap.Checked){
                int nc = 0;

                for(int c=32; c<128; c++)
                    if(exdat[c-32] == 1)
                        nc++;

                int w = nc * ((int)nudWidth.Value * (dotw + dots) + chas) + dots - chas;
                int h = (int)nudHeight.Value * (dotw + dots) + dots;

                bitmap = new Bitmap(w, h);
                graphics = Graphics.FromImage(bitmap);

                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                brush = new SolidBrush(Color.Red);
            }

            //..................................................................

            string t = (chkDB.Checked ? ";" : "// ") + "char table\r\n";;
            int[] wita = new int[128-32];
            int fc = 0;         // first char
            int lc = 0;         // last char
            int vc = 0;         // valid chars

            for(int c=32; c<128; c++){
                if(exdat[c-32] == 1){
                    byte[,] g = new byte[GRID_SIZE, GRID_SIZE];
                    string fn = fontPath + txtName.Text + String.Format("_{0:x2}.dat", c); 
                    
                    if(File.Exists(fn)){
                        System.IO.BinaryReader fp = new System.IO.BinaryReader(File.Open(fn, FileMode.Open));
                        int wo = fp.ReadInt16();
                        int ho = fp.ReadInt16();

                        if(wo>0 && wo<GRID_SIZE && ho>0 && ho<GRID_SIZE){
                            if(fc == 0) fc = c;
                            wita[c-32] = wo;

                            int v = fp.ReadInt16();
                            v = fp.ReadInt16();
                            v = fp.ReadInt16();
                            v = fp.ReadInt16();

                            for(int x=0; x<wo; x++)
                                for(int y=0; y<ho; y++)
                                    g[x, y] = fp.ReadByte();

                            fp.Close();

                            // transformation --------------------------------------------------

                            int w = 0;
                            int h = 0;

                            byte[,] gric = new byte[GRID_SIZE, GRID_SIZE];

                            if(rdbTLY07.Checked){
                                w = wo;
                                h = ho;

                                for(int x=0; x<w; x++)
                                    for(int y=0; y<h; y++)
                                        gric[x, y] = g[x, y];
                            }
                            else if(rdbTLY07R.Checked){
                                w = wo;
                                h = ho;

                                for(int x=0; x<w; x++)
                                    for(int y=0; y<h; y++)
                                        gric[x, ho-1-y] = g[x, y];
                            }
                            else if(rdbTLX40.Checked){
                                w = ho;
                                h = wo;

                                for(int x=0; x<wo; x++)
                                    for(int y=0; y<ho; y++)
                                        gric[y, wo-1-x] = g[x, y];
                            }

                            // -----------------------------------------------------------------

                            int lz = (h-1) / 8;                             // last z
                            int bp = (int)nudDataWidth.Value;               // byte per line
                            bool db = chkDB.Checked;                        // assembler or C
                            string he = rdbDollar.Checked ? "$" : "0x";     // hex notation
                            int i = 0;                                      // byte counter
                            byte b, s;                                      // byte, shift
                            int nb = (lz + 1) * w;                          // number of bytes
                            string co = (c==32 ? "SPACE" : ((char)c).ToString()); // comment 
                           
                            for(int z=0; z<=lz; z++){   // char table
                                int ly = z*8 + (z==lz && h%8!=0 ? h%8 : 8);

                                for(int x=0; x<w; x++){
                                    b = 0; s = 0;

                                    for(int y=z*8; y<ly; y++)
                                        b |= (byte)(gric[x, y] << s++);
                    
                                    if(db){
                                        t += string.Format("{0:s}{1:s}{2:x2}{3:s}{4:s}", 
                                             i%bp==0 ? (i==0 ? ".DB " : "\r\n.DB ") : "",
                                             he, b, i%bp==bp-1 || i==nb-1 ? "" : ",",
                                             i==bp-1 || (i==nb-1 && nb<bp) ? " ;"+co : "");
                                    }
                                    else{
                                        t += string.Format("{0:s}{1:s}{2:x2},{3:s}", 
                                             i%bp==0 ? (i==0 ? "" : "\r\n") : "", he, b, 
                                             i==bp-1 || (i==nb-1 && nb<bp) ? " // "+co : "");
                                    }

                                    i++;
                                }
                            }

                            //..................................................................

                            if(chkBitmap.Checked){
                                int chaw = (int)nudWidth.Value;
                                int chah = (int)nudHeight.Value;
                                int left = vc * (chaw * (dotw + dots) + chas) + dots;

                                for(int y=0; y<chah; y++)
                                    for(int x=0; x<chaw; x++)
                                        if(g[x, y] != 0)
                                            graphics.FillEllipse(brush, left + x * (dotw + dots), dots + y * (dotw + dots), dotw, dotw);
                            }

                            //..................................................................

                            lc = c;
                            vc++;
                            t += "\r\n";
                        }
                    }
                }
            }

            //..................................................................

            if(chkBitmap.Checked){
                graphics.Flush();
                bitmap.Save(bitmapPath + txtName.Text + ".bmp");
                graphics.Dispose();
                bitmap.Dispose();
            }

            //..................................................................

            if(rdbTLY07.Checked || rdbTLY07R.Checked){
                string u = (chkDB.Checked ? ";" : "// ") + "width table\r\n";

                if(vc != 0){                                        // width table
                    int i = 0;                                      // char counter
                    int bp = (int)nudDataWidth.Value;               // byte per line
                    bool db = chkDB.Checked;                        // assembler or C
                    string he = rdbDollar.Checked ? "$" : "0x";     // hex notation
                    int nc = lc - fc + 1;                           // number of chars

                    for(int c=fc; c<=lc; c++){
                        int w = wita[c-32];
                    
                        if(db){                     
                            u += string.Format("{0:s}{1:s}{2:x2}{3:s}", 
                                 i%bp==0 ? (i==0 ? ".DB " : "\r\n.DB ") : "",
                                 he, w, i%bp==bp-1 || i==nc-1 ? "" : ",");
                        }
                        else{
                            u += string.Format("{0:s}{1:s}{2:x2},", 
                                 i%bp==0 ? (i==0 ? "" : "\r\n") : "", he, w);
                        }
                
                        i++;
                    }
                }

                int laco = t.LastIndexOf(", ");

                if(laco != -1){
                    t = t.Remove(laco, 1);
                    t = t.Insert(laco, " ");
                }

                laco = u.LastIndexOf(",");

                if(laco != -1){
                    u = u.Remove(laco, 1);
                    u = u.Insert(laco, " ");
                }
            
                t = u + "\r\n\r\n" + t;
            }

            clipSet(t);
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = vc + " chars copied";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            drawGrid();
            calcData();
            drawAsctab();

            if(form2 != null)
                form2.changeSize();
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            drawGrid();   
            calcData();         
            drawAsctab();    
        
            if(form2 != null)
                form2.changeSize();
        }

        private void nudCell_ValueChanged(object sender, EventArgs e)
        {
            drawGrid();
            drawAsctab();
        }

        private void chkDB_CheckedChanged(object sender, EventArgs e)
        {
            calcData();
        }

        private void rdbZeroX_CheckedChanged(object sender, EventArgs e)
        {
            calcData();
        }

        private void nudDataWidth_ValueChanged(object sender, EventArgs e)
        {
            calcData();
        }

        private void rdbTLY07R_CheckedChanged(object sender, EventArgs e)
        {
            calcData();
        }

        private void rdbTLY07_CheckedChanged(object sender, EventArgs e)
        {
            calcData();
        }

        private void rdbTLX40_CheckedChanged(object sender, EventArgs e)
        {
            calcData();
        }

        private void rdbHXY_CheckedChanged(object sender, EventArgs e)      // history xy pebble watch
        {
            if(rdbHXY.Checked)
                txtData.Text = "";
        }

        private void drawGrid()
        {
            formGraphics.FillRectangle(delBrush, 0, 0, ClientSize.Width, ClientSize.Height);
            
            int w = (int)nudWidth.Value;
            int h = (int)nudHeight.Value;
            int c = (int)nudCell.Value;

            for(int x=0; x<=w; x++)
                formGraphics.DrawLine(Pens.Black, GRID_LEFT+x*c, GRID_TOP, GRID_LEFT+x*c, GRID_TOP+h*c);

            for(int y=0; y<=h; y++)
                formGraphics.DrawLine(Pens.Black, GRID_LEFT, GRID_TOP+y*c, GRID_LEFT+w*c, GRID_TOP+y*c);
        
            for(int x=0; x<w; x++){
                for(int y=0; y<h; y++){
                    if(grid[x, y] != 0){
                        int xc = GRID_LEFT + x*(int)nudCell.Value + 1;
                        int yc = GRID_TOP + y*(int)nudCell.Value + 1;   
                        formGraphics.FillRectangle(Brushes.DarkBlue, new Rectangle(xc, yc, (int)nudCell.Value-1, (int)nudCell.Value-1));
                    }
                }
            }
            
            form2.Refresh();
        }

        private int drawAsctab()
        {
            int xs = txtName.Left;
            int y = txtName.Top + txtName.Height + 6;
            int x = 0;
            int lowasc = 255;

            for(int i=0; i<128-32; i++){
                if(i%ASC_CHAPL == 0){
                    x = xs;
                    y += (i==0 ? 0 : ASC_SPACE);
                }

                if(i == curasc-32){
                    if(i < lowasc) lowasc = i;
                    formGraphics.FillEllipse(Brushes.Orange, x-3, y-3, ASC_SPACE+2, ASC_SPACE+2);
                }
                else if(exdat[i] == 1){
                    if(i < lowasc) lowasc = i;
                    formGraphics.FillEllipse(Brushes.LightGreen, x-3, y-3, ASC_SPACE+2, ASC_SPACE+2);
                }

                formGraphics.DrawString(((char)(i+32)).ToString(), 
                             new Font("Lucida Console", ASC_FONSI), 
                             Brushes.Black, new Point(x, y));

                x += ASC_SPACE;
            }

            return lowasc + 32;
        }
        
        private void calcData()
        {
            string t = "";
            int wo = (int)nudWidth.Value;
            int ho = (int)nudHeight.Value;

            // transformation --------------------------------------------------

            int w = 0;
            int h = 0;

            byte[,] gric = new byte[GRID_SIZE, GRID_SIZE];

            if(rdbTLY07.Checked){
                w = wo;
                h = ho;

                for(int x=0; x<w; x++)
                    for(int y=0; y<h; y++)
                        gric[x, y] = grid[x, y];
            }
            else if(rdbTLY07R.Checked){
                w = wo;
                h = ho;

                for(int x=0; x<w; x++)
                    for(int y=0; y<h; y++)
                        gric[x, ho-1-y] = grid[x, y];
            }
            else if(rdbTLX40.Checked){
                w = ho;
                h = wo;

                for(int x=0; x<wo; x++)
                    for(int y=0; y<ho; y++)
                        gric[y, wo-1-x] = grid[x, y];
            }

            // -----------------------------------------------------------------

            int lz = (h-1) / 8;                             // last z
                           
            int bp = (int)nudDataWidth.Value;               // byte per line
            string he = rdbDollar.Checked ? "$" : "0x";     // hex notation
            int i = 0;                                      // byte counter
            byte b, s;                                      // byte, shift
            int nb = (lz + 1) * w;                          // number of bytes
            string co = (curasc==32 ? "SPACE" : ((char)curasc).ToString()); // comment 

            for(int z=0; z<=lz; z++){
                int ly = z*8 + (z==lz && h%8!=0 ? h%8 : 8);

                for(int x=0; x<w; x++){
                    b = 0; s = 0;

                    for(int y=z*8; y<ly; y++)
                        b |= (byte)(gric[x, y] << s++);

                    if(chkDB.Checked){
                        t += string.Format("{0:s}{1:s}{2:x2}{3:s}{4:s}", 
                            i%bp==0 ? (i==0 ? ".DB " : "\r\n.DB ") : "",
                            he, b, i%bp==bp-1 || i==nb-1 ? "" : ",",
                            i==bp-1 || (i==nb-1 && nb<bp) ? " ;"+co : "");
                    }
                    else{
                        t += string.Format("{0:s}{1:s}{2:x2},{3:s}", 
                                i%bp==0 ? (i==0 ? "" : "\r\n") : "", he, b, 
                                i==bp-1 || (i==nb-1 && nb<bp) ? " // "+co : "");
                    }
                    
                    i++;
                }
            }

            txtData.Text = t;
            clipSet(t);
        }

        private bool checkFilename(string fn)
        {
            bool rv = false;
            char[] invalidChars = System.IO.Path.GetInvalidPathChars();

            foreach(char c in invalidChars){
                if(fn.Contains(c)){
                    rv = true;
                    break;
                }
            }

            return rv;
        }

        int hxycnt, lastx = -1, lasty = -1;

        private void mouseDraw(int ex, int ey, MouseButtons bu)
        {
            ascdbl = false;

            if(ex>=GRID_LEFT && ex<txtName.Left && ey>=GRID_TOP){
                int x = (ex - GRID_LEFT) / (int)nudCell.Value;
                int y = (ey - GRID_TOP) / (int)nudCell.Value;

                // Debug.Print("{0} {1}", x, y);

                if(x<(int)nudWidth.Value && y<(int)nudHeight.Value){
                    grid[x, y] = (byte)(bu==MouseButtons.Left ? 1 : 0);
                    int xc = GRID_LEFT + x * (int)nudCell.Value + 1;
                    int yc = GRID_TOP + y * (int)nudCell.Value + 1;
                    Brush brush = grid[x, y]==0 ? delBrush : Brushes.DarkBlue;
                    formGraphics.FillRectangle(brush, new Rectangle(xc, yc, (int)nudCell.Value - 1, (int)nudCell.Value - 1));
                    form2.Refresh();

                    if(rdbHXY.Checked){
                        if(x != lastx || y!=lasty){
                            txtData.AppendText(string.Format("{0,2},{1,2},", x, y));
                            lastx = x;
                            lasty = y;

                            if(++hxycnt == 8){
                                txtData.AppendText("\r\n");
                                hxycnt = 0;
                            }
                        }
                    }
                    else{
                        calcData();
                    }
                }
            }
            else if(ex>=txtName.Left && ey>=txtName.Top+txtName.Height+6){
                int xs = txtName.Left;
                int ys = txtName.Top + txtName.Height + 6;
                int x = (ex - xs) / ASC_SPACE;
                int y = (ey - ys) / ASC_SPACE;
                int newc = y * ASC_CHAPL + x;

                if(x<=ASC_CHAPL && newc<128-32){
                    int c = curasc - 32;

                    formGraphics.FillEllipse(delBrush, xs + c % ASC_CHAPL * ASC_SPACE - 3,
                                 ys + c / ASC_CHAPL * ASC_SPACE - 3, ASC_SPACE + 2, ASC_SPACE + 2);

                    if(exdat[c] == 1)
                            formGraphics.FillEllipse(Brushes.LightGreen, xs + c % ASC_CHAPL * ASC_SPACE - 3,
                            ys + c / ASC_CHAPL * ASC_SPACE - 3, ASC_SPACE + 2, ASC_SPACE + 2);

                    formGraphics.DrawString(((char)(curasc)).ToString(),
                                 new Font("Lucida Console", ASC_FONSI), Brushes.Black,
                                 new Point(xs + c % ASC_CHAPL * ASC_SPACE, ys + c / ASC_CHAPL * ASC_SPACE));

                    c = newc;
                    curasc = c + 32;

                    formGraphics.FillEllipse(Brushes.Orange, xs + c % ASC_CHAPL * ASC_SPACE - 3,
                                 ys + c / ASC_CHAPL * ASC_SPACE - 3, ASC_SPACE + 2, ASC_SPACE + 2);

                    formGraphics.DrawString(((char)(curasc)).ToString(),
                                 new Font("Lucida Console", ASC_FONSI), Brushes.Black,
                                 new Point(xs + c % ASC_CHAPL * ASC_SPACE, ys + c / ASC_CHAPL * ASC_SPACE));
                    
                    ascdbl = true;
                }
            }
        }

        void refreshExdat()
        {
            string path = fontPath;
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(path);
            Array.Clear(exdat, 0, exdat.Length);

            if(txtName.Text != ""){
                foreach(FileInfo fi in info.GetFiles()){
                    if(fi.Name.StartsWith(txtName.Text + "_", StringComparison.OrdinalIgnoreCase)){
                        try{
                            int n = Convert.ToInt32(fi.Name.Substring(fi.Name.Length-6, 2), 16);
                            if(n>=32 && n<=128) exdat[n-32] = 1;
                        }
                        catch{
                        }
                    }
                }
            }
        }

        void clipSet(string t){
            try{
                Clipboard.SetDataObject(
                    t,          // text to store in clipboard
                    false,      // do not keep after our app exits
                    5,          // retry 5 times
                    200);       // 200 ms delay between retries
            }
            catch{ 
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "error: clipboard save failed";                
            }
        }

        // bool mmm = false;

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            //if(Form.ActiveForm != null){
            //    form2.TopMost = false;
            //    mmm = true;
            //}
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //if(mmm && Form.ActiveForm!=null && form2!=null){
            //    form2.TopMost = true;
            //    mmm = false;
            //}
        }

        public int fontWidth{
            get { return (int)nudWidth.Value; }
            //set { nudWidth.Value = value; }
        }

        public int fontHeight{
            get { return (int)nudHeight.Value; }
            //set { nudHeight.Value = value; }
        }
    }
}
