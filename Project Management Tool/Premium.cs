using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_Tool
{
    public partial class Premium : Form
    {
        public Premium()
        {
            InitializeComponent();
        }


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

        private void premiumClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Premium_Load(object sender, EventArgs e)
        {
            premiumPage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, premiumPage.Width, premiumPage.Height, 30, 30));
        }
    }
}
