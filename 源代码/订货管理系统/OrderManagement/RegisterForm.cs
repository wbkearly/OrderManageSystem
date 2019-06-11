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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string name = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            string address = addressTextBox.Text;
            int id = SqlManage.queryMaxCustomerId()+ 1;
            if(password == confirmPassword)
            {
                Customer customer = new Customer(id, name, password, address);
                SqlManage.insertCustomer(customer);
            }
            else
            {
                MessageBox.Show("两次密码不一致!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
