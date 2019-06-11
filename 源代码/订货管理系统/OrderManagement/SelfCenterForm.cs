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
    public partial class SelfCenterForm : Form
    {
        Customer customer = null;
        public SelfCenterForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void SelfCenterForm_Load(object sender, EventArgs e)
        {
            this.showBalanceLabel.Text = customer.Balance.ToString();
            this.showNameLabel.Text = customer.Name;
            this.showUserNameLabel.Text = customer.CustomerId.ToString();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(customer);
            depositForm.Show();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(customer);
            changePasswordForm.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
