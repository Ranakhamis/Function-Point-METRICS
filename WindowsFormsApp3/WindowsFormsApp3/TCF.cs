﻿using System;
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
        public static float Externel_FP;
        public static bool Externel = false;
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
            if (InternelDI_RadioButton.Checked == true)
            {
                internalDIbool = true;
                Factors_for_DI f = new Factors_for_DI();
                f.Show();
                this.Hide();
                
            }

        }

        private void TCF_Load(object sender, EventArgs e)
        {
            ExternelDI_Panel.Hide();
        }

        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCFBox_TextChanged(object sender, EventArgs e)
        {
           // fromtcfexternal = int.Parse(TCFBOX.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           

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
           
        }

        


        private void FPNF_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e) //internal
        {
                TCFBOX.Text = (0.65 + 0.01 * double.Parse(DIBox.Text)).ToString();
//            fromtcfexternal = int.Parse(TCFBOX.Text);

        }
        private void button1_Click_1(object sender, EventArgs e) //external
        {
           

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

        

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (ExternelDI_RadioButton.Checked == true)
            {
                externalDIbool = true;
                ExternelDI_Panel.Show();
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Externel_FP = (UFP.PassedUFP * float.Parse(TCFBOX.Text));
            FPBox.Text = (UFP.PassedUFP * float.Parse(TCFBOX.Text)).ToString();
            Externel = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            LOC loc = new LOC();
            loc.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            UFP ufp = new UFP();
            ufp.Show();
            this.Hide();
        }
    }
}
