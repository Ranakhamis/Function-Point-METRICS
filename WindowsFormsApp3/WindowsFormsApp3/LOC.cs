using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class LOC : Form
    {
        public int avc_value = 0;
        public LOC()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOC_Button_Click(object sender, EventArgs e)
        {
            if (AVC_Combo.SelectedIndex == 0) { avc_value = 320; }
            if (AVC_Combo.SelectedIndex == 1) { avc_value = 128; }
            if (AVC_Combo.SelectedIndex == 2) { avc_value = 105; }
            if (AVC_Combo.SelectedIndex == 3) { avc_value = 90; }
            if (AVC_Combo.SelectedIndex == 4) { avc_value = 70; }
            if (AVC_Combo.SelectedIndex == 5) { avc_value = 64; }
            if (AVC_Combo.SelectedIndex == 6) { avc_value = 32; }
            if (AVC_Combo.SelectedIndex == 7) { avc_value = 30; }
            if (AVC_Combo.SelectedIndex == 8) { avc_value = 22; }
            if (AVC_Combo.SelectedIndex == 9) { avc_value = 15; }
            if (AVC_Combo.SelectedIndex == 10) { avc_value = 12; }
            if (AVC_Combo.SelectedIndex == 11) { avc_value = 6; }
            if (AVC_Combo.SelectedIndex == 12) { avc_value = 4; }

            if (TCF.Externel == true)
            {
                LOC_TextBox.Text = Math.Ceiling((avc_value * TCF.Externel_FP)).ToString();
            }
            else
            {
                LOC_TextBox.Text = Math.Ceiling((avc_value * Factors_for_DI.Internel_FP)).ToString();
            }
            
        }

        private void AVC_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            TCF tcf = new TCF();
            tcf.Show();
            this.Hide();
        }
    }
}

