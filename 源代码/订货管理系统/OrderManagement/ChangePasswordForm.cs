using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement
{
    public partial class ChangePasswordForm : Form
    {
        private Customer customer;
        public ChangePasswordForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(customer.Password == oldPasswordTextBox.Text)
            {
                if(newPasswordTextBox.Text == "")
                {
                    MessageBox.Show("新密码不能为空!");
                }
                else if(newPasswordTextBox.Text == confirmTextBox.Text)
                {
                    customer.Password = newPasswordTextBox.Text;
                    SqlManage.updateCustomer(customer);
                    MessageBox.Show("修改成功!");
                }
                else
                {
                    MessageBox.Show("确认密码与新密码不一致!");
                }
            }
            else
            {
                MessageBox.Show("原密码输入不正确!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
