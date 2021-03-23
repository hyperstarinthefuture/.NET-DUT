using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cbb1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //this.Close();
                this.Dispose();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double d = 0;
            //tbx2.text = d.tostring();
            //Tbx2.Text = Total().ToString();
            if (Tbx1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng!");
            }
            else
            {
                if (CBx1.Checked == false && CBx2.Checked == false && CBx3.Checked == false)
                {
                    MessageBox.Show("Bạn chưa chọn dịch vụ chăm sóc răng!");
                }    
                else
                {
                    if (Convert.ToInt32(Cbb1.SelectedItem.ToString()) == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn số răng cần chăm sóc!");
                    }
                    else
                    {
                        Tbx2.Text = Total().ToString();
                    }    
                }    
            }    
        }
        private double Total()
        {
            double s = 0;
            //Code tinh tien
            if (CBx1.Checked)
            {
                s += 100;
            }
            if (CBx2.Checked)
            {
                s += 1200;
            }
            if (CBx3.Checked)
            {
                s += 200;
            }
            //string select = Cbb1.SelectedItem.ToString();
            //int index = Cbb1.SelectedIndex;
            //string select = Cbb1.Items[index].ToString();
            //int r = Convert.ToInt32(select);
            //s += r * 80;
            s += Convert.ToInt32(Cbb1.SelectedItem.ToString()) * 80;
            return s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tbx1.Text = "";
            Tbx2.Text = "";
            Cbb1.SelectedIndex = 0;
            CBx1.Checked = false;
            CBx2.Checked = false;
            CBx3.Checked = false;
        }
    }
}
//Date created: March 22, 2021
//Last Update: March 23, 2021
