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
        float TotalUFP = 0;
        public static float PassedUFP = 0;
        public int Value = 0;
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
            //EI

            if(EI.SelectedIndex ==0)
            {
                Value += 3;
            }
            if (EI.SelectedIndex == 1)
            {
                Value += 4;
            }
            if (EI.SelectedIndex == 2)
            {
                Value += 6;
            }
            //EO

            if (EO.SelectedIndex == 0)
            {
                Value += 4;
            }
            if (EO.SelectedIndex == 1)
            {
                Value += 5;
            }
            if (EO.SelectedIndex == 2)
            {
                Value += 7;
            }
            //EINQ

            if (EINQ.SelectedIndex == 0)
            {
                Value += 3;
            }
            if (EINQ.SelectedIndex == 1)
            {
                Value += 4;
            }
            if (EINQ.SelectedIndex == 2)
            {
                Value += 6;
            }
            //ILF

            if (ILF.SelectedIndex == 0)
            {
                Value += 7;
            }
            if (ILF.SelectedIndex == 1)
            {
                Value += 10;
            }
            if (ILF.SelectedIndex == 2)
            {
                Value += 15;
            }
            //EIF

            if (EIF.SelectedIndex == 0)
            {
                Value += 5;
            }
            if (EIF.SelectedIndex == 1)
            {
                Value += 7;
            }
            if (EIF.SelectedIndex == 2)
            {
                Value += 10;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
