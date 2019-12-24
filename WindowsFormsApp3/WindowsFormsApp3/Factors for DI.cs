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
    public partial class Factors_for_DI : Form
    {
        int TotalDI = 0;
        public static float Internel_FP;
        public static bool internel = false;
        Dictionary<string, int> GSC = new Dictionary<string, int>();
       
          
        public int SumComboBox(ComboBox name)
        {
           
            int Value = 0;
            if (name.SelectedIndex == 0)
            {
                Value += GSC["No Influence"];
            }
            if (name.SelectedIndex == 1)
            {
                Value += GSC["Incidental"]; 
            }
            if (name.SelectedIndex == 2)
            {
                Value += GSC["Moderate"];
            }
            if (name.SelectedIndex == 3)
            {
                Value += GSC["Average"];

            }
            if (name.SelectedIndex == 4)
            {
                Value += GSC["Significant"];
            }
            if (name.SelectedIndex == 5)
            {
                Value += GSC["Essential"];
            }

            return Value;
        }
        public Factors_for_DI()
        {
            InitializeComponent();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

         
        }

        private void TCF_Button_Click(object sender, EventArgs e)
        {
            TotalDI += SumComboBox(comboBox1);
            TotalDI += SumComboBox(comboBox2);
            TotalDI += SumComboBox(comboBox3);
            TotalDI += SumComboBox(comboBox4);
            TotalDI += SumComboBox(comboBox5);
            TotalDI += SumComboBox(comboBox6);
            TotalDI += SumComboBox(comboBox7);
            TotalDI += SumComboBox(comboBox8);
            TotalDI += SumComboBox(comboBox9);
            TotalDI += SumComboBox(comboBox10);
            TotalDI += SumComboBox(comboBox11);
            TotalDI += SumComboBox(comboBox12);
            TotalDI += SumComboBox(comboBox13);
            TotalDI += SumComboBox(comboBox14);

            // Total DI 
            DIBox.Text = TotalDI.ToString();

            // TCF 
            TCFBOX.Text = (0.65 + 0.01 * double.Parse(DIBox.Text)).ToString();
        }

        private void FP_Button_Click(object sender, EventArgs e)
        {
            Internel_FP = (UFP.PassedUFP * float.Parse(TCFBOX.Text));
            FPBox.Text = (UFP.PassedUFP * float.Parse(TCFBOX.Text)).ToString();
            internel = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            LOC loc = new LOC();
            loc.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            TCF tcf = new TCF();
            tcf.Show();
            this.Hide();

        }

        private void Factors_for_DI_Load(object sender, EventArgs e)
        {
            GSC.Add("No Influence", 0);
            GSC.Add("Incidental", 1);
            GSC.Add("Moderate", 2);
            GSC.Add("Average", 3);
            GSC.Add("Significant", 4);
            GSC.Add("Essential", 5);
        }
    }
}
