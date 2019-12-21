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
    public partial class UFP : Form
    {
     
        public static float PassedUFP = 0;
        int Value1 = 0;
        public int Value2 = 0;
        public int Value3 = 0;
        public int Value4 = 0;
        public int Value5 = 0;

        public int Value6 = 0;
        public int Value7 = 0;
        public int Value8 = 0;
        public int Value9 = 0;
        public int Value10 = 0;

        public int Value11 = 0;
        public int Value12 = 0;
        public int Value13 = 0;
        public int Value14 = 0;
        public int Value15 = 0;

        public static int Total_UFP_certain_complexity = 0;
        public static int UFP_certain_complexity_EI = 0;
        public static int UFP_certain_complexity_EI_0 = 0;
        public static int UFP_certain_complexity_EI_1= 0;
        public static int UFP_certain_complexity_EI_2 = 0;

        public static int UFP_certain_complexity_EO = 0;
        public static int UFP_certain_complexity_EO_0 = 0;
        public static int UFP_certain_complexity_EO_1 = 0;
        public static int UFP_certain_complexity_EO_2 = 0;

        public static int UFP_certain_complexity_EINQ = 0;
        public static int UFP_certain_complexity_EINQ_0 = 0;
        public static int UFP_certain_complexity_EINQ_1 = 0;
        public static int UFP_certain_complexity_EINQ_2 = 0;

        public static int UFP_certain_complexity_ILF = 0;
        public static int UFP_certain_complexity_ILF_0 = 0;
        public static int UFP_certain_complexity_ILF_1 = 0;
        public static int UFP_certain_complexity_ILF_2 = 0;

        public static int UFP_certain_complexity_EIF = 0;
        public static int UFP_certain_complexity_EIF_0 = 0;
        public static int UFP_certain_complexity_EIF_1 = 0;
        public static int UFP_certain_complexity_EIF_2 = 0;

        public static int T_ufp_ALL_ATTRIBUTES = 0;
        public UFP()
        {
            InitializeComponent();
        }

        private void EI_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EI

            if (EI.SelectedIndex == 0)
            {
                Value1 = int.Parse(EIS.Text);
                UFP_certain_complexity_EI_0 = Value1 * 3;
                EIA.Enabled = false;
                EIC.Enabled= false;
            }
            else if (EI.SelectedIndex == 1)
            {
                Value2 = int.Parse(EIA.Text);
                UFP_certain_complexity_EI_1 = (Value2 * 4);
                EIS.Enabled = false;
                EIC.Enabled = false;
            }
            else 
            {
                Value3 = int.Parse(EIC.Text);
                UFP_certain_complexity_EI_2 = (Value3 *6 );
                EIA.Enabled = false;
                EIS.Enabled = false;
            }
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = T_ufp_ALL_ATTRIBUTES.ToString();

        }

        private void UFP_Load(object sender, EventArgs e)
        {   
            panel1.Hide();
          T_ufp_ALL_ATTRIBUTES = UFP_certain_complexity_EI + UFP_certain_complexity_EO + 
                                 UFP_certain_complexity_EINQ + UFP_certain_complexity_ILF + UFP_certain_complexity_EIF;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PassedUFP = float.Parse(Result.Text);
            TCF tcf = new TCF();
            tcf.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EO_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////EO

            //if (EO.SelectedIndex == 0)
            //{
            //    Value2 += 4;
            //    UFP_certain_complexity_EO_0 = (Value2 * int.Parse(EOBOX.Text));


            //}
            //if (EO.SelectedIndex == 1)
            //{
            //    Value2 += 5;
            //    UFP_certain_complexity_EO_1 = (Value2 * int.Parse(EOBOX.Text));

            //}
            //if (EO.SelectedIndex == 2)
            //{
            //    Value2 += 7;
            //    UFP_certain_complexity_EO_2 = (Value2 * int.Parse(EOBOX.Text));

            //}
            //UFP_certain_complexity_EO = UFP_certain_complexity_EO_0 + UFP_certain_complexity_EO_1 + UFP_certain_complexity_EO_2;

        }

        private void EINQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////EINQ

            //if (EINQ.SelectedIndex == 0)
            //{
            //    Value3 += 3;
            //    UFP_certain_complexity_EINQ_0 = (Value3 * int.Parse(EINQBOX.Text));

            //}
            //if (EINQ.SelectedIndex == 1)
            //{
            //    Value3 += 4;
            //    UFP_certain_complexity_EINQ_1 = (Value3 * int.Parse(EINQBOX.Text));

            //}
            //if (EINQ.SelectedIndex == 2)
            //{
            //    Value3 += 6;
            //    UFP_certain_complexity_EINQ_2 = (Value3 * int.Parse(EINQBOX.Text));

            //}
            UFP_certain_complexity_EINQ = UFP_certain_complexity_EINQ_0 + UFP_certain_complexity_EINQ_1 + UFP_certain_complexity_EINQ_2;

        }

        private void ILF_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////ILF

            //if (ILF.SelectedIndex == 0)
            //{
            //    Value4 += 7;
            //    UFP_certain_complexity_ILF_0 = (Value4 * int.Parse(ILFBOX.Text));

            //}
            //if (ILF.SelectedIndex == 1)
            //{
            //    Value4 += 10;
            //    UFP_certain_complexity_ILF_1 = (Value4 * int.Parse(ILFBOX.Text));

            //}
            //if (ILF.SelectedIndex == 2)
            //{
            //    Value4 += 15;
            //    UFP_certain_complexity_ILF_2 = (Value4 * int.Parse(ILFBOX.Text));

            //}
            //UFP_certain_complexity_ILF = UFP_certain_complexity_ILF_0 + UFP_certain_complexity_ILF_1 + UFP_certain_complexity_ILF_2;

        }

        private void EIF_SelectedIndexChanged(object sender, EventArgs e)
        {

            ////EIF

            //if (EIF.SelectedIndex == 0)
            //{
            //    Value5 += 5;
            //    UFP_certain_complexity_EIF_0 = (Value5 * int.Parse(EIFBOX.Text));

            //}
            //if (EIF.SelectedIndex == 1)
            //{
            //    Value5 += 7;
            //    UFP_certain_complexity_EIF_1 = (Value5 * int.Parse(EIFBOX.Text));

            //}
            //if (EIF.SelectedIndex == 2)
            //{
            //    Value5 += 10;
            //    UFP_certain_complexity_EIF_2 = (Value5 * int.Parse(EIFBOX.Text));

            //}
            //UFP_certain_complexity_EIF = UFP_certain_complexity_EIF_0 + UFP_certain_complexity_EIF_1 + UFP_certain_complexity_EIF_2;

        }

        private void EIRADIO_CheckedChanged(object sender, EventArgs e)
        {
        //    if (EIRADIO.Checked)
        //    {
                
        //    }
        //    EIRADIO.Checked = false;
        }

        private void EORADIO_CheckedChanged(object sender, EventArgs e)
        {
            //if (EORADIO.Checked)
            //{
            //    EOBOX.Clear();
            //}
        }

        private void EINQRADIO_CheckedChanged(object sender, EventArgs e)
        {
            //if (EINQRADIO.Checked)
            //{
            //    EINQBOX.Clear();
            //}
        }

        private void ILFRADIO_CheckedChanged(object sender, EventArgs e)
        {

            //if (ILFRADIO.Checked)
            //{
            //    ILFBOX.Clear();
            //}
        }

        private void EIFRADIO_CheckedChanged(object sender, EventArgs e)
        {
            //if (EIFRADIO.Checked)
            //{
            //    EIFBOX.Clear();

            //}
        }

        private void EIBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            TCF T = new TCF();
            T.Show();
            this.Hide();
            UFP u = new UFP();
            u.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UFP u = new UFP();
            u.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

