using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ".";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "0";
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "3";
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "4";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "9";
        }

        private void btnplusandminus_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "-";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
            textstore.Clear();
        }
        float num;
        int count;
        private void btnmin_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresult.Text = textstore.Text + "-";
                textstore.Clear();
                count = 1;
            }

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresult.Text = textstore.Text + "+";
                textstore.Clear();
                count = 2;
            }

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresult.Text = textstore.Text + "X";
                textstore.Clear();
                count = 3;
            }
        }

        private void btndevide_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresult.Text = textstore.Text + "/";
                textstore.Clear();
                count = 4;
            }
        }

        private void btnrd_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresult.Text = textstore.Text + "%";
                textstore.Clear();
                count = 5;
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float ans;
            switch(count)
            {   
                case 1:
                    ans=num-float.Parse(textstore.Text);
                    txtresult.Text = txtresult.Text + textstore.Text + "="+ans;
                    textstore.Text = ans.ToString();
                    break;
                    case 2:
                    ans = num + float.Parse(textstore.Text);
                    txtresult.Text = txtresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textstore.Text);
                    txtresult.Text = txtresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textstore.Text);
                    txtresult.Text = txtresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
                case 5:
                    ans = num % float.Parse(textstore.Text);
                    txtresult.Text = txtresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
            }
        }
    }
}
