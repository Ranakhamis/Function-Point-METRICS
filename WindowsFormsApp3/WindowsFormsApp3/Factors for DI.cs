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
        public static int TotalDI = 0;
        public int SumComboBox(ComboBox name)
        {
            int Value = 0;
            if (name.SelectedIndex == 0)
            {
                Value += 0;
            }
            if (name.SelectedIndex == 1)
            {
                Value += 1;
            }
            if (name.SelectedIndex == 2)
            {
                Value += 2;
            }
            if (name.SelectedIndex == 3)
            {
                Value += 3;

            }
            if (name.SelectedIndex == 4)
            {
                Value += 4;
            }
            if (name.SelectedIndex == 5)
            {
                Value += 5;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   
            TCF tcf = new TCF();
            tcf.Show();
            this.Hide();

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
            //if (comboBox1.SelectedItem.value = 0 )
            //{
            //    Val = 0
            //}
        }
    }
}
