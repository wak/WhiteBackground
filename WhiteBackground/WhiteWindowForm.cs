using System;
using System.Windows.Forms;

namespace WhiteBackground
{
    public partial class WhiteWindow : Form
    {
        public WhiteWindow()
        {
            InitializeComponent();
            this.Icon = FormIcon.icon();
        }

        private void contextMenu_fullScreen_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void ContextMenu_maximizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void ContextMenu_normalizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void ContextMenu_exitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
