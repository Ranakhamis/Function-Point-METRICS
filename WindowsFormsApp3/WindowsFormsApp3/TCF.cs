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
    public partial class TCF : Form
    {
        public int avc_value = 0;
        public float loc = 0;
        public TCF()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Factors_for_DI f = new Factors_for_DI();
            f.Show();
            this.Hide();
            //DIBox.Text = Disabeled;
        }

        private void TCF_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    FPBox.Text = (UFP.PassedUFP * float.Parse(TCFBox.Text)).ToString();
        //}

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    TCFBox.Text = (0.65 + 0.01 * double.Parse(DIBox.Text)).ToString();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCFBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //calctcfINT.Click += new EventHandler(calctcfINT_Click);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PLFP_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FPPL_Click(object sender, EventArgs e)
        {
            if (PLFW.SelectedIndex == 0) { avc_value = 320; }
            if (PLFW.SelectedIndex == 1) { avc_value = 128; }
            if (PLFW.SelectedIndex == 2) { avc_value = 105; }
            if (PLFW.SelectedIndex == 3) { avc_value = 90; }
            if (PLFW.SelectedIndex == 4) { avc_value = 70; }
            if (PLFW.SelectedIndex == 5) { avc_value = 64; }
            if (PLFW.SelectedIndex == 6) { avc_value = 32; }
            if (PLFW.SelectedIndex == 7) { avc_value = 30; }
            if (PLFW.SelectedIndex == 8) { avc_value = 22; }
            if (PLFW.SelectedIndex == 9) { avc_value = 15; }
            if (PLFW.SelectedIndex == 10) { avc_value = 12;}
            if (PLFW.SelectedIndex == 11) { avc_value = 6; }
            if (PLFW.SelectedIndex == 12) { avc_value = 4; }

            locbox.Text = (avc_value* float.Parse(FPBoxInternal.Text)).ToString();
            //if(FPBoxExternal.Text == '')
            //{

            //}
        }

        //public void calctcfEXT_Click(Object sender, EventArgs e)
        //{
        //    // do something when the button is clicked
        //    TCFBoxEXT.Text = (0.65 + 0.01 * double.Parse(DIBox.Text)).ToString();

        //    //FPBox.Text = (UFP.PassedUFP * float.Parse(TCFBoxEXT.Text)).ToString();

        //}
        //public void calctcfINT_Click(Object sender, EventArgs e)
        //{
        //    // do something when the button is clicked
        //    DIBox.Text = (Factors_for_DI.TotalDI).ToString();
            
        //   TCFBoxINT.Text = (0.65 + 0.01 * double.Parse(DIBox.Text)).ToString();

        //    //FPBox.Text = (UFP.PassedUFP * float.Parse(TCFBoxINT.Text)).ToString();

        //}


        private void FPNF_Click(object sender, EventArgs e)
        {
           
            //if (TCFBoxEXT.Text= '')
            //{
            //    FPBoxExternal.Text = (UFP.PassedUFP * float.Parse(TCFBoxEXT.Text)).ToString();
            //}
            //if (TCFBoxINT.Text != 0)
            //{
            //    FPBoxExternal.Text = (UFP.PassedUFP * float.Parse(TCFBoxINT.Text)).ToString();
            //}
            //}
            //calctcfEXT.Click += new EventHandler(calctcfEXT_Click);
            //calctcfINT.Click += new EventHandler(calctcfINT_Click);

            //if (calctcfEXT.Click == true)
            //{
            //    FPBox.Text = (UFP.PassedUFP * float.Parse(TCFBoxEXT.Text)).ToString();
            //}
            //if (calctcfINT.click)
            //{
            //    FPBox.Text = (UFP.PassedUFP * float.Parse(TCFBoxINT.Text)).ToString();
            //}

        }

        private void button1_Click(object sender, EventArgs e) //internal
        {
            //calctcfINT.Click += new EventHandler(calctcfINT_Click);
            
            if (radioButton1.Checked)
            {
                DIBox.Text = (Factors_for_DI.TotalDI).ToString();

                TCFBoxINT.Text = (0.65 + 0.01 * double.Parse(DIBox.Text)).ToString();
            }

            if (radioButton2.Checked)
            {
                TCFBoxINT.Text = (0.65 + 0.01 * double.Parse(DIBox.Text)).ToString();
            }

            //FPBoxInternal.Text = (UFP.PassedUFP * float.Parse(TCFBoxINT.Text)).ToString();

        }
        private void button1_Click_1(object sender, EventArgs e) //external
        {
            //calctcfEXT.Click += new EventHandler(calctcfEXT_Click);
            //FPBoxExternal.Text = (UFP.PassedUFP * float.Parse(TCFBoxEXT.Text)).ToString();

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void FPBoxExternal_TextChanged(object sender, EventArgs e)
        {

        }

        private void FPNFINT_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                FPBoxInternal.Text = (UFP.PassedUFP * float.Parse(TCFBoxINT.Text)).ToString();

            }

            if (radioButton2.Checked)
            {
                FPBoxInternal.Text = (UFP.PassedUFP * float.Parse(TCFBoxINT.Text)).ToString();
            }
        }
    }
}
