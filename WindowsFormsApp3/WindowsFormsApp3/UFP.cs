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
        public static int UFP_certain_complexity = 0;
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
                Value += 3;
                UFP_certain_complexity += (Value * int.Parse(EIBOX.Text));
            }
            if (EI.SelectedIndex == 1)
            {
                Value += 4;
                UFP_certain_complexity += (Value * int.Parse(EIBOX.Text));

            }
            if (EI.SelectedIndex == 2)
            {
                Value += 6;
                UFP_certain_complexity += (Value * int.Parse(EIBOX.Text));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = T_ufp_ALL_ATTRIBUTES.ToString();

        }

        private void UFP_Load(object sender, EventArgs e)
        {

            T_ufp_ALL_ATTRIBUTES += UFP_certain_complexity;

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

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EO_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EO

            if (EO.SelectedIndex == 0)
            {
                Value += 4;
                UFP_certain_complexity += (Value * int.Parse(EOBOX.Text));

            }
            if (EO.SelectedIndex == 1)
            {
                Value += 5;
                UFP_certain_complexity += (Value * int.Parse(EOBOX.Text));

            }
            if (EO.SelectedIndex == 2)
            {
                Value += 7;
                UFP_certain_complexity += (Value * int.Parse(EOBOX.Text));

            }
        }

        private void EINQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EINQ

            if (EINQ.SelectedIndex == 0)
            {
                Value += 3;
                UFP_certain_complexity += (Value * int.Parse(EINQBOX.Text));

            }
            if (EINQ.SelectedIndex == 1)
            {
                Value += 4;
                UFP_certain_complexity += (Value * int.Parse(EINQBOX.Text));

            }
            if (EINQ.SelectedIndex == 2)
            {
                Value += 6;
                UFP_certain_complexity += (Value * int.Parse(EINQBOX.Text));

            }
        }

        private void ILF_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ILF

            if (ILF.SelectedIndex == 0)
            {
                Value += 7;
                UFP_certain_complexity += (Value * int.Parse(ILFBOX.Text));

            }
            if (ILF.SelectedIndex == 1)
            {
                Value += 10;
                UFP_certain_complexity += (Value * int.Parse(ILFBOX.Text));

            }
            if (ILF.SelectedIndex == 2)
            {
                Value += 15;
                UFP_certain_complexity += (Value * int.Parse(ILFBOX.Text));

            }
        }

        private void EIF_SelectedIndexChanged(object sender, EventArgs e)
        {

            //EIF

            if (EIF.SelectedIndex == 0)
            {
                Value += 5;
                UFP_certain_complexity += (Value * int.Parse(EIFBOX.Text));

            }
            if (EIF.SelectedIndex == 1)
            {
                Value += 7;
                UFP_certain_complexity += (Value * int.Parse(EIFBOX.Text));

            }
            if (EIF.SelectedIndex == 2)
            {
                Value += 10;
                UFP_certain_complexity += (Value * int.Parse(EIFBOX.Text));

            }
        }

        private void EIRADIO_CheckedChanged(object sender, EventArgs e)
        {
            if (EIRADIO.Checked)
            {
                EIBOX.Clear();

            }

        }

        private void EORADIO_CheckedChanged(object sender, EventArgs e)
        {
            if (EORADIO.Checked)
            {
                EOBOX.Clear();
            }
        }

        private void EINQRADIO_CheckedChanged(object sender, EventArgs e)
        {
            if (EINQRADIO.Checked)
            {
                EINQBOX.Clear();
            }
        }

        private void ILFRADIO_CheckedChanged(object sender, EventArgs e)
        {

            if (ILFRADIO.Checked)
            {
                ILFBOX.Clear();
            }
        }

        private void EIFRADIO_CheckedChanged(object sender, EventArgs e)
        {
            if (EIFRADIO.Checked)
            {
                EIFBOX.Clear();

            }
        }

    }
}

