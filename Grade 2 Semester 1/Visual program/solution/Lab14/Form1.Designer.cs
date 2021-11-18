
namespace Lab14
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хэрэглэгчToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хэрэглэгчНэмэхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хэрэглэгчХасахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.хэрэглэгчToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Гарах";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // хэрэглэгчToolStripMenuItem
            // 
            this.хэрэглэгчToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хэрэглэгчНэмэхToolStripMenuItem,
            this.хэрэглэгчХасахToolStripMenuItem});
            this.хэрэглэгчToolStripMenuItem.Name = "хэрэглэгчToolStripMenuItem";
            this.хэрэглэгчToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.хэрэглэгчToolStripMenuItem.Text = "Хэрэглэгч";
            // 
            // хэрэглэгчНэмэхToolStripMenuItem
            // 
            this.хэрэглэгчНэмэхToolStripMenuItem.Name = "хэрэглэгчНэмэхToolStripMenuItem";
            this.хэрэглэгчНэмэхToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.хэрэглэгчНэмэхToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.хэрэглэгчНэмэхToolStripMenuItem.Text = "Хэрэглэгч нэмэх";
            this.хэрэглэгчНэмэхToolStripMenuItem.Click += new System.EventHandler(this.хэрэглэгчНэмэхToolStripMenuItem_Click);
            // 
            // хэрэглэгчХасахToolStripMenuItem
            // 
            this.хэрэглэгчХасахToolStripMenuItem.Name = "хэрэглэгчХасахToolStripMenuItem";
            this.хэрэглэгчХасахToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.хэрэглэгчХасахToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.хэрэглэгчХасахToolStripMenuItem.Text = "Хэрэглэгч хасах";
            this.хэрэглэгчХасахToolStripMenuItem.Click += new System.EventHandler(this.хэрэглэгчХасахToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(344, 264);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Messenger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хэрэглэгчToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хэрэглэгчНэмэхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хэрэглэгчХасахToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

