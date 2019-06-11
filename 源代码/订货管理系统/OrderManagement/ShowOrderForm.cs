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
    public partial class ShowOrderForm : Form
    {
        private Customer customer = null;
        public ShowOrderForm()
        {
            InitializeComponent();
        }

        public ShowOrderForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void ShowOrderForm_Load(object sender, EventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(customer == null)
            {
                if (treeView1.SelectedNode.Name == "allColumnHeader")
                {
                    myDataGridView.DataSource = SqlManage.showAllUserOrder(0).Tables[0];
                }
                else if (treeView1.SelectedNode.Name == "dealedHeader")
                {
                    myDataGridView.DataSource = SqlManage.showAllUserOrder(1).Tables[0];
                }
                else if (treeView1.SelectedNode.Name == "undealedHeader")
                {
                    myDataGridView.DataSource = SqlManage.showAllUserOrder(2).Tables[0];
                }
            }
            else
            {
                if (treeView1.SelectedNode.Name == "allColumnHeader")
                {
                    myDataGridView.DataSource = SqlManage.showUserOrder(customer, 0).Tables[0];
                }
                else if (treeView1.SelectedNode.Name == "dealedHeader")
                {
                    myDataGridView.DataSource = SqlManage.showUserOrder(customer, 1).Tables[0];
                }
                else if (treeView1.SelectedNode.Name == "undealedHeader")
                {
                    myDataGridView.DataSource = SqlManage.showUserOrder(customer, 2).Tables[0];
                }
            }
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(myDataGridView.SelectedCells[0].Value);
            OrderQueryForm orderQueryForm = new OrderQueryForm(customer, orderId);
            orderQueryForm.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
