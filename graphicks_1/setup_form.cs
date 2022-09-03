/*	
 *	Titov, Kotov
 *	Lipetsk 2022
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace graphicks_1 {
	public partial class setup_form : Form {
		public setup_form() {
			InitializeComponent();
			pictureBox_graf_prev.Image = new Bitmap(pictureBox_graf_prev.Width, pictureBox_graf_prev.Height);
			if (File.Exists(Properties.Settings.Default.path)) {
				FnAutos track_bar_vls = new FnAutos();

				set_cfg(ref track_bar_vls.MinBord, ref track_bar_vls.MaxBord, ref track_bar_vls.Fstep, ref track_bar_vls.Gstep, Properties.Settings.Default.path);
				set_text_boxes(track_bar_vls);
				set_track_bars(track_bar_vls);
			}
		}

		int old_funck_Gstep = -1;
		bool is_cleared = true;

        #region Load Synchronisation
        void set_text_boxes(FnAutos text_box_vls) {
			textBox_min_bord.Text = text_box_vls.MinBord.ToString();
			textBox_max_bord.Text = text_box_vls.MaxBord.ToString();
			textBox_function_stp.Text = text_box_vls.Fstep.ToString();
			textBox_grid_stp.Text = text_box_vls.Gstep.ToString();
		}
		void set_track_bars(FnAutos track_bar_vls) {
			
			//setting trackBar_min_range
			if (track_bar_vls.MinBord < trackBar_min_range.Minimum) {
				trackBar_min_range.Value = trackBar_min_range.Minimum;
			} else if (track_bar_vls.MinBord > trackBar_min_range.Maximum) {
				trackBar_min_range.Value = trackBar_min_range.Maximum;
			} else {
				trackBar_min_range.Value = (int)track_bar_vls.MinBord;
			}

			//setting trackBar_max_range
			if (track_bar_vls.MaxBord < trackBar_max_range.Minimum) {
				trackBar_max_range.Value = trackBar_max_range.Minimum;
			} else if (track_bar_vls.MaxBord > trackBar_max_range.Maximum) {
				trackBar_max_range.Value = trackBar_max_range.Maximum;
			} else {
				trackBar_max_range.Value = (int)track_bar_vls.MaxBord;
			}

			//setting trackBar_grid_stp
			if (track_bar_vls.Gstep < trackBar_grid_stp.Minimum) {
				trackBar_grid_stp.Value = trackBar_grid_stp.Minimum;
			} else if (track_bar_vls.Gstep > trackBar_grid_stp.Maximum) {
				trackBar_grid_stp.Value = trackBar_grid_stp.Maximum;
			} else {
				trackBar_grid_stp.Value = (int)track_bar_vls.Gstep;
			}

			//setting trackBar_funcrtion_stp
			if (track_bar_vls.Fstep*100 < trackBar_function_stp.Minimum) {
				trackBar_function_stp.Value = trackBar_function_stp.Minimum;
			} else if (track_bar_vls.Fstep*100 > trackBar_function_stp.Maximum) {
				trackBar_function_stp.Value = trackBar_function_stp.Maximum;
			} else {
				trackBar_function_stp.Value = (int)(track_bar_vls.Fstep*100);
			}
		}
        #endregion

        private double CalculFormula(string Formula) {
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

		void graph_grid(Graphics draw_obj, area box_vls, Color[] colors, FnAutos funk_vls, cord cord_vls) {
			Pen draw_pen = new Pen(colors[0], 1);

			for (int i = cord_vls.Xcnt; i <= box_vls.W; i += (int)(funk_vls.Gstep * funk_vls.Scale)) {         // draws vertycal lines from center to right bottom
				draw_obj.DrawLine(draw_pen, i, 0, i, box_vls.H);
			}
			for (int i = cord_vls.Xcnt; i >= 0; i -= (int)(funk_vls.Gstep * funk_vls.Scale)) {                  // draws vertycal lines from center to left bottom
				draw_obj.DrawLine(draw_pen, i, 0, i, box_vls.H);
			}

			for (int i = cord_vls.Ycnt; i >= 0; i -= (int)(funk_vls.Gstep * funk_vls.Scale)) {              // draws horysontal line from center to upper bottom
				draw_obj.DrawLine(draw_pen, 0, i, box_vls.W, i);
			}
			for (int i = cord_vls.Ycnt; i <= box_vls.H; i += (int)(funk_vls.Gstep * funk_vls.Scale)) {         // draws horysontal line from center to down bottom
				draw_obj.DrawLine(draw_pen, 0, i, box_vls.W, i);
			}
			//ar_pen_line.Color = Color.Blue;
			if (funk_vls.Gstep * funk_vls.Scale <= 10) {
				draw_pen.Width = 2;
			} else {
				draw_pen.Width = 3;
			}
			draw_pen.Color = colors[1];
			draw_obj.DrawLine(draw_pen, 0, cord_vls.Ycnt, box_vls.W, cord_vls.Ycnt);
			draw_obj.DrawLine(draw_pen, cord_vls.Xcnt, 0, cord_vls.Xcnt, box_vls.H);
			//ar_line(0, cord_vls.Ycnt, pictureBox1.Width, cord_vls.Ycnt, thickness);		// draws horisontal line (x)
			//ar_line(cord_vls.Xcnt, 0, cord_vls.Xcnt, pictureBox1.Height, thickness);           // draws vertycal line (cord_vls.Y)
		}

		private void draw_funck(Graphics draw_obg, string funck_str, double min_bord = -3, double max_bord = 10) {
			FnAutos funk_vls = new FnAutos();
			cord cord_vls = new cord();
			area box_vls = new area();

			box_vls.H = pictureBox_graf_prev.Height;
			box_vls.W = pictureBox_graf_prev.Width;

			cord_vls.Xcnt = pictureBox_graf_prev.Width / 2;	// central x
			cord_vls.Ycnt = pictureBox_graf_prev.Height / 2;	// central y

			funk_vls.Gstep = Convert.ToInt32(textBox_grid_stp.Text); // grid's step value
			funk_vls.Fstep = Convert.ToDouble(textBox_function_stp.Text.Replace('.', ','));    // function's accuracy
			funk_vls.Scale = Convert.ToDouble(toolStripTextBox_zoom.Text.Replace('.', ','));	// functions's Scale

			bool cycle = false;
			if(old_funck_Gstep != funk_vls.Gstep || is_cleared) {
				graph_grid(draw_obg,box_vls, new Color[] { Color.Gray, Color.Blue }, funk_vls, cord_vls);	// draws function grid
			}
			

			for(double x = min_bord; x <= max_bord; x += funk_vls.Fstep) {
				cord_vls.Y = CalculFormula(funck_str.Replace("x",Convert.ToString(x+.00001)).Replace(',', '.')); // calck analog y value
	
				cord_vls.Xdig = (int)Math.Round(cord_vls.Xcnt + x * funk_vls.Scale * funk_vls.Gstep);	// x's digital value
				cord_vls.Ydig = (int)Math.Round(cord_vls.Ycnt - cord_vls.Y * funk_vls.Scale * funk_vls.Gstep);    // y's digital value

				if (cycle && cord_vls.Y != .0F && 
					(Math.Abs(cord_vls.Ydig+1) <= pictureBox_graf_prev.Height || Math.Abs(cord_vls.Yold+1) <= pictureBox_graf_prev.Height)) {
					draw_obg.DrawLine(new Pen(Color.Red,1), cord_vls.Xold, cord_vls.Yold, cord_vls.Xdig, cord_vls.Ydig);
					//graph_line(draw_obg, Color.Red, cord_vls.Xold, cord_vls.Yold, cord_vls.Xdig, cord_vls.Ydig);  // draw micro line
					if(x % 6 == 0) {
						pictureBox_graf_prev.Refresh();	// refresh every 6-th x
					}
					cord_vls.Yold = cord_vls.Ydig;
					cord_vls.Xold = cord_vls.Xdig;

				} else if (cord_vls.Y != .0F && (cord_vls.Ydig <= pictureBox_graf_prev.Height || cord_vls.Yold <= pictureBox_graf_prev.Height)) {
					cycle = true;
					cord_vls.Yold = cord_vls.Ydig;
					cord_vls.Xold = cord_vls.Xdig;
				}
			}
			pictureBox_graf_prev.Refresh();
			is_cleared = false;
			old_funck_Gstep = funk_vls.Gstep;
		}
		private void set_cfg(ref double min_bord, ref double max_bord, ref double inck, ref int pxl,
								string path = "config.txt") {
			var file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
			var reader = new StreamReader(file);

			string temp_str;

			while (reader.EndOfStream == false) {
				temp_str = reader.ReadLine();
				if (!temp_str.Contains("=")) {
					continue;
				}
				for(int i = 0; i < temp_str.Length; ++i) {
					if(temp_str[i] == ' ') {
						temp_str = temp_str.Remove(i, 1);
					}
				}

				string tmp = temp_str.Substring(0, temp_str.IndexOf('='));

				switch (tmp) {
					case "max_border":
						temp_str = temp_str.Remove(0, temp_str.IndexOf('=') + 1);
						max_bord = Convert.ToDouble(temp_str.Replace(".", ","));
						break;
					case "min_border":
						temp_str = temp_str.Remove(0, temp_str.IndexOf('=') + 1);
						min_bord = Convert.ToDouble(temp_str);
						break;
					case "incremention":
						temp_str = temp_str.Remove(0, temp_str.IndexOf('=') + 1);
						inck = Convert.ToDouble(temp_str.Replace(".", ","));
						break;
					case "pixel_size":
						temp_str = temp_str.Remove(0, temp_str.IndexOf('=') + 1);
						pxl = Convert.ToInt32(temp_str);
						break;
				}
			}
			reader.Close();
			file.Close();
		}
		private void write_cfg(double min_bord, double max_bord, double inck, int pxl,
								string path = "config.txt") {
			var file = new FileStream(path, FileMode.Create, FileAccess.Write);
			var writer = new StreamWriter(file);

			writer.Write("max_border=" + Convert.ToString(max_bord) + '\n'
						+ "min_border=" + Convert.ToString(min_bord) + '\n'
						+ "incremention=" + Convert.ToString(inck) + '\n'
						+ "pixel_size=" + Convert.ToString(pxl));

			writer.Close();
			file.Close();
		}

        #region Track Bars changing
        private void trackBar_max_range_Scroll(object sender, EventArgs e) {
			textBox_max_bord.Text = trackBar_max_range.Value.ToString();
		}

		private void trackBar_min_range_Scroll(object sender, EventArgs e) {
			textBox_min_bord.Text = trackBar_min_range.Value.ToString();
		}

		private void trackBar_funcrtion_stp_Scroll(object sender, EventArgs e) {
			textBox_function_stp.Text = Convert.ToString((double)trackBar_function_stp.Value / 100);
		}

		private void trackBar_grid_stp_Scroll(object sender, EventArgs e) {
			textBox_grid_stp.Text = trackBar_grid_stp.Value.ToString();
		}
        #endregion
        private void drawToolStripMenuItem_Click(object sender, EventArgs e) {
			double max_bord = pictureBox_graf_prev.Width / trackBar_grid_stp.Value;
			double min_bord = pictureBox_graf_prev.Width / 2 / trackBar_grid_stp.Value;

			foreach (var i in GetFunctions(toolStripTextBox_funck.Text)) {
				draw_funck(Graphics.FromImage(pictureBox_graf_prev.Image), i, -min_bord, max_bord);
			}
		}

		
		private void pictureBox_graf_prev_DoubleClick(object sender, EventArgs e) {
			Graphics cleaner = Graphics.FromImage(pictureBox_graf_prev.Image);
			cleaner.Clear(Color.White);
			is_cleared = true;
		}
		
		private void button_save_cfg_Click(object sender, EventArgs e) {
			try {
				write_cfg(Convert.ToDouble(textBox_min_bord.Text), Convert.ToDouble(textBox_max_bord.Text),
							Convert.ToDouble(textBox_function_stp.Text.Replace('.', ',')), Convert.ToInt32(textBox_grid_stp.Text), Properties.Settings.Default.path);
			}catch (Exception err) {
				MessageBox.Show(Convert.ToString(err));
			}
		}

		private void textBox_min_bord_TextChanged(object sender, EventArgs e) {
			try {
				int temp = Convert.ToInt32(textBox_min_bord.Text);
				if (temp < trackBar_min_range.Minimum) {
					trackBar_min_range.Value = trackBar_min_range.Minimum;
				} else if (temp > trackBar_min_range.Maximum){
					trackBar_min_range.Value = trackBar_min_range.Maximum;
				} else {
					trackBar_min_range.Value = temp;
				}
			}
			catch { }
		}

		private void textBox_max_bord_TextChanged(object sender, EventArgs e) {
			try {
				int temp = Convert.ToInt32(textBox_max_bord.Text);
				if (temp < trackBar_max_range.Minimum) {
					trackBar_max_range.Value = trackBar_max_range.Minimum;
				} else if (temp > trackBar_max_range.Maximum) {
					trackBar_max_range.Value = trackBar_max_range.Maximum;
				} else {
					trackBar_max_range.Value = temp;
				}
			}
			catch { }
		}

		private void textBox_grid_stp_TextChanged(object sender, EventArgs e) {
			try {
				int temp = Convert.ToInt32(textBox_grid_stp.Text);
				if (temp < trackBar_grid_stp.Minimum) {
					trackBar_grid_stp.Value = trackBar_grid_stp.Minimum;
				} else if (temp > trackBar_grid_stp.Maximum) {
					trackBar_grid_stp.Value = trackBar_grid_stp.Maximum;
				} else {
					trackBar_grid_stp.Value = temp;
				}
			}
			catch { }
		}

		private void textBox_function_stp_TextChanged(object sender, EventArgs e) {
			try {
				double temp = Convert.ToDouble(textBox_function_stp.Text.Replace('.',','))*100;
				if (temp < trackBar_function_stp.Minimum) {
					trackBar_function_stp.Value = trackBar_function_stp.Minimum;
				} else if (temp > trackBar_function_stp.Maximum) {
					trackBar_function_stp.Value = trackBar_function_stp.Maximum;
				} else {
					trackBar_function_stp.Value = (int)temp*100;
				}
			}
			catch { }
		}

		private void setup_form_KeyPress(object sender, KeyPressEventArgs e) {
			if(e.KeyChar == (char)Keys.Escape) {
				this.Close();
			}else if(e.KeyChar == (char)Keys.Enter) {
				button_save_cfg_Click(null, null);
			}
		}
	}
}
