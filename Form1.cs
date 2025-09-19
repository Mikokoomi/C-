using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double a, b, c, data, x1, x2;
        String s;

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                if (a == 0)
                    if (b == 0)
                        txtkq.Text = "Phương trình vô số nghiệm";
                    else
                        txtkq.Text = "Phương trình vô nghiệm";
                else
                    txtkq.Text = "Phương trình có nghiệm:" + ((-b) / a).ToString();
            }
            if(radioButton2.Checked==true)
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                if (a == 0)
                    if (b == 0)
                        if (c == 0)
                            txtkq.Text = "Phương trình vô số nghiệm";
                        else
                            txtkq.Text = "Phương trình vô nghiệm";
                    else
                        txtkq.Text = "Phương trình có nghiệm: " + ((-c) / b).ToString();
                else
                {
                    data = ((b * b) - (4 * a * c));
                    if (data < 0)
                        txtkq.Text = "Phương trình vô nghiệm";
                    else
                    {
                        if (data == 0)
                            txtkq.Text = "Phương trình có nghiệm kép: " + (-b) / (2 * a);
                        else
                        {
                            x1 = (-b + Math.Sqrt(data) / (2 * a));
                            x2 = (b + Math.Sqrt(data) / (2 * a));
                            txtkq.Text = "Phương trình có hai nghiệm phân biệt: " + "x1 = " + String.Format("{0:0.00}", x1) + "x2 = " + String.Format("{0:0.00}", x2);
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Enabled = false;
            button1.Enabled = true;
            this.txta.ResetText();
            this.txtb.ResetText();
            this.txtc.ResetText();
            this.txtkq.ResetText();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Enabled = true;
            button1.Enabled = true;
            this.txta.ResetText();
            this.txtb.ResetText();
            this.txtc.ResetText();
            this.txtkq.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txta.Focus();
        }

    }
}
