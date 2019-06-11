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
    public partial class OrderQueryForm : Form
    {
        private Customer customer = null;
        private int orderId;
        public OrderQueryForm()
        {
            InitializeComponent();
        }

        public OrderQueryForm(Customer customer, int orderId)
        {
            this.customer = customer;
            this.orderId = orderId;
            InitializeComponent();
        }

        private void orderQueryButton_Click(object sender, EventArgs e)
        {
            if (inputOrderIdTextBox.Text != "")
            {
                orderId = Convert.ToInt32(this.inputOrderIdTextBox.Text);
                orderIdTextBox.Text = orderId.ToString();
                if(customer != null)
                {
                    if(SqlManage.orderQuery(orderId).CustomerId == customer.CustomerId)
                    {
                        customerIdTextBox.Text = SqlManage.orderQuery(orderId).CustomerId.ToString();
                        customerNameTextBox.Text = SqlManage.customerQuery(Convert.ToInt32(SqlManage.orderQuery(orderId).CustomerId)).Name;
                        myDataGridView.DataSource = SqlManage.detailQuery(orderId).Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("该用户没有此订单!");
                    }
                }
                else
                {
                    customerIdTextBox.Text = SqlManage.orderQuery(orderId).CustomerId.ToString();
                    customerNameTextBox.Text = SqlManage.customerQuery(Convert.ToInt32(SqlManage.orderQuery(orderId).CustomerId)).Name;
                    myDataGridView.DataSource = SqlManage.detailQuery(orderId).Tables[0];
                }
               
            }
            else
            {
                MessageBox.Show("订单号不能为空!");
            }  
        }

        private void OrderQueryForm_Load(object sender, EventArgs e)
        {
            if(customer != null)
            {
                orderIdTextBox.Text = orderId.ToString();
                customerIdTextBox.Text = SqlManage.orderQuery(orderId).CustomerId.ToString();
                customerNameTextBox.Text = SqlManage.customerQuery(Convert.ToInt32(SqlManage.orderQuery(orderId).CustomerId)).Name;
                myDataGridView.DataSource = SqlManage.detailQuery(orderId).Tables[0];
            }
            else
            {
                dealButton.Hide();
            }
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            float amount = SqlManage.amountQuery(orderId);
            Order order = SqlManage.orderQuery(orderId);
            int customerId = order.CustomerId;
            Customer customer = SqlManage.customerQuery(customerId);
            order.IsDealed = true;
            if(amount < customer.Balance + customer.CustomerCreditLimit)
            {
                Bill bill = null;
                DateTime payDate = DateTime.Now;
                float amountPayable = amount;
                float payAmount;
                int billId = SqlManage.queryMaxBillId() + 1;
                if (customer.Balance < amount)
                    payAmount = customer.Balance;
                else
                    payAmount = amount;
                bill = new Bill(billId, orderId, amountPayable, payDate, payAmount);
                SqlManage.insertBill(bill);

                customer.Balance -= amount;
                if (SqlManage.updateCustomer(customer)
               && SqlManage.updateOrder(order))
                {
                    //更新库存
                    for (int i = 0; i < myDataGridView.RowCount - 1; i++)
                    {
                        int goodsId = Convert.ToInt32(myDataGridView[0, i].Value);
                        Goods goods = SqlManage.goodsQuery(goodsId);
                        int goodsNum = Convert.ToInt32(myDataGridView[1, i].Value);
                        goods.ActualStorage -= goodsNum;
                        SqlManage.updateGoods(goods);
                    }
                    MessageBox.Show("支付成功!");
                }   
            }
            else
            {
                MessageBox.Show("已超出最大赊购限额！");
            }
           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
