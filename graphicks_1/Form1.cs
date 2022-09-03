/*	
 *	I prefer not to touch this code ;)
 *	Titov, Kotov
 *	Lipetsk 2022
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace graphicks_1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			//drawGraphickToolStripMenuItem_Click(null, null);
		}
		
		Point location_clck = new Point(300,300);
		int old_funck_Gstep = -1;
		bool is_cleared = true;
		List<Point> pts = new List<Point>();

		area box_vls = new area();

		FnAutos funck_vls = new FnAutos();

		cord cord_vls = new cord();

		double CalculFormula(string Formula) {
			MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
			sc.Language = "VBScript";
			try {
				return System.Convert.ToDouble(sc.Eval(Formula));
			}
			catch {
				return .0F;
			}
		}

		List<string> GetFunctions(string func_str) {
			List<string> functions = new List<string>();    // function's array

			while (func_str != "") {
				if (func_str.Contains(";")) {    // if there are more, than 1 function
					functions.Add(func_str.Substring(0, func_str.IndexOf(';')));   // getting function till "|"
					func_str = func_str.Remove(0, func_str.IndexOf(';') + 1);  // remove this function from string list
				} else {    // if there are only one function
					functions.Add(func_str); // add it
					func_str = "";   // full clear string list
				}
			}
			return functions;
		}

		Point find_pt(int vl, List<Point> arr) {
			foreach (var i in arr) {
				if (i.X == vl) {
					return i;
				}
			}
			return new Point(-1, 300);
		}

		#region Drawing
		void draw_grid(Graphics draw_obj, Color[] colors) {
			Pen draw_pen = new Pen(colors[0], 1);

			for (int i = location_clck.X; i <= box_vls.W; i += (int)(funck_vls.Gstep)) {         // draws vertycal lines from center to right bottom
																								 //ar_line(i, 0, i, pictureBox1.Height);
				draw_obj.DrawLine(draw_pen, i, 0, i, box_vls.H);
			}
			for (int i = location_clck.X; i >= 0; i -= (int)(funck_vls.Gstep)) {                  // draws vertycal lines from center to left bottom
																								  //ar_line(i, 0, i, pictureBox1.Height);
				draw_obj.DrawLine(draw_pen, i, 0, i, box_vls.H);
			}

			for (int i = location_clck.Y; i >= 0; i -= (int)(funck_vls.Gstep)) {              // draws horysontal line from center to upper bottom
																							  //ar_line(0, i, pictureBox1.Width, i);
				draw_obj.DrawLine(draw_pen, 0, i, box_vls.W, i);
			}
			for (int i = location_clck.Y; i <= box_vls.H; i += (int)(funck_vls.Gstep)) {         // draws horysontal line from center to down bottom
																								 //ar_line(0, i, pictureBox1.Width, i);
				draw_obj.DrawLine(draw_pen, 0, i, box_vls.W, i);
			}
			//ar_pen_line.Color = Color.Blue;

			if (funck_vls.Gstep <= 10) {
				draw_pen.Width = 2;
			} else {
				draw_pen.Width = 4;
			}
			draw_pen.Color = colors[1];

			draw_obj.DrawLine(draw_pen, 0, location_clck.Y, box_vls.W, location_clck.Y);    // drawing y and x axises
			draw_obj.DrawLine(draw_pen, location_clck.X, 0, location_clck.X, box_vls.H);

			draw_obj.DrawLine(draw_pen, location_clck.X, 0, location_clck.X - 7, 20);   // drawing upper arrow
			draw_obj.DrawLine(draw_pen, location_clck.X, 0, location_clck.X + 6, 20);

			draw_obj.DrawLine(draw_pen, box_vls.W, location_clck.Y, box_vls.W - 20, location_clck.Y - 6);   // drawing right arrow
			draw_obj.DrawLine(draw_pen, box_vls.W, location_clck.Y, box_vls.W - 20, location_clck.Y + 6);

			draw_obj.DrawString("Y", toolStripLabel1.Font, Brushes.Black, location_clck.X + 6, 20); // labels on axises
			draw_obj.DrawString("X", toolStripLabel1.Font, Brushes.Black, box_vls.W - 36, location_clck.Y - 20);

			draw_pen.Width = 2;
			draw_pen.Color = Color.Green;
			draw_obj.DrawLine(draw_pen, location_clck.X - 7, location_clck.Y - funck_vls.Gstep,     // draws one value on y
								location_clck.X + 7, location_clck.Y - funck_vls.Gstep);
			draw_obj.DrawLine(draw_pen, location_clck.X + funck_vls.Gstep, location_clck.Y - 7,     // draws one value on x
								location_clck.X + funck_vls.Gstep, location_clck.Y + 7);

			draw_pen.Color = Color.Black;
			draw_obj.DrawString("1", toolStripLabel1.Font, Brushes.Black, location_clck.X - 18, location_clck.Y - funck_vls.Gstep - 10);// draws 1 on x
			draw_obj.DrawString("1", toolStripLabel1.Font, Brushes.Black, location_clck.X + funck_vls.Gstep - 6, location_clck.Y + 6);// draws 1 on y
			draw_obj.DrawString("0", toolStripLabel1.Font, Brushes.Black, location_clck.X - 15, location_clck.Y + 2);// draws 0 on the center
		}

		void draw_for_pts(List<Point> arr, Graphics draw_obj) {
			Point old_p = new Point(arr[0].X, arr[0].Y);
			foreach (var cur in arr) {
				draw_obj.DrawLine(new Pen(Color.Red, 1), old_p, cur);
				old_p = cur;
			}
		}

		void draw_funck(Graphics draw_obj, string funck_str, bool auto_bord = false, string path = "config.txt") {
			pts.Clear();
			//ar_Hwnd = draw_obj;   // drawing item is pictureBox1

			cord_vls.Xcnt = location_clck.X; // x coordinate where user has clicked (default - 300)
			cord_vls.Ycnt = location_clck.Y; // cord_vls.Y coordinate where user has clicked (default - 300)
											 //int cord_vls.Xold = 0, cord_vls.Yold = 0;

			funck_vls.Fstep = 0.1;//Convert.ToDouble(toolStripTextBox_fStep.Text.Replace('.', ','));       // accuracy or incremention step
			funck_vls.Gstep = 20;//Convert.ToInt32(toolStripTextBox_grStep.Text);  // size of one sub pixel
			funck_vls.Scale = Convert.ToDouble(toolStripTextBox_zoom.Text.Replace('.', ','));        // scale


			if (File.Exists(path) && !auto_bord) {      // load config without auto bord
				set_cfg(ref funck_vls.MinBord, ref funck_vls.MaxBord, ref funck_vls.Fstep, ref funck_vls.Gstep, path);
			} else if (File.Exists(path)) { // load config with auto bord
				double a = 0, b = 0;
				set_cfg(ref a, ref b, ref funck_vls.Fstep, ref funck_vls.Gstep, path);
			}

			bool cycle = true;  // for 1st empty cycle 
			if (old_funck_Gstep != funck_vls.Gstep || is_cleared) {
				draw_obj.Clear(Color.White);    // super mega ultra crutch
				draw_grid(draw_obj, new Color[] { Color.Gray, Color.Blue });
			}
			
			double absolute_vl;	// for absolute value (percentage)
			if (funck_vls.MinBord < 0 && funck_vls.MaxBord < 0) {
				absolute_vl = Math.Abs(funck_vls.MinBord);
			} else {
				absolute_vl = 0;
			}
			
			for (double x = funck_vls.MinBord; x <= funck_vls.MaxBord; x += funck_vls.Fstep) {
				cord_vls.Y = CalculFormula(funck_str.Replace("x", Convert.ToString(x+.0000001)).Replace(",", "."));
				
				// приведение к масштабу Image
				cord_vls.Xdig = (int)Math.Round(cord_vls.Xcnt + x * funck_vls.Gstep * funck_vls.Scale);
				cord_vls.Ydig = (int)Math.Round(cord_vls.Ycnt - cord_vls.Y * funck_vls.Gstep * funck_vls.Scale);

				

				if (!cycle && cord_vls.Y != 0.0F &&
					(Math.Abs(cord_vls.Y + 1) <= box_vls.H || Math.Abs(cord_vls.Ydig + 1) <= box_vls.H)) {

					//ar_line(cord_vls.Xold, cord_vls.Yold, cord_vls.Xdig, cord_vls.Ydig);        //regular iteration
					draw_obj.DrawLine(new Pen(Color.Red,1), cord_vls.Xold, cord_vls.Yold, cord_vls.Xdig, cord_vls.Ydig);
					pts.Add(new Point(cord_vls.Xdig,cord_vls.Ydig));
					
					if(funck_vls.MinBord < 0 && funck_vls.MaxBord < 0) {
						toolStripProgressBar1.Value = (int)Math.Round((absolute_vl - Math.Abs(funck_vls.MinBord)) * 100 / Math.Abs(funck_vls.MaxBord - funck_vls.MinBord));
					} else {
						toolStripProgressBar1.Value = (int)Math.Round(absolute_vl * 100 / Math.Abs(funck_vls.MaxBord - funck_vls.MinBord));
					}
					//toolStripProgressBar1.Value = (int)Math.Round((double)cord_vls.Xdig / absolute_vl * 100);	// percentage calculating
					
					if(Math.Round(x) % 6 == 0) {
						pictureBox1.Refresh();	//refresh every 6-th x
					}

					cord_vls.Xold = cord_vls.Xdig;
					cord_vls.Yold = cord_vls.Ydig;
					//absolute_vl += funck_vls.Fstep;

				} else if (cord_vls.Y != 0.0F && (Math.Abs(cord_vls.Y + 1) <= box_vls.H || Math.Abs(cord_vls.Ydig + 1) <= box_vls.H)) {
					cord_vls.Yold = cord_vls.Ydig;            // first iteration, wich'll never repeat
					cord_vls.Xold = cord_vls.Xdig;
					cycle = false;
					//absolute_vl += funck_vls.Fstep;
				} else {
					//absolute_vl += funck_vls.Fstep;
				}
				absolute_vl += funck_vls.Fstep;

			}
			pictureBox1.Refresh();  // refresh pictureBox after all actions
									//toolStripTextBox1.Text = gg.ToString();	// debug info
			old_funck_Gstep = funck_vls.Gstep;
			is_cleared = false;
		}

		void draw_funck_reverse(Graphics draw_obj, string funck_str, bool auto_bord = false, string path = "config.txt") {
			pts.Clear();
			//ar_Hwnd = draw_obj;   // drawing item is pictureBox1

			cord_vls.Xcnt = location_clck.X; // x coordinate where user has clicked (default - 300)
			cord_vls.Ycnt = location_clck.Y; // cord_vls.Y coordinate where user has clicked (default - 300)
											 //int cord_vls.Xold = 0, cord_vls.Yold = 0;

			funck_vls.Fstep = 0.1;//Convert.ToDouble(toolStripTextBox_fStep.Text.Replace('.', ','));       // accuracy or incremention step
			funck_vls.Gstep = 20;//Convert.ToInt32(toolStripTextBox_grStep.Text);  // size of one sub pixel
			funck_vls.Scale = Convert.ToDouble(toolStripTextBox_zoom.Text.Replace('.', ','));        // scale


			if (File.Exists(path) && !auto_bord) {      // load config without auto bord
				set_cfg(ref funck_vls.MinBord, ref funck_vls.MaxBord, ref funck_vls.Fstep, ref funck_vls.Gstep, path);
			} else if (File.Exists(path)) { // load config with auto bord
				double a = 0, b = 0;
				set_cfg(ref a, ref b, ref funck_vls.Fstep, ref funck_vls.Gstep, path);
			}
			//long absolute_vl = (long)(( Math.Abs(funck_vls.MaxBord) - Math.Abs(funck_vls.MinBord))*funck_vls.Gstep);

			bool cycle = true;  // for 1st empty cycle 
			if (old_funck_Gstep != funck_vls.Gstep || is_cleared) {
				draw_obj.Clear(Color.White);    // super mega ultra crutch
				draw_grid(draw_obj, new Color[] { Color.Gray, Color.Blue });
			}

			double absolute_vl;  // for absolute value (percentage)
			if (funck_vls.MinBord < 0 && funck_vls.MaxBord < 0) {
				absolute_vl = Math.Abs(funck_vls.MinBord);
			} else {
				absolute_vl = 0;
			}

			for (double x = funck_vls.MinBord; x >= funck_vls.MaxBord; x -= funck_vls.Fstep) {
				cord_vls.Y = CalculFormula(funck_str.Replace("x", Convert.ToString(x+.0000001)).Replace(",", "."));

				// приведение к масштабу Image
				cord_vls.Xdig = (int)Math.Round(cord_vls.Xcnt + x * funck_vls.Gstep * funck_vls.Scale);
				cord_vls.Ydig = (int)Math.Round(cord_vls.Ycnt - cord_vls.Y * funck_vls.Gstep * funck_vls.Scale);

				

				if (!cycle && cord_vls.Y != 0.0F &&
					(Math.Abs(cord_vls.Y + 1) <= box_vls.H || Math.Abs(cord_vls.Ydig + 1) <= box_vls.H)) {

					draw_obj.DrawLine(new Pen(Color.Red, 1), cord_vls.Xold, cord_vls.Yold, cord_vls.Xdig, cord_vls.Ydig);
					pts.Add(new Point(cord_vls.Xdig, cord_vls.Ydig));
					if (funck_vls.MinBord < 0 && funck_vls.MaxBord < 0) {
						toolStripProgressBar1.Value = (int)Math.Round((absolute_vl - Math.Abs(funck_vls.MaxBord)) * 100 / Math.Abs(funck_vls.MinBord - funck_vls.MaxBord));
					} else {
						toolStripProgressBar1.Value = (int)Math.Round(absolute_vl * 100 / Math.Abs(funck_vls.MinBord - funck_vls.MaxBord));
					}


					if (Math.Round(x) % 6 == 0) {
						pictureBox1.Refresh();  //refresh every 6-th x
					}

					cord_vls.Xold = cord_vls.Xdig;
					cord_vls.Yold = cord_vls.Ydig;
					absolute_vl += funck_vls.Fstep;
				} else if (cord_vls.Y != 0.0F && (Math.Abs(cord_vls.Y + 1) <= box_vls.H || Math.Abs(cord_vls.Ydig + 1) <= box_vls.H)) {
					cord_vls.Yold = cord_vls.Ydig;            // first iteration, wich'll never repeat
					cord_vls.Xold = cord_vls.Xdig;
					cycle = false;
					absolute_vl += funck_vls.Fstep;
				} else {
					absolute_vl += funck_vls.Fstep;
				}
			}
			pictureBox1.Refresh();  // refresh pictureBox after all actions
									//toolStripTextBox1.Text = gg.ToString();	// debug info
			old_funck_Gstep = funck_vls.Gstep;
			is_cleared = false;
		}
		#endregion

		#region Config works
		void set_cfg(ref double min_bord, ref double max_bord, ref double inck, ref int pxl,
								string path = "config.txt") {
			var file = new FileStream(path, FileMode.Open, FileAccess.Read);	// create object file
			var reader = new StreamReader(file);	// create object which reads file


			while (reader.EndOfStream == false) {
				string temp_str = reader.ReadLine();
				if (!temp_str.Contains("=")) {
					continue;
				}
				for (int i = 0; i < temp_str.Length; ++i) {
					if (temp_str[i] == ' ') {
						temp_str = temp_str.Remove(i, 1);
					}
				}

				string tmp = temp_str.Substring(0, temp_str.IndexOf('='));	// value's name

				switch (tmp) {
					case "max_border":
						temp_str = temp_str.Remove(0, temp_str.IndexOf('=') + 1);	// erase string till value
						max_bord = Convert.ToDouble(temp_str.Replace(".", ","));
						break;
					case "min_border":
						temp_str = temp_str.Remove(0, temp_str.IndexOf('=') + 1);   // erase string till value
						min_bord = Convert.ToDouble(temp_str);
						break;
					case "incremention":
						temp_str = temp_str.Remove(0, temp_str.IndexOf('=') + 1);   // erase string till value
						inck = Convert.ToDouble(temp_str.Replace(".", ","));
						break;
					case "pixel_size":
						temp_str = temp_str.Remove(0, temp_str.IndexOf('=') + 1);   // erase string till value
						pxl = Convert.ToInt32(temp_str);
						break;
				}
			}
			reader.Close();
			file.Close();
		}
		#endregion

		private void drawGraphickToolStripMenuItem_Click(object sender, EventArgs e) {
			//MessageBox.Show("нихуя (0р. 0к.)","супер мега калькулятор (починитый)");
			pts.Clear();
			if (pictureBox1.Image.Width != pictureBox1.Width && pictureBox1.Image.Height != pictureBox1.Height) {
				pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
				is_cleared = true;
			}
			box_vls.H = pictureBox1.Height;
			box_vls.W = pictureBox1.Width;

			funck_vls.MinBord = -25;
			funck_vls.MaxBord = 25;


			if (File.Exists(Properties.Settings.Default.path)) {
				set_cfg(ref funck_vls.MinBord, ref funck_vls.MaxBord, ref funck_vls.Fstep, ref funck_vls.Gstep, Properties.Settings.Default.path);
			}
			
			if (funck_vls.MinBord < funck_vls.MaxBord) {
				foreach (string i in GetFunctions(toolStripTextBox1.Text)) {
					draw_funck(Graphics.FromImage(pictureBox1.Image), i, false, Properties.Settings.Default.path);   // drawing grafick for every function
				}
			} else {
				foreach (string i in GetFunctions(toolStripTextBox1.Text)) {
					draw_funck_reverse(Graphics.FromImage(pictureBox1.Image), i, false, Properties.Settings.Default.path);   // drawing grafick for every function
				}
			}
		
			
			//draw_funck(Graphics.FromImage(pictureBox1.Image), toolStripTextBox1.Text,min_bord,max_bord);
			toolStripLabel_graf_r.Visible = true;   // notify in toolStrip bar
			toolStripSeparator2.Visible = true;
			timer_funck_r.Enabled = true;
		}

		private void pictureBox1_DoubleClick(object sender, EventArgs e) {  // grafick with auto bordering
			pts.Clear();
			if (pictureBox1.Image.Width != pictureBox1.Width && pictureBox1.Image.Height != pictureBox1.Height) {
				pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
				is_cleared = true;
			}	

			funck_vls.Fstep = .1;
			funck_vls.Gstep = 20;

			box_vls.H = pictureBox1.Height;
			box_vls.W = pictureBox1.Width;

			if (File.Exists(Properties.Settings.Default.path)) {
				set_cfg(ref funck_vls.MinBord, ref funck_vls.MaxBord, ref funck_vls.Fstep, ref funck_vls.Gstep, Properties.Settings.Default.path);
			}

			funck_vls.MaxBord = (pictureBox1.Width - location_clck.X) / funck_vls.Gstep / Convert.ToDouble(toolStripTextBox_zoom.Text.Replace('.',','));
			funck_vls.MinBord = -location_clck.X / funck_vls.Gstep / Convert.ToDouble(toolStripTextBox_zoom.Text.Replace('.', ','));
			
			foreach (string i in GetFunctions(toolStripTextBox1.Text)) {
				draw_funck(Graphics.FromImage(pictureBox1.Image), i, true, Properties.Settings.Default.path);   // drawing grafick for every function
			}
			toolStripLabel_graf_r.Visible = true;   // notify in toolStrip bar
			toolStripSeparator2.Visible = true;
			timer_funck_r.Enabled = true;
		}


		private void clearAllToolStripMenuItem_Click(object sender, EventArgs e) {
			Graphics cleaner = Graphics.FromImage(pictureBox1.Image);
			cleaner.Clear(Color.White);
			is_cleared = true;
			pictureBox1.Refresh();
		}

		private void pictureBox1_MouseClick(object sender, MouseEventArgs e) {

			if (panel_drop_down.Visible) {
				panel_drop_down.Visible = false;
				return;
			}

			Graphics cleaner = Graphics.FromImage(pictureBox1.Image);
			cleaner.Clear(Color.White);
			location_clck = e.Location;
			/*
			  ar_line(e.X + 5, e.Y + 5, e.X - 5, e.Y - 5);
			  ar_line(e.X + 5, e.Y - 5, e.X - 5, e.Y + 5);*/
			cleaner.DrawLine(new Pen(Color.Green, 1), e.X + 5, e.Y + 5, e.X - 5, e.Y - 5);
			cleaner.DrawLine(new Pen(Color.Green, 1), e.X + 5, e.Y - 5, e.X - 5, e.Y + 5);
			pictureBox1.Refresh();
			is_cleared = true;
		}
		

		private void saveAsbmpToolStripMenuItem_Click(object sender, EventArgs e) {
			if(pictureBox1.Image == null) {
				return;
			}			

			SaveFileDialog save_dialog = new SaveFileDialog();

			save_dialog.Title = "Save title as";
			save_dialog.OverwritePrompt = true;
			save_dialog.CheckPathExists = true;
			save_dialog.Filter = "Image files(*.png)|*.png";
			if(save_dialog.ShowDialog() == DialogResult.OK) {
				try {
					Graphics draw_obj = Graphics.FromImage(pictureBox1.Image);
					draw_obj.DrawString("Graph builder\nTitov, Kotov\nLipetsk, 2022", toolStripLabel1.Font, Brushes.Black, 0, pictureBox1.Height - 60);
					pictureBox1.Image.Save(save_dialog.FileName);
				}
				catch {
					MessageBox.Show("Save fatal error", "Ошибка" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void openSettingToolStripMenuItem_Click_1(object sender, EventArgs e) {
			if(Application.OpenForms["Setup Function"] == null) {
				new setup_form().Show();
			}
		}

		private void timer_funck_r_Tick(object sender, EventArgs e) {
			toolStripLabel_graf_r.Visible = false;	// notyfication drawing was end
			toolStripSeparator2.Visible = false;
			timer_funck_r.Enabled = false;
		}

		private void ToolStripMenuItem_change_cond_Click(object sender, EventArgs e) {
			if(this.Visible == true) {
				
				//Application.OpenForms["Welcome"].Close();
				//guide_form.ActiveForm.Activate();
				this.Hide();
				ToolStripMenuItem_change_cond.Text = "Show back";
			} else {
				this.Show();
				if (Application.OpenForms["Setup Function"] == null) {
					new setup_form().Show();
				}
				if(Application.OpenForms["Welcome"] == null) {
					new guide_form().Show();
				}
				ToolStripMenuItem_change_cond.Text = "Minimise to tray";
			}
		}

		private void ToolStripMenuItem_exit_Click(object sender, EventArgs e) {
			Close();
		}

		private void timer_guide_show_Tick(object sender, EventArgs e) {
			if (Properties.Settings.Default.show_guide) {
				new guide_form().Show();
			}
			timer_guide_show.Enabled = false;
		}

		private void toolStripMenuItem_show_guide_Click(object sender, EventArgs e) {
			if(Application.OpenForms["guide_form"] == null) {
				new guide_form().Show();
			}
		}
		#region Drag Works
		private void Form1_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) { 
			panel_drop_down.Visible = true;
			}
		}

		private void panel_drop_down_DragDrop(object sender, DragEventArgs e) {
			string[] temp = (string[])e.Data.GetData(DataFormats.FileDrop);
			Properties.Settings.Default.path = temp[0];
			Properties.Settings.Default.Save();
			panel_drop_down.Visible = false;
		}

		private void panel_drop_down_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
				e.Effect = DragDropEffects.Copy;
			}
		}
		#endregion

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
			if (find_pt(e.X, pts).X != -1 && !is_cleared && toolStripMenuItem_guideline.Checked) {
				Graphics draw_obj = Graphics.FromImage(pictureBox1.Image);
				Pen draw_pen = new Pen(Color.Black, 1);

				draw_obj.Clear(Color.White);
				
				draw_grid(draw_obj, new Color[] { Color.Gray, Color.Blue });

				draw_for_pts(pts, draw_obj);

				draw_obj.DrawLine(draw_pen, e.X, location_clck.Y, e.X, find_pt(e.X, pts).Y);	// vertycal line

				//draw_obj.DrawLine(draw_pen, 0, e.Y, e.X, e.Y);
				draw_obj.DrawLine(draw_pen, e.X, find_pt(e.X, pts).Y, location_clck.X, find_pt(e.X, pts).Y);	// horisontal line

				//draw_obj.DrawLine(draw_pen, e.X, pictureBox1.Height, e.X, e.Y);
				draw_obj.DrawString("X " + ((double)((e.X - location_clck.X) / funck_vls.Gstep / funck_vls.Scale)).ToString() + " Y " +
					(CalculFormula(GetFunctions(toolStripTextBox1.Text)[0].Replace("x", ((e.X - location_clck.X) / funck_vls.Gstep / funck_vls.Scale).ToString()))).ToString(),    // y only
					new Font("Courier New", 12), Brushes.Black, e.X, find_pt(e.X, pts).Y - 15);

				//draw_obj.DrawString(e.X.ToString() + ", " + e.Y.ToString(), new Font("Courier New", 12), Brushes.Black, e.X, e.Y-10);
				pictureBox1.Refresh();
			}
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
			if(e.KeyChar == (char)Keys.Enter) {
				drawGraphickToolStripMenuItem_Click(null, null);
			}
		}

		private void toolStripMenuItem_guideline_Click(object sender, EventArgs e) {
			if (toolStripMenuItem_guideline.Checked) {
				toolStripMenuItem_guideline.Checked = false;
			} else {
				toolStripMenuItem_guideline.Checked = true;
			}
		}
	}
}