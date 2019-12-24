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

        //EI
        public static int EISimple = 3;
        public static int EIAverage =4 ;
        public static int EIComplex = 6;

        //EO
        public static int EOSimple = 4;
        public static int EOAverage = 5;
        public static int EOComplex = 7;

        //EQ
        public static int EQSimple = 3;
        public static int EQAverage = 4;
        public static int EQComplex = 6;

        //ILF
        public static int ILFSimple = 7;
        public static int ILFAverage = 10;
        public static int ILFComplex = 15;

        //EIF
        public static int EIFSimple = 5;
        public static int EIFAverage = 7;
        public static int EIFComplex = 10;


        bool EI_RadiButton = false;
        bool EO_RadButton = false;
        bool EQ_RadButton = false;
        bool ILF_RadButton = false;
        bool ELF_RadButton = false;
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
            EIS.Visible = false;
            EIA.Visible = false;
            EIC.Visible = false;

            EOS.Visible = false;
            EOA.Visible = false;
            EOC.Visible = false;

            EQS.Visible = false;
            EQA.Visible = false;
            EQC.Visible = false;

            ILFS.Visible = false;
            ILFA.Visible = false;
            ILFC.Visible = false;

            EIFS.Visible = false;
            EIFA.Visible = false;
            EIFC.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton3.Checked == true)
            //{
            //    if (EINQ.SelectedIndex == 0)
            //    {
            //        TotalUFP += 3 * float.Parse(EINQBOX.Text);
            //        EQS.Visible = true;
            //        EQS.Text = EINQBOX.Text;
            //    }
            //    else if (EINQ.SelectedIndex == 1)
            //    {
            //        TotalUFP += 4 * float.Parse(EINQBOX.Text);
            //        EQA.Visible = true;
            //        EQA.Text = EINQBOX.Text;
            //    }
            //    else
            //    {
            //        TotalUFP += 6 * float.Parse(EINQBOX.Text);
            //        EQA.Visible = true;
            //        EQA.Text = EINQBOX.Text;
            //    }
            //    EQ_RadButton = true;
            //    EINQ.Text = "";
            //    EINQBOX.Text = "";
            //    radioButton3.Checked = false;

               
            //}
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton4.Checked == true)
            //{
            //    if (ILF.SelectedIndex == 0)
            //    {
            //        TotalUFP += 7 * float.Parse(ILFBOX.Text);
            //        ILFS.Visible = true;
            //        ILFS.Text = ILFBOX.Text;
            //    }
            //    else if (ILF.SelectedIndex == 1)
            //    {
            //        TotalUFP += 10 * float.Parse(ILFBOX.Text);
            //        ILFA.Visible = true;
            //        ILFA.Text = ILFBOX.Text;
            //    }
            //    else
            //    {
            //        TotalUFP += 15 * float.Parse(ILF.Text);
            //        ILFC.Visible = true;
            //        ILFC.Text = ILFBOX.Text;
            //    }
            //    ILF_RadButton = true;
            //    ILF.Text = "";
            //    ILFBOX.Text = "";
            //    radioButton4.Checked = false;


            //}
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton5.Checked == true)
            //{
            //    if (EIF.SelectedIndex == 0)
            //    {
            //        TotalUFP += 5 * float.Parse(EIFBOX.Text);
            //        EIFS.Visible = true;
            //        EIFS.Text = EIFBOX.Text;
            //    }
            //    else if (EIF.SelectedIndex == 1)
            //    {
            //        TotalUFP += 7 * float.Parse(EIFBOX.Text);
            //        EIFA.Visible = true;
            //        EIFA.Text = EIFBOX.Text;
            //    }
            //    else
            //    {
            //        TotalUFP += 10 * float.Parse(EIFBOX.Text);
            //        EIFA.Visible = true;
            //        EIFA.Text = EIFBOX.Text;
            //    }
            //    ELF_RadButton = true;
            //    EIF.Text = "";
            //    EIFBOX.Text = "";
            //    radioButton5.Checked = false;


            //}
        }

        private void EIC_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                if (EI.SelectedIndex == 0)
                {
                    TotalUFP += EISimple * float.Parse(EIBOX.Text);
                    EIS.Visible = true;
                    EIS.Text = EIBOX.Text;
                }
                else if (EI.SelectedIndex == 1)
                {
                    TotalUFP += EIAverage * float.Parse(EIBOX.Text);
                    EIA.Visible = true;
                    EIA.Text = EIBOX.Text;
                }
                else
                {
                    TotalUFP += EIComplex * float.Parse(EIBOX.Text);
                    EIC.Visible = true;
                    EIC.Text = EIBOX.Text;
                }
                EI_RadiButton = true;
                EI.Text = "";
                EIBOX.Text = "";
                //radioButton1.Checked = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (EO.SelectedIndex == 0)
                {
                    TotalUFP += EOSimple * float.Parse(EOBOX.Text);
                    EOS.Visible = true;
                    EOS.Text = EOBOX.Text;
                }
                else if (EO.SelectedIndex == 1)
                {
                    TotalUFP += EOAverage * float.Parse(EOBOX.Text);
                    EOA.Visible = true;
                    EOA.Text = EOBOX.Text;
                }
                else
                {
                    TotalUFP += EOComplex * float.Parse(EOBOX.Text);
                    EOC.Visible = true;
                    EOC.Text = EOBOX.Text;
                }
                EO_RadButton = true;
                EO.Text = "";
                EOBOX.Text = "";
                //radioButton2.Checked = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                if (EINQ.SelectedIndex == 0)
                {
                    TotalUFP += EQSimple * float.Parse(EINQBOX.Text);
                    EQS.Visible = true;
                    EQS.Text = EINQBOX.Text;
                }
                else if (EINQ.SelectedIndex == 1)
                {
                    TotalUFP += EQAverage * float.Parse(EINQBOX.Text);
                    EQA.Visible = true;
                    EQA.Text = EINQBOX.Text;
                }
                else
                {
                    TotalUFP += EQComplex * float.Parse(EINQBOX.Text);
                    EQA.Visible = true;
                    EQA.Text = EINQBOX.Text;
                }
                EQ_RadButton = true;
                EINQ.Text = "";
                EINQBOX.Text = "";
                //radioButton3.Checked = false;


            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                if (ILF.SelectedIndex == 0)
                {
                    TotalUFP += ILFSimple * float.Parse(ILFBOX.Text);
                    ILFS.Visible = true;
                    ILFS.Text = ILFBOX.Text;
                }
                else if (ILF.SelectedIndex == 1)
                {
                    TotalUFP += ILFAverage * float.Parse(ILFBOX.Text);
                    ILFA.Visible = true;
                    ILFA.Text = ILFBOX.Text;
                }
                else
                {
                    TotalUFP += ILFComplex * float.Parse(ILFBOX.Text);
                    ILFC.Visible = true;
                    ILFC.Text = ILFBOX.Text;
                }
                ILF_RadButton = true;
                ILF.Text = "";
                ILFBOX.Text = "";
                //radioButton4.Checked = false;


            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                if (EIF.SelectedIndex == 0)
                {
                    TotalUFP += EIFSimple * float.Parse(EIFBOX.Text);
                    EIFS.Visible = true;
                    EIFS.Text = EIFBOX.Text;
                }
                else if (EIF.SelectedIndex == 1)
                {
                    TotalUFP += EIFAverage* float.Parse(EIFBOX.Text);
                    EIFA.Visible = true;
                    EIFA.Text = EIFBOX.Text;
                }
                else
                {
                    TotalUFP += EIFComplex * float.Parse(EIFBOX.Text);
                    EIFC.Visible = true;
                    EIFC.Text = EIFBOX.Text;
                }
                ELF_RadButton = true;
                EIF.Text = "";
                EIFBOX.Text = "";
                //radioButton5.Checked = false;


            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (EI_RadiButton == false || EIBOX.Text != "")
            {
                if (EI.SelectedIndex == 0)
                {
                    TotalUFP += EISimple * float.Parse(EIBOX.Text);
                    EIS.Visible = true;
                    EIS.Text = EIBOX.Text;
                }
                else if (EI.SelectedIndex == 1)
                {
                    TotalUFP += EIAverage * float.Parse(EIBOX.Text);
                    EIA.Visible = true;
                    EIA.Text = EIBOX.Text;
                }
                else
                {
                    TotalUFP += EIComplex * float.Parse(EIBOX.Text);
                    EIC.Visible = true;
                    EIC.Text = EIBOX.Text;
                }

            }
            if (EO_RadButton == false || EOBOX.Text != "")
            {
                if (EO.SelectedIndex == 0)
                {
                    TotalUFP += EOSimple * float.Parse(EOBOX.Text);
                    EOS.Visible = true;
                    EOS.Text = EOBOX.Text;

                }
                else if (EO.SelectedIndex == 1)
                {
                    TotalUFP += EOAverage * float.Parse(EOBOX.Text);
                    EOA.Visible = true;
                    EOA.Text = EOBOX.Text;
                }
                else
                {
                    TotalUFP += EOComplex * float.Parse(EOBOX.Text);
                    EOC.Visible = true;
                    EOC.Text = EOBOX.Text;
                }
            }
            if (EQ_RadButton == false || EINQBOX.Text != "")
            {
                if (EINQ.SelectedIndex == 0)
                {
                    TotalUFP += EQSimple* float.Parse(EINQBOX.Text);
                    EQS.Visible = true;
                    EQS.Text = EINQBOX.Text;
                }
                else if (EINQ.SelectedIndex == 1)
                {
                    TotalUFP += EQAverage * float.Parse(EINQBOX.Text);
                    EQA.Visible = true;
                    EQA.Text = EINQBOX.Text;
                }
                else
                {
                    TotalUFP += EQComplex * float.Parse(EINQBOX.Text);
                    EQC.Visible = true;
                    EQC.Text = EINQBOX.Text;
                }
            }
            if (ILF_RadButton == false || ILFBOX.Text != "")
            {
                if (ILF.SelectedIndex == 0)
                {
                    TotalUFP += ILFSimple * float.Parse(ILFBOX.Text);
                    ILFS.Visible = true;
                    ILFS.Text = ILFBOX.Text;
                }
                else if (ILF.SelectedIndex == 1)
                {
                    TotalUFP += ILFAverage * float.Parse(ILFBOX.Text);
                    ILFA.Visible = true;
                    ILFA.Text = ILFBOX.Text;
                }
                else
                {
                    TotalUFP += ILFComplex * float.Parse(ILFBOX.Text);
                    ILFC.Visible = true;
                    ILFC.Text = ILFBOX.Text;
                }
            }
            if (ELF_RadButton == false || EIFBOX.Text != "")
            {
                if (EIF.SelectedIndex == 0)
                {
                    TotalUFP += EIFSimple * float.Parse(EIFBOX.Text);
                    EIFS.Visible = true;
                    EIFS.Text = EIFBOX.Text;
                }
                else if (EIF.SelectedIndex == 1)
                {
                    TotalUFP += EIFAverage * float.Parse(EIFBOX.Text);
                    EIFA.Visible = true;
                    EIFA.Text = EIFBOX.Text;
                }
                else
                {
                    TotalUFP += EIFComplex * float.Parse(EIFBOX.Text);
                    EIFC.Visible = true;
                    EIFC.Text = EIFBOX.Text;
                }
            }
            PassedUFP = TotalUFP;
            Result.Text = TotalUFP.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            TCF tcf = new TCF();
            tcf.Show();
            this.Hide();
        }
    }
}
