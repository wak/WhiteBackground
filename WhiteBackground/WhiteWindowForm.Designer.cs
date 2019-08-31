namespace WhiteBackground
{
    partial class WhiteWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenu_normalizeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_maximizeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_fullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenu_exitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenu_normalizeWindow,
            this.contextMenu_maximizeWindow,
            this.contextMenu_fullScreen,
            this.toolStripSeparator1,
            this.contextMenu_exitProgram});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(136, 98);
            // 
            // contextMenu_normalizeWindow
            // 
            this.contextMenu_normalizeWindow.Name = "contextMenu_normalizeWindow";
            this.contextMenu_normalizeWindow.Size = new System.Drawing.Size(135, 22);
            this.contextMenu_normalizeWindow.Text = "通常化";
            this.contextMenu_normalizeWindow.Click += new System.EventHandler(this.ContextMenu_normalizeWindow_Click);
            // 
            // contextMenu_maximizeWindow
            // 
            this.contextMenu_maximizeWindow.Name = "contextMenu_maximizeWindow";
            this.contextMenu_maximizeWindow.Size = new System.Drawing.Size(135, 22);
            this.contextMenu_maximizeWindow.Text = "最大化";
            this.contextMenu_maximizeWindow.Click += new System.EventHandler(this.ContextMenu_maximizeWindow_Click);
            // 
            // contextMenu_fullScreen
            // 
            this.contextMenu_fullScreen.Name = "contextMenu_fullScreen";
            this.contextMenu_fullScreen.Size = new System.Drawing.Size(135, 22);
            this.contextMenu_fullScreen.Text = "フルスクリーン";
            this.contextMenu_fullScreen.Click += new System.EventHandler(this.contextMenu_fullScreen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // contextMenu_exitProgram
            // 
            this.contextMenu_exitProgram.Name = "contextMenu_exitProgram";
            this.contextMenu_exitProgram.Size = new System.Drawing.Size(135, 22);
            this.contextMenu_exitProgram.Text = "終了";
            this.contextMenu_exitProgram.Click += new System.EventHandler(this.ContextMenu_exitProgram_Click);
            // 
            // WhiteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenu;
            this.Name = "WhiteWindow";
            this.Text = "White Background";
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_fullScreen;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_exitProgram;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_maximizeWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_normalizeWindow;
    }
}

