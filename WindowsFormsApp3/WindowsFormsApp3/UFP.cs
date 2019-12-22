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
        int Value2 = 0;
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
        //public static int UFP_certain_complexity_EI_0 = 0;
        //public static int UFP_certain_complexity_EI_1= 0;
        //public static int UFP_certain_complexity_EI_2 = 0;

        public static int UFP_certain_complexity_EO = 0;
        //public static int UFP_certain_complexity_EO_0 = 0;
        //public static int UFP_certain_complexity_EO_1 = 0;
        //public static int UFP_certain_complexity_EO_2 = 0;

        public static int UFP_certain_complexity_EINQ = 0;
        //public static int UFP_certain_complexity_EINQ_0 = 0;
        //public static int UFP_certain_complexity_EINQ_1 = 0;
        //public static int UFP_certain_complexity_EINQ_2 = 0;

        public static int UFP_certain_complexity_ILF = 0;
        //public static int UFP_certain_complexity_ILF_0 = 0;
        //public static int UFP_certain_complexity_ILF_1 = 0;
        //public static int UFP_certain_complexity_ILF_2 = 0;

        public static int UFP_certain_complexity_EIF = 0;
        //public static int UFP_certain_complexity_EIF_0 = 0;
        //public static int UFP_certain_complexity_EIF_1 = 0;
        //public static int UFP_certain_complexity_EIF_2 = 0;

        public UFP()
        {
            InitializeComponent();
        }


        //            //EI

        //            if (EI.SelectedIndex == 0)
        //            {
        //                Value1 = int.Parse(EIS.Text);
        //        UFP_certain_complexity_EI_0 = Value1* 3;
        //                EIA.Enabled = false;


        //                EIC.Enabled= false;
        //            }
        //            else if (EI.SelectedIndex == 1)
        //            {
        //                Value2 = int.Parse(EIA.Text);
        //    UFP_certain_complexity_EI_1 = (Value2* 4);
        //                EIS.Enabled = false;
        //                EIC.Enabled = false;
        //            }
        //            else 
        //            {
        //                Value3 = int.Parse(EIC.Text);
        //UFP_certain_complexity_EI_2 = (Value3*6 );
        //                EIA.Enabled = false;
        //                EIS.Enabled = false;
        //            }

        private void EI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PassedUFP = UFP_certain_complexity_EI + UFP_certain_complexity_EO +
                                UFP_certain_complexity_EINQ + UFP_certain_complexity_ILF + UFP_certain_complexity_EIF;

            Result.Text = PassedUFP.ToString();

        }

        private void UFP_Load(object sender, EventArgs e)
        {
            panel1.Hide();

            CEIS.Text = "3";
            CEIA.Text = "4";
            CEIC.Text = "6";

            CEOS.Text = "4";
            CEOA.Text = "5";
            CEOC.Text = "7";

            CEINQS.Text = "3";
            CEINQA.Text = "4";
            CEINQC.Text = "6";

            CILFS.Text = "7";
            CILFA.Text = "10";
            CILFC.Text = "15";

            CEIFS.Text = "5";
            CEIFA.Text = "7";
            CEIFC.Text = "10";




            //UFP_certain_complexity_EI = UFP_certain_complexity_EI_0 + UFP_certain_complexity_EI_1 + UFP_certain_complexity_EI_2;
            //UFP_certain_complexity_EO = UFP_certain_complexity_EO_0 + UFP_certain_complexity_EO_1 + UFP_certain_complexity_EO_2;
            //UFP_certain_complexity_EINQ = UFP_certain_complexity_EINQ_0 + UFP_certain_complexity_EINQ_1 + UFP_certain_complexity_EINQ_2;
            //UFP_certain_complexity_ILF = UFP_certain_complexity_ILF_0 + UFP_certain_complexity_ILF_1 + UFP_certain_complexity_ILF_2;
            //UFP_certain_complexity_EIF = UFP_certain_complexity_EIF_0 + UFP_certain_complexity_EIF_1 + UFP_certain_complexity_EIF_2;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PassedUFP = float.Parse(Result.Text);
            TCF tcf = new TCF();
            tcf.Show();
            this.Hide();
        }

        ////string r = " ";
        //public void return_function(TextBox T)
        //{
        //    if (T.Text == "")
        //    {
        //        T.Text = 0.ToString();
        //    }
        //    //else
        //    //{
        //    //    return T;
        //    //}
        //}
        // t3alyy call awryky haga 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Show();

            Value1 = (3 * Int32.Parse(EIS.Text));
            Value2 = (4 * int.Parse(EIA.Text));
            Value3 = (6 * int.Parse(EIC.Text));
            UFP_certain_complexity_EI = (Value1 + Value2 + Value3);


            Value4 = (4 * int.Parse(EOS.Text));
            Value5 = (5 * int.Parse(EOA.Text));
            Value6 = (7 * int.Parse(EOC.Text));
            UFP_certain_complexity_EO = (Value4 + Value5 + Value6);


            Value7 = (3 * int.Parse(EINQS.Text));
            Value8 = (4 * int.Parse(EINQA.Text));
            Value9 = (6 * int.Parse(EINQC.Text));
            UFP_certain_complexity_EINQ = (Value7 + Value8 + Value9);

            Value10 = (7 * int.Parse(ILFS.Text));
            Value11 = (10 * int.Parse(ILFA.Text));
            Value12 = (15 * int.Parse(ILFC.Text));
            UFP_certain_complexity_ILF = (Value10 + Value11 + Value12);


            Value13 = (5 * int.Parse(EIFS.Text));
            Value14 = (7 * int.Parse(EIFA.Text));
            Value15 = (10 * int.Parse(EIFC.Text));
            UFP_certain_complexity_EIF = (Value13 + Value14 + Value15);


            //return_function(EIS);
            //return_function(EIA);
            //return_function(EIC);

            //return_function(EOS);
            //return_function(EOA);
            //return_function(EOC);

            //return_function(EINQS);
            //return_function(EINQA);
            //return_function(EINQC);

            //return_function(ILFS);
            //return_function(ILFA);
            //return_function(ILFC);

            //return_function(EIFS);
            //return_function(EIFA);
            //return_function(EIFC);



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        

        //private void EIFRADIO_CheckedChanged(object sender, EventArgs e)
        //{
        //    //if (EIFRADIO.Checked)
        //    //{
        //    //    EIFBOX.Clear();

        //    //}
        //}

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();

        }
    }
}

