using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_Tool
{
    public partial class workspace : Form
    {
        public workspace()
        {
            InitializeComponent();
            bm = new Bitmap(pic.Width, pic.Height);
            g=Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

        }
        Bitmap bm;
        Graphics g;
        bool Paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);

        int index;
        int x, y, sx, sy, cx, cy;
        ColorDialog cd = new ColorDialog();
        Color new_color;
       

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
       int nLeftRect,
       int nTopRect,
       int nRightRect,
       int nBottomRect,
       int nWidthEllipse,
       int nHeightEllipse
     );
        private void workspaceClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void workspace_Load(object sender, EventArgs e)
        {
            homepanel.BackColor = Color.FromArgb(50, 0, 0, 0);
            WorkspacePage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, WorkspacePage.Width, WorkspacePage.Height, 30, 30));
        }

        private void WorkspacePage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            Paint = true;
            py = e.Location;

            cx = e.X;
            cy = e.Y;
        }


        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (Paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y= e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (Paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }

                if (index == 4)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                }

                if (index == 5)
                {
                    g.DrawLine(p, cx, cy, x, y);
                }
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            Paint = false;

            sx = x - cx;
            sy = y - cy;
            
            if(index == 3)
            {
                g.DrawEllipse(p, cx, cy, sx, sy);
            }

            if(index == 4)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }

            if(index == 5)
            {
                g.DrawLine (p, cx, cy, x, y);
            }
        }

        private void picPaint_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            p.Color = cd.Color;
        }

        private void btbPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btbEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btbEclipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btbRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btbLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btbClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
