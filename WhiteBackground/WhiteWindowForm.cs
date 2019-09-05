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

        private void toggleFullscreen()
        {
            if (this.FormBorderStyle == FormBorderStyle.Sizable)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void toggleWindowMaximized()
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void toggleFormBorderStyleNone()
        {
            if (this.FormBorderStyle == FormBorderStyle.Sizable)
                this.FormBorderStyle = FormBorderStyle.None;
            else
                this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void ContextMenu_normalizeWindow_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void ContextMenu_maximizeWindow_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
        }

        private void contextMenu_fullScreen_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void ContextMenu_hideTitleBar_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ContextMenu_exitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WhiteWindow_KeyPress(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar)
            {
                case 'q':
                case 'w':
                    Application.Exit();
                    break;

                case 'f':
                    toggleWindowMaximized();
                    break;

                case 'm':
                    toggleFormBorderStyleNone();
                    //cwmEnterChangingWindowMode();
                    break;

                case 'g':
                    toggleFullscreen();
                    break;
            }
        }
    }
}
