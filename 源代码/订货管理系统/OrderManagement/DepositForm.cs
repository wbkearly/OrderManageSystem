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
    public partial class DepositForm : Form
    {
        private Customer customer = null;
        public DepositForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            this.showCurrentBalanceLabel.Text = customer.Balance.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (depositTextBox.Text != "")
            {
                customer.Balance += float.Parse(depositTextBox.Text);
                SqlManage.updateCustomer(customer);
                this.showCurrentBalanceLabel.Text = customer.Balance.ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
