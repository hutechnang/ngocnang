using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lop7
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            FrmChild f = new lop7.FrmChild();
            f.MdiParent = this;
            f.Show();
        }

        private void menuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuCloseAll_Click(object sender, EventArgs e)
        {
            foreach(Form f in MdiChildren)
                f.Close();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
