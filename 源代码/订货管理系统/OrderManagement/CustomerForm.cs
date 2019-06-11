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
    public partial class CustomerForm : Form
    {
        private Customer customer;
        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            if (customer != null) this.wecomeLabel.Text = "欢迎，" + customer.Name + "！";
            else this.wecomeLabel.Text = "欢迎！";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void goodsBrowseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsBrowseForm goodsBrowseForm = new GoodsBrowseForm(customer);
            goodsBrowseForm.MdiParent = this;
            goodsBrowseForm.Show();
        }

        private void myOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrderForm showOrderForm = new ShowOrderForm(customer);
            showOrderForm.MdiParent = this;
            showOrderForm.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(customer);
            depositForm.MdiParent = this;
            depositForm.Show();

        }

        private void selfCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelfCenterForm selfCenterForm = new SelfCenterForm(customer);
            selfCenterForm.MdiParent = this;
            selfCenterForm.Show();
        }
    }
}
