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

        public static int UFP_certain_complexity_EI = 0;   
        public static int UFP_certain_complexity_EO = 0;     
        public static int UFP_certain_complexity_EINQ = 0;      
        public static int UFP_certain_complexity_ILF = 0;
        public static int UFP_certain_complexity_EIF = 0;
       
        public UFP()
        {
            InitializeComponent();
        }


       

        private void EI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

            //Dictionary of weights

        public static int v1 = 3;
        public static int v2 = 4;
        public static int v3 = 5;
        public static int v4 = 6;
        public static int v5 = 7;
        public static int v6 = 10;
        public static int v7 = 15;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Show();

            UFP_certain_complexity_EI = (Value1*v1) + (Value2*v2) + (Value3*v4);
            UFP_certain_complexity_EO = (Value4*v2) + (Value5*v3) + (Value6*v5);
            UFP_certain_complexity_EINQ = (Value7*v1) + (Value8*v2) + (Value9*v4);
            UFP_certain_complexity_ILF = (Value10*v5) + (Value11*v6) + (Value12*v7);
            UFP_certain_complexity_EIF = (Value13*v3) + (Value14*v5) + (Value15*v6);

            PassedUFP = UFP_certain_complexity_EI + UFP_certain_complexity_EO + UFP_certain_complexity_EINQ
                        + UFP_certain_complexity_ILF + UFP_certain_complexity_EIF;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if(Value1 !=0)
            {
                label10.Show();
            }
            else
            { label10.Hide(); }

            label13.Text = Value2.ToString();
            EIBOX.ResetText();
            if (Value2 != 0)
            {
                label13.Show();
            }
            else
            { label13.Hide(); }

            label14.Text = Value3.ToString();
            EIBOX.ResetText();
            if (Value3 != 0)
            {
                label14.Show();
            }
            else
            { label14.Hide(); }

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
            if (Value4 != 0)
            {
                label15.Show();
            }
            else
            { label15.Hide(); }

            label16.Text = Value5.ToString();
            EOBOX.ResetText();
            if (Value5 != 0)
            {
                label16.Show();
            }
            else
            { label16.Hide(); }

            label17.Text = Value6.ToString();
            EOBOX.ResetText();
            if (Value6 != 0)
            {
                label17.Show();
            }
            else
            { label17.Hide(); }

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
            if (Value7 != 0)
            {
                label18.Show();
            }
            else
            { label18.Hide(); }

            label19.Text = Value8.ToString();
            EINQBOX.ResetText();
            if (Value8 != 0)
            {
                label19.Show();
            }
            else
            { label19.Hide(); }

            label20.Text = Value9.ToString();
            EINQBOX.ResetText();
            if (Value9 != 0)
            {
                label20.Show();
            }
            else
            { label20.Hide(); }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                Value10 = int.Parse(ILFBOX.Text);
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                Value11 = int.Parse(ILFBOX.Text);

            }
            else
            {
                Value12 = int.Parse(ILFBOX.Text);

            }
            label26.Text = Value10.ToString();
            ILFBOX.ResetText();
            if (Value10 != 0)
            {
                label26.Show();
            }
            else
            { label26.Hide(); }

            label25.Text = Value11.ToString();
            ILFBOX.ResetText();
            if (Value11 != 0)
            {
                label25.Show();
            }
            else
            { label25.Hide(); }

            label24.Text = Value12.ToString();
            ILFBOX.ResetText();
            if (Value12 != 0)
            {
                label24.Show();
            }
            else
            { label24.Hide(); }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (comboBox4.SelectedIndex == 0)
            {
                Value13 = int.Parse(EIFBOX.Text);
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                Value14 = int.Parse(EIFBOX.Text);

            }
            else
            {
                Value15 = int.Parse(EIFBOX.Text);

            }
            label29.Text = Value13.ToString();
            EIFBOX.ResetText();
            if (Value13 != 0)
            {
                label29.Show();
            }
            else
            { label29.Hide(); }


            label28.Text = Value14.ToString();
            EIFBOX.ResetText();
            if (Value14 != 0)
            {
                label28.Show();
            }
            else
            { label28.Hide(); }

            label27.Text = Value15.ToString();
            EIFBOX.ResetText();
            if (Value15 != 0)
            {
                label27.Show();
            }
            else
            { label27.Hide(); }
        }
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

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}

