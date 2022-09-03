
namespace graphicks_1 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawGraphickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsbmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_zoom = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem_guideline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_graf_r = new System.Windows.Forms.ToolStripLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_notify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_change_cond = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_show_guide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_funck_r = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer_guide_show = new System.Windows.Forms.Timer(this.components);
            this.panel_drop_down = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip_notify.SuspendLayout();
            this.panel_drop_down.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1444, 979);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawGraphickToolStripMenuItem,
            this.saveAsbmpToolStripMenuItem,
            this.clearAllToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.toolStripMenuItem_guideline});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 164);
            // 
            // drawGraphickToolStripMenuItem
            // 
            this.drawGraphickToolStripMenuItem.Name = "drawGraphickToolStripMenuItem";
            this.drawGraphickToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.drawGraphickToolStripMenuItem.Text = "draw graph";
            this.drawGraphickToolStripMenuItem.Click += new System.EventHandler(this.drawGraphickToolStripMenuItem_Click);
            // 
            // saveAsbmpToolStripMenuItem
            // 
            this.saveAsbmpToolStripMenuItem.Name = "saveAsbmpToolStripMenuItem";
            this.saveAsbmpToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.saveAsbmpToolStripMenuItem.Text = "save as *.png";
            this.saveAsbmpToolStripMenuItem.Click += new System.EventHandler(this.saveAsbmpToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.clearAllToolStripMenuItem.Text = "clear all";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_zoom});
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.scaleToolStripMenuItem.Text = "scale";
            // 
            // toolStripTextBox_zoom
            // 
            this.toolStripTextBox_zoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_zoom.Name = "toolStripTextBox_zoom";
            this.toolStripTextBox_zoom.Size = new System.Drawing.Size(100, 31);
            this.toolStripTextBox_zoom.Text = "1";
            // 
            // toolStripMenuItem_guideline
            // 
            this.toolStripMenuItem_guideline.Name = "toolStripMenuItem_guideline";
            this.toolStripMenuItem_guideline.Size = new System.Drawing.Size(203, 32);
            this.toolStripMenuItem_guideline.Text = "show guideline";
            this.toolStripMenuItem_guideline.Click += new System.EventHandler(this.toolStripMenuItem_guideline_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripProgressBar1,
            this.toolStripSeparator2,
            this.toolStripLabel_graf_r});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1444, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(95, 34);
            this.toolStripLabel1.Text = "Function";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(343, 39);
            this.toolStripTextBox1.Text = "log(x)*sin(x)";
            this.toolStripTextBox1.ToolTipText = "Paste your function here";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 34);
            this.toolStripProgressBar1.ToolTipText = "Function drawing progress";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator2.Visible = false;
            // 
            // toolStripLabel_graf_r
            // 
            this.toolStripLabel_graf_r.Name = "toolStripLabel_graf_r";
            this.toolStripLabel_graf_r.Size = new System.Drawing.Size(151, 34);
            this.toolStripLabel_graf_r.Text = "Function is ready!";
            this.toolStripLabel_graf_r.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 958);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "Graph builder\r\nTitov, Kotov\r\nLipetsk, 2022";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label2, "Programm\'s creators");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip_notify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Advanced";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip_notify
            // 
            this.contextMenuStrip_notify.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSettingToolStripMenuItem,
            this.ToolStripMenuItem_change_cond,
            this.toolStripMenuItem_show_guide,
            this.toolStripSeparator3,
            this.ToolStripMenuItem_exit});
            this.contextMenuStrip_notify.Name = "contextMenuStrip_notify";
            this.contextMenuStrip_notify.ShowImageMargin = false;
            this.contextMenuStrip_notify.Size = new System.Drawing.Size(188, 138);
            // 
            // openSettingToolStripMenuItem
            // 
            this.openSettingToolStripMenuItem.Name = "openSettingToolStripMenuItem";
            this.openSettingToolStripMenuItem.Size = new System.Drawing.Size(187, 32);
            this.openSettingToolStripMenuItem.Text = "open setting";
            this.openSettingToolStripMenuItem.Click += new System.EventHandler(this.openSettingToolStripMenuItem_Click_1);
            // 
            // ToolStripMenuItem_change_cond
            // 
            this.ToolStripMenuItem_change_cond.Name = "ToolStripMenuItem_change_cond";
            this.ToolStripMenuItem_change_cond.Size = new System.Drawing.Size(187, 32);
            this.ToolStripMenuItem_change_cond.Text = "Minimize to tray";
            this.ToolStripMenuItem_change_cond.Click += new System.EventHandler(this.ToolStripMenuItem_change_cond_Click);
            // 
            // toolStripMenuItem_show_guide
            // 
            this.toolStripMenuItem_show_guide.Name = "toolStripMenuItem_show_guide";
            this.toolStripMenuItem_show_guide.Size = new System.Drawing.Size(187, 32);
            this.toolStripMenuItem_show_guide.Text = "Show guide";
            this.toolStripMenuItem_show_guide.Click += new System.EventHandler(this.toolStripMenuItem_show_guide_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(187, 32);
            this.ToolStripMenuItem_exit.Text = "exit";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // timer_funck_r
            // 
            this.timer_funck_r.Interval = 1500;
            this.timer_funck_r.Tick += new System.EventHandler(this.timer_funck_r_Tick);
            // 
            // timer_guide_show
            // 
            this.timer_guide_show.Enabled = true;
            this.timer_guide_show.Tick += new System.EventHandler(this.timer_guide_show_Tick);
            // 
            // panel_drop_down
            // 
            this.panel_drop_down.AllowDrop = true;
            this.panel_drop_down.BackColor = System.Drawing.Color.Gray;
            this.panel_drop_down.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_drop_down.Controls.Add(this.label1);
            this.panel_drop_down.Location = new System.Drawing.Point(422, 258);
            this.panel_drop_down.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_drop_down.Name = "panel_drop_down";
            this.panel_drop_down.Size = new System.Drawing.Size(553, 359);
            this.panel_drop_down.TabIndex = 6;
            this.panel_drop_down.Visible = false;
            this.panel_drop_down.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_drop_down_DragDrop);
            this.panel_drop_down.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_drop_down_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35.25F);
            this.label1.Location = new System.Drawing.Point(50, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drop file here";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1444, 1018);
            this.Controls.Add(this.panel_drop_down);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph builder 1.1";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip_notify.ResumeLayout(false);
            this.panel_drop_down.ResumeLayout(false);
            this.panel_drop_down.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem drawGraphickToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem saveAsbmpToolStripMenuItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_notify;
		private System.Windows.Forms.ToolStripMenuItem openSettingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_change_cond;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_graf_r;
        private System.Windows.Forms.Timer timer_funck_r;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_zoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer_guide_show;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_show_guide;
        private System.Windows.Forms.Panel panel_drop_down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_guideline;
    }
}

