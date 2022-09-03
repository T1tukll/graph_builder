/* 
 *	Titov, Kotov
 *	Lipetsk 2022
 */

using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace graphicks_1 {
	public partial class guide_form : Form {
		public guide_form() {
			InitializeComponent();

		}

		private void button_close_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void guide_form_FormClosing(object sender, FormClosingEventArgs e) {

			if (checkBox_accep.Checked) {
				Properties.Settings.Default.show_guide = false;
			} else {
				Properties.Settings.Default.show_guide = true;
			}
			Properties.Settings.Default.Save();

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("https://youtu.be/6gp38zf6e0Q");
		}
		
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("https://youtu.be/z2DaDpCzS_A");
        }

        private void guide_form_KeyPress(object sender, KeyPressEventArgs e) {
			if(e.KeyChar == (char)Keys.Escape) {
				this.Close();
            }
        }
    }
}
