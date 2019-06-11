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
    public partial class ShoppingCart : Form
    {
        private Customer customer;
        public ShoppingCart(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {   
            if(listView1.Items.Count < 1)
            {
                MessageBox.Show("购物车里没有任何物品!");
            }
            float sumAmount = 0;
            foreach (ListViewItem item in this.listView1.Items)
            {
                float amount = float.Parse(item.SubItems[4].Text);
            }
            if(customer.Balance + customer.CustomerCreditLimit >= sumAmount)
            {
                DateTime datetime = DateTime.Now;
                int orderId = SqlManage.queryMaxOrderId() + 1;
                SqlManage.insertOrder(orderId, customer.CustomerId, datetime);
                foreach (ListViewItem item in this.listView1.Items)
                {
                    int detailId = SqlManage.queryMaxDetailId() + 1;
                    int goodsId = Convert.ToInt32(item.SubItems[0].Text);
                    int goodsNum = Convert.ToInt32(item.SubItems[3].Text);
                    float amount = float.Parse(item.SubItems[4].Text);
                    Detail detail = new Detail(detailId, orderId, goodsId, goodsNum, amount, 0);
                    SqlManage.insertDetail(detail);
                }
                MessageBox.Show("下单成功!");
            }
            else 
            {
                MessageBox.Show("已超出最大赊购限额!");
            } 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有选择任一行!");
            }
            else
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}
