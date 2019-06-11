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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userNameTextBox.Text);
            string password = passwordTextBox.Text;
            if(customerRadioButton.Checked)
            {
                //查询客户表是否有用户名存在
                Customer customer = SqlManage.searchCustomer(id, password);
                if(customer != null)
                {
                    CustomerForm customerForm = new CustomerForm(customer);
                    customerForm.Visible = true;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!");
                }
            }
            else if(salesmanRadioButton.Checked)
            {
                //查询销售员表
                Salesman salesman = SqlManage.searchSalesman(id, password);
                if (salesman != null)
                {
                    SalesmanForm salesmanForm = new SalesmanForm(salesman);
                    salesmanForm.Visible = true;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
            else
            {
                MessageBox.Show("你未选择身份!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要关闭吗?", "确认退出?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
                System.Environment.Exit(0);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Visible = true;
        }

        private void salesmanRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}