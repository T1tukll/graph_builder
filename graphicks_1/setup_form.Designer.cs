
namespace graphicks_1 {
    partial class setup_form {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setup_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_max_bord = new System.Windows.Forms.TextBox();
            this.textBox_min_bord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_min_range = new System.Windows.Forms.TrackBar();
            this.trackBar_max_range = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_grid_stp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar_grid_stp = new System.Windows.Forms.TrackBar();
            this.pictureBox_graf_prev = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip_graf_prev = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_funck = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_zoom = new System.Windows.Forms.ToolStripTextBox();
            this.textBox_function_stp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_function_stp = new System.Windows.Forms.TrackBar();
            this.button_save_cfg = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_min_range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_max_range)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_grid_stp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graf_prev)).BeginInit();
            this.contextMenuStrip_graf_prev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_function_stp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_max_bord);
            this.groupBox1.Controls.Add(this.textBox_min_bord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar_min_range);
            this.groupBox1.Controls.Add(this.trackBar_max_range);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(432, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grafick borders";
            // 
            // textBox_max_bord
            // 
            this.textBox_max_bord.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_max_bord.Location = new System.Drawing.Point(308, 132);
            this.textBox_max_bord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_max_bord.Name = "textBox_max_bord";
            this.textBox_max_bord.Size = new System.Drawing.Size(60, 26);
            this.textBox_max_bord.TabIndex = 5;
            this.textBox_max_bord.Text = "30";
            this.textBox_max_bord.TextChanged += new System.EventHandler(this.textBox_max_bord_TextChanged);
            // 
            // textBox_min_bord
            // 
            this.textBox_min_bord.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_min_bord.Location = new System.Drawing.Point(308, 25);
            this.textBox_min_bord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_min_bord.Name = "textBox_min_bord";
            this.textBox_min_bord.Size = new System.Drawing.Size(60, 26);
            this.textBox_min_bord.TabIndex = 4;
            this.textBox_min_bord.Text = "-25";
            this.textBox_min_bord.TextChanged += new System.EventHandler(this.textBox_min_bord_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maximal f(x) value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimal f(x) value";
            // 
            // trackBar_min_range
            // 
            this.trackBar_min_range.Location = new System.Drawing.Point(50, 54);
            this.trackBar_min_range.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_min_range.Maximum = 50;
            this.trackBar_min_range.Minimum = -50;
            this.trackBar_min_range.Name = "trackBar_min_range";
            this.trackBar_min_range.Size = new System.Drawing.Size(308, 69);
            this.trackBar_min_range.TabIndex = 0;
            this.trackBar_min_range.Value = -25;
            this.trackBar_min_range.Scroll += new System.EventHandler(this.trackBar_min_range_Scroll);
            // 
            // trackBar_max_range
            // 
            this.trackBar_max_range.Location = new System.Drawing.Point(50, 169);
            this.trackBar_max_range.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_max_range.Maximum = 50;
            this.trackBar_max_range.Minimum = -50;
            this.trackBar_max_range.Name = "trackBar_max_range";
            this.trackBar_max_range.Size = new System.Drawing.Size(308, 69);
            this.trackBar_max_range.TabIndex = 1;
            this.trackBar_max_range.Value = 30;
            this.trackBar_max_range.Scroll += new System.EventHandler(this.trackBar_max_range_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_grid_stp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.trackBar_grid_stp);
            this.groupBox2.Controls.Add(this.pictureBox_graf_prev);
            this.groupBox2.Controls.Add(this.textBox_function_stp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.trackBar_function_stp);
            this.groupBox2.Location = new System.Drawing.Point(18, 289);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(432, 491);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "accuracy settings";
            // 
            // textBox_grid_stp
            // 
            this.textBox_grid_stp.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_grid_stp.Location = new System.Drawing.Point(308, 132);
            this.textBox_grid_stp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_grid_stp.Name = "textBox_grid_stp";
            this.textBox_grid_stp.Size = new System.Drawing.Size(60, 26);
            this.textBox_grid_stp.TabIndex = 10;
            this.textBox_grid_stp.Text = "20";
            this.textBox_grid_stp.TextChanged += new System.EventHandler(this.textBox_grid_stp_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "grind step";
            // 
            // trackBar_grid_stp
            // 
            this.trackBar_grid_stp.LargeChange = 1;
            this.trackBar_grid_stp.Location = new System.Drawing.Point(50, 160);
            this.trackBar_grid_stp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_grid_stp.Maximum = 40;
            this.trackBar_grid_stp.Minimum = 5;
            this.trackBar_grid_stp.Name = "trackBar_grid_stp";
            this.trackBar_grid_stp.Size = new System.Drawing.Size(308, 69);
            this.trackBar_grid_stp.TabIndex = 8;
            this.trackBar_grid_stp.Value = 20;
            this.trackBar_grid_stp.Scroll += new System.EventHandler(this.trackBar_grid_stp_Scroll);
            // 
            // pictureBox_graf_prev
            // 
            this.pictureBox_graf_prev.BackColor = System.Drawing.Color.White;
            this.pictureBox_graf_prev.ContextMenuStrip = this.contextMenuStrip_graf_prev;
            this.pictureBox_graf_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_graf_prev.Location = new System.Drawing.Point(50, 238);
            this.pictureBox_graf_prev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_graf_prev.Name = "pictureBox_graf_prev";
            this.pictureBox_graf_prev.Size = new System.Drawing.Size(334, 223);
            this.pictureBox_graf_prev.TabIndex = 7;
            this.pictureBox_graf_prev.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_graf_prev, "Preview");
            this.pictureBox_graf_prev.DoubleClick += new System.EventHandler(this.pictureBox_graf_prev_DoubleClick);
            // 
            // contextMenuStrip_graf_prev
            // 
            this.contextMenuStrip_graf_prev.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_graf_prev.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawToolStripMenuItem,
            this.toolStripTextBox_funck,
            this.toolStripMenuItem1});
            this.contextMenuStrip_graf_prev.Name = "contextMenuStrip_graf_prev";
            this.contextMenuStrip_graf_prev.ShowImageMargin = false;
            this.contextMenuStrip_graf_prev.Size = new System.Drawing.Size(136, 103);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(135, 32);
            this.drawToolStripMenuItem.Text = "draw";
            this.drawToolStripMenuItem.Click += new System.EventHandler(this.drawToolStripMenuItem_Click);
            // 
            // toolStripTextBox_funck
            // 
            this.toolStripTextBox_funck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_funck.Name = "toolStripTextBox_funck";
            this.toolStripTextBox_funck.Size = new System.Drawing.Size(100, 31);
            this.toolStripTextBox_funck.Text = "sin(x)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_zoom});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 32);
            this.toolStripMenuItem1.Text = "zoom";
            // 
            // toolStripTextBox_zoom
            // 
            this.toolStripTextBox_zoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_zoom.Name = "toolStripTextBox_zoom";
            this.toolStripTextBox_zoom.Size = new System.Drawing.Size(100, 31);
            this.toolStripTextBox_zoom.Text = "1";
            // 
            // textBox_function_stp
            // 
            this.textBox_function_stp.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_function_stp.Location = new System.Drawing.Point(308, 29);
            this.textBox_function_stp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_function_stp.Name = "textBox_function_stp";
            this.textBox_function_stp.Size = new System.Drawing.Size(60, 26);
            this.textBox_function_stp.TabIndex = 6;
            this.textBox_function_stp.Text = "0.1";
            this.textBox_function_stp.TextChanged += new System.EventHandler(this.textBox_function_stp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Incremention of X";
            // 
            // trackBar_function_stp
            // 
            this.trackBar_function_stp.Location = new System.Drawing.Point(50, 62);
            this.trackBar_function_stp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_function_stp.Maximum = 200;
            this.trackBar_function_stp.Minimum = 1;
            this.trackBar_function_stp.Name = "trackBar_function_stp";
            this.trackBar_function_stp.Size = new System.Drawing.Size(308, 69);
            this.trackBar_function_stp.TabIndex = 0;
            this.trackBar_function_stp.Value = 10;
            this.trackBar_function_stp.Scroll += new System.EventHandler(this.trackBar_funcrtion_stp_Scroll);
            // 
            // button_save_cfg
            // 
            this.button_save_cfg.Location = new System.Drawing.Point(326, 800);
            this.button_save_cfg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_save_cfg.Name = "button_save_cfg";
            this.button_save_cfg.Size = new System.Drawing.Size(112, 35);
            this.button_save_cfg.TabIndex = 5;
            this.button_save_cfg.Text = "Apply";
            this.toolTip1.SetToolTip(this.button_save_cfg, "Save all changes");
            this.button_save_cfg.UseVisualStyleBackColor = true;
            this.button_save_cfg.Click += new System.EventHandler(this.button_save_cfg_Click);
            // 
            // setup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(471, 854);
            this.Controls.Add(this.button_save_cfg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setup_form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup function";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.setup_form_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_min_range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_max_range)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_grid_stp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graf_prev)).EndInit();
            this.contextMenuStrip_graf_prev.ResumeLayout(false);
            this.contextMenuStrip_graf_prev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_function_stp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_max_bord;
        private System.Windows.Forms.TextBox textBox_min_bord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_max_range;
        private System.Windows.Forms.TrackBar trackBar_min_range;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_function_stp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_function_stp;
        private System.Windows.Forms.TextBox textBox_grid_stp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar_grid_stp;
        private System.Windows.Forms.PictureBox pictureBox_graf_prev;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_graf_prev;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_funck;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_zoom;
        private System.Windows.Forms.Button button_save_cfg;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}