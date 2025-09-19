using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form_1 : Form
    {
        public Form_1()
        {
            InitializeComponent();
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                for(int i =0;i<n;i++)
                {
                    for(int j=i+1;j<=n;j++)
                    {
                        if(a[i]>a[j])
                        {
                            tam=a[i];
                            a[i]=a[j];
                            a[j]=tam;
                        }
                    }
                }
                s=" ";
                for(int i=0;i<=n;i++)
                {
                    s = s+" "+a[i].ToString();
                }
                txtKQ.Text = 5;
            }
            if(radioButton2.Checked==true)
            {
                for(int i=0;i<n;i++)
                {
                    for (int j = i + 1; j <= n; j++)
                    {
                        if (a[i] > a[j])
                        {
                            tam = a[i];
                            a[i] = a[j];
                            a[j] = tam;
                        }
                    }
                }
                s = " ";
                for (int i = 0; i <= n; i++)
                {
                    s = s + " " + a[i].ToString();
                }
                txtKQ.Text = 5;
            }
            if(radioButton4.Checked==true)
            {
                int x = Convert.ToInt32(txtGiaTriCanTim.Text);
                if(TimKiemGiaTri(a,n,x))
                {
                    MessageBox.Show("Tìm thấy" + x.ToString()+ "trong mảng"," kết quả tìm kiếm", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy" + x.ToString() + "trong mảng", " kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if(radioButton3.Checked==true)
            {
                int h = Convert.ToInt32(txtViTriCanTim.Text);
                for(int i = 0; i<=n;i++)
                {
                    if(txtViTriCanTim.Text!=" ")
                    {
                        if(i == h)
                        {
                            txtSoTimDuoc.Text = Convert.ToString(a[i]);
                        }
                    }
                }
            }
            if(radioButton6.Checked==true)
            {
                int gtxoa = Convert.ToInt32(txtGiaTriCanXoa.Text);
                for(int i=0;i<=n;i++)
                {
                    if(txtGiaTriCanXoa.Text!= " ")
                    {
                        if(a[i]==gtxoa)
                        {
                            for(int k=i;k<=n;k++)
                            {
                                a[k] = a[k + 1];
                            }
                            n--;
                            s = " ";
                            for(int i=0;i<=n;i++)
                            {
                                if (i == 0)
                                    s = s + a[i].ToString();
                                else
                                    s = s + " " + a[i].ToString();
                                txtKQ.Text = s.Trim();
                            }
                        }
                    }
                }
            }
            if(radioButton5.Checked==true)
            {
                int vitrixoa = Convert.ToInt32(txtViTriCanXoa.Text);
                for(int i=0;i<=n;i++)
                {
                    a[i] = a[i + 1];
                }
                n--;
                s = " ";
                for (int i = 0; i <= n; i++)
                {
                    if (i == 0)
                        s = s + a[i].ToString();
                    else
                        s = s + " " + a[i].ToString();
                    txtKQ.Text = s.Trim();
                }
            }
            if(radioButton8.Checked==true)
            {
                int giatriThem = Convert.ToInt32(txtGiaTriCanThem.Text);
                int vitrithem = Convert.ToInt32(txtViTriCanThem.Text);
                n++;
                for(int i=n;i>vitrithem;i--)
                {
                    if(i!=0)
                    {
                        a[i] = a[i - 1];
                    }
                }
                a[vitrithem] = giatriThem;
                s = " ";
                for (int i = 0; i <= n; i++)
                {
                    if (i == 0)
                        s = s + a[i].ToString();
                    else
                        s = s + " " + a[i].ToString();
                    txtKQ.Text = s.Trim();
                }
            }
            if(radioButton9.Checked==true)
            {
                int giatrithaythe = 0, sothaythe = 0;
                try
                {
                    giatrithaythe = Convert.ToInt32(txtGiaTriThayThe.Text);
                    sothaythe=
                }
            }
        }
    }
}
