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
            //fp = ufp* tcf;
            if(TCF.externalDIbool == true)
            {
                FPLOC.Text = (TCF.fptcfexternal).ToString();

            }
            if(TCF.internalDIbool == true)
            {
                FPLOC.Text = (Factors_for_DI.fptcfinternal).ToString();
            }

            if (AVC_Combo.SelectedIndex == 0)
            {
                val1 = 320;
                LOC_TextBox.Text = (val1 * (UFP.PassedUFP)).ToString();
            }
            if (AVC_Combo.SelectedIndex == 1)
            {
                val2 = 128;
                LOC_TextBox.Text = (val2 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 2)
            {
                val3 = 105;
                LOC_TextBox.Text = (val3 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 3)
            {
                val4 = 90;
                LOC_TextBox.Text = (val4 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 4)
            {
                val5 = 70;
                LOC_TextBox.Text = (val5 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 5)
            {
                val6 = 64;
                LOC_TextBox.Text = (val6 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 6)
            {
                val7 = 32;
                LOC_TextBox.Text = (val7 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 7)
            {
                val8 = 30;
                LOC_TextBox.Text = (val8 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 8)
            {
                val9 = 22;
                LOC_TextBox.Text = (val9 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 9)
            {
                val10 = 15;
                LOC_TextBox.Text = (val10 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 10)
            {
                val11 = 12;
                LOC_TextBox.Text = (val11 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 11)
            {
                val12 = 6;
                LOC_TextBox.Text = (val12 * (UFP.PassedUFP)).ToString();

            }
            if (AVC_Combo.SelectedIndex == 12)
            {
                val13 = 4;
                LOC_TextBox.Text = (val13 * (UFP.PassedUFP)).ToString();

            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LOC_Load(object sender, EventArgs e)
        {

        }

        int val1 = 0;
        int val2 = 0;
        int val3 = 0;
        int val4 = 0;
        int val5 = 0;

        int val6 = 0;
        int val7 = 0;
        int val8 = 0;
        int val9 = 0;
        int val10 = 0;

        int val11 = 0;
        int val12= 0;
        int val13= 0;
        int val14= 0;

        private void AVC_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TCF T = new TCF();
            T.Show();
            this.Hide();
        }
    }
}

