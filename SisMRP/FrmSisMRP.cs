using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisMRP
{
    public partial class FrmSisMRP : Form
    {
        public FrmSisMRP()
        {
            InitializeComponent();
            enableWindowsMenu();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }

        private void fecharTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] childArray = this.MdiChildren;
            
            foreach (Form item in childArray)
            {
                item.Close();
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void janelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableWindowsMenu();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void enableWindowsMenu()
        {
            bool hasMdiChild = (MdiChildren.Count() != 0);
            fecharToolStripMenuItem.Enabled = hasMdiChild;
            fecharTodasToolStripMenuItem.Enabled = hasMdiChild;
            cascataToolStripMenuItem.Enabled = hasMdiChild;
        }

        private void FrmSisMRP_MdiChildActivate(object sender, EventArgs e)
        {
        }
    }
}
