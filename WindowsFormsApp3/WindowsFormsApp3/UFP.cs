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
       
        public static int Value1 = 0;
        public static int Value2 = 0;
        public static int Value3 = 0;
        public static int Value4 = 0;
        public static int Value5 = 0;

        public static int Value6 = 0;
        public static int Value7 = 0;
        public static int Value8 = 0;
        public static int Value9 = 0;
        public static int Value10 = 0;

        public static int Value11 = 0;
        public static int Value12 = 0;
        public static int Value13 = 0;
        public static int Value14 = 0;
        public static int Value15 = 0;

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
            //PassedUFP = UFP_certain_complexity_EI + UFP_certain_complexity_EO +
                                //UFP_certain_complexity_EINQ + UFP_certain_complexity_ILF + UFP_certain_complexity_EIF;

            //Result.Text = PassedUFP.ToString();

        }

        private void UFP_Load(object sender, EventArgs e)
        {
            panel1.Hide();

            label10.Hide();
            label13.Hide();
            label14.Hide();
            
            label15.Hide();
            label16.Hide();
            label17.Hide();

            label18.Hide();
            label19.Hide();
            label20.Hide();
          
            label24.Hide();
            label25.Hide();
            label26.Hide();


            label27.Hide();
            label28.Hide();
            label29.Hide();



            //UFP_certain_complexity_EI = UFP_certain_complexity_EI_0 + UFP_certain_complexity_EI_1 + UFP_certain_complexity_EI_2;
            //UFP_certain_complexity_EO = UFP_certain_complexity_EO_0 + UFP_certain_complexity_EO_1 + UFP_certain_complexity_EO_2;
            //UFP_certain_complexity_EINQ = UFP_certain_complexity_EINQ_0 + UFP_certain_complexity_EINQ_1 + UFP_certain_complexity_EINQ_2;
            //UFP_certain_complexity_ILF = UFP_certain_complexity_ILF_0 + UFP_certain_complexity_ILF_1 + UFP_certain_complexity_ILF_2;
            //UFP_certain_complexity_EIF = UFP_certain_complexity_EIF_0 + UFP_certain_complexity_EIF_1 + UFP_certain_complexity_EIF_2;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //PassedUFP = float.Parse(Result.Text);
            //TCF tcf = new TCF();
            //tcf.Show();
            //this.Hide();
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

            UFP_certain_complexity_EI = (Value1*3) + (Value2*4) + (Value3*6);
            UFP_certain_complexity_EO = (Value4*4) + (Value5*5) + (Value6*7);
            UFP_certain_complexity_EINQ = (Value7*3) + (Value8*4) + (Value9*6);
            UFP_certain_complexity_ILF = (Value10*7) + (Value11*10) + (Value12*15);
            UFP_certain_complexity_EIF = (Value13*5) + (Value14*7) + (Value15*10);

            PassedUFP = UFP_certain_complexity_EI + UFP_certain_complexity_EO + UFP_certain_complexity_EINQ
                        + UFP_certain_complexity_ILF + UFP_certain_complexity_EIF;

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
            //panel1.Hide();

        }

        private void EIBOX_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (comboBox2.SelectedIndex == 0)
            //{
            //    Value4 = int.Parse(EOBOX.Text);
            //}
            //else if (comboBox2.SelectedIndex == 1)
            //{
            //    Value5 = int.Parse(EOBOX.Text);

            //}
            //else
            //{
            //    Value6 = int.Parse(EOBOX.Text);

            //}
            //label15.Text = Value4.ToString();
            //EOBOX.ResetText();
            //label15.Show();

            //label16.Text = Value5.ToString();
            //EOBOX.ResetText();
            //label16.Show();

            //label17.Text = Value6.ToString();
            //EOBOX.ResetText();
            //label17.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                Value7 = int.Parse(EINQBOX.Text);
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                Value8 = int.Parse(EINQBOX.Text);

            }
            else
            {
                Value9 = int.Parse(EINQBOX.Text);

            }
            label18.Text = Value7.ToString();
            EINQBOX.ResetText();
            label18.Show();

            label19.Text = Value8.ToString();
            EINQBOX.ResetText();
            label19.Show();

            label20.Text = Value9.ToString();
            EINQBOX.ResetText();
            label20.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                Value10= int.Parse(ILFBOX.Text);
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                Value11 = int.Parse(ILFBOX.Text);

            }
            else
            {
                Value12 = int.Parse(ILFBOX.Text);

            }
            label24.Text = Value10.ToString();
            ILFBOX.ResetText();
            label24.Show();

            label25.Text = Value11.ToString();
            ILFBOX.ResetText();
            label25.Show();

            label26.Text = Value12.ToString();
            ILFBOX.ResetText();
            label26.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox5.SelectedIndex == 0)
            {
                Value13 = int.Parse(EIFBOX.Text);
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                Value14 = int.Parse(EIFBOX.Text);

            }
            else
            {
                Value15 = int.Parse(EIFBOX.Text);

            }
            label27.Text = Value13.ToString();
            EIFBOX.ResetText();
            label27.Show();

            label28.Text = Value14.ToString();
            EIFBOX.ResetText();
            label28.Show();

            label29.Text = Value15.ToString();
            EIFBOX.ResetText();
            label29.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Value1 = int.Parse(EIBOX.Text);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Value2 = int.Parse(EIBOX.Text);

            }
            else
            {
                Value3 = int.Parse(EIBOX.Text);

            }
            label10.Text = Value1.ToString();
            EIBOX.ResetText();
            label10.Show();

            label13.Text = Value2.ToString();
            EIBOX.ResetText();
            label13.Show();

            label14.Text = Value3.ToString();
            EIBOX.ResetText();
            label14.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex == 0)
            {
                Value4 = int.Parse(EOBOX.Text);
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                Value5 = int.Parse(EOBOX.Text);

            }
            else
            {
                Value6 = int.Parse(EOBOX.Text);

            }
            label15.Text = Value4.ToString();
            EOBOX.ResetText();
            label15.Show();

            label16.Text = Value5.ToString();
            EOBOX.ResetText();
            label16.Show();

            label17.Text = Value6.ToString();
            EOBOX.ResetText();
            label17.Show();
        }

        private void pictureBox5_Click_2(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                Value7 = int.Parse(EINQBOX.Text);
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                Value8 = int.Parse(EINQBOX.Text);

            }
            else
            {
                Value9 = int.Parse(EINQBOX.Text);

            }
            label18.Text = Value7.ToString();
            EINQBOX.ResetText();
            label18.Show();

            label19.Text = Value8.ToString();
            EINQBOX.ResetText();
            label19.Show();

            label20.Text = Value9.ToString();
            EINQBOX.ResetText();
            label20.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                Value10 = int.Parse(ILFBOX.Text);
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                Value11 = int.Parse(ILFBOX.Text);

            }
            else
            {
                Value12 = int.Parse(ILFBOX.Text);

            }
            label24.Text = Value10.ToString();
            ILFBOX.ResetText();
            label24.Show();

            label25.Text = Value11.ToString();
            ILFBOX.ResetText();
            label25.Show();

            label26.Text = Value12.ToString();
            ILFBOX.ResetText();
            label26.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (comboBox5.SelectedIndex == 0)
            {
                Value13 = int.Parse(EIFBOX.Text);
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                Value14 = int.Parse(EIFBOX.Text);

            }
            else
            {
                Value15 = int.Parse(EIFBOX.Text);

            }
            label27.Text = Value13.ToString();
            EIFBOX.ResetText();
            label27.Show();

            label28.Text = Value14.ToString();
            EIFBOX.ResetText();
            label28.Show();

            label29.Text = Value15.ToString();
            EIFBOX.ResetText();
            label29.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Result.Text = PassedUFP.ToString();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            TCF T = new TCF();
            T.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}

