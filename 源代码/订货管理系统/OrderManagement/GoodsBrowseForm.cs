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
    public partial class GoodsBrowseForm : Form
    {
        ShoppingCart shopCart;
        private Customer customer;
        public GoodsBrowseForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void addGoodsButton_Click(object sender, EventArgs e)
        {
           if(goodsIdTextBox.Text != "" && orderNumTextBox.Text != "")
           {
               int detailId = SqlManage.queryMaxDetailId() + 1;
               int goodsId = Convert.ToInt32(goodsIdTextBox.Text);
               Goods goods = SqlManage.goodsQuery(goodsId);
               int goodsNum = Convert.ToInt32(orderNumTextBox.Text);
               if(goods.ActualStorage >= goodsNum)
               {
                   float amount = goods.Price * goodsNum;
                   ListViewItem listViewItem = new ListViewItem();
                   listViewItem.Text = goodsId.ToString();
                   listViewItem.SubItems.Add(goods.Desc);
                   listViewItem.SubItems.Add(goods.Price.ToString());
                   listViewItem.SubItems.Add(goodsNum.ToString());
                   listViewItem.SubItems.Add(amount.ToString());
                   shopCart.listView1.Items.Add(listViewItem);
                   MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK);
               }
               else
               {
                   MessageBox.Show("超出了库存数量!");
               }
           }
           else
           {
               MessageBox.Show("请选择订货商品和数目!");
           }
        }

        private void GoodsBrowseForm_Load(object sender, EventArgs e)
        {
            goodsBrowseDataGridView.DataSource = SqlManage.goodsBrowse().Tables[0];
            shopCart = new ShoppingCart(customer);
        }

        private void shuaXinButton_Click(object sender, EventArgs e)
        {
            goodsBrowseDataGridView.DataSource = SqlManage.goodsBrowse().Tables[0];
        }

        private void goodsBrowseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && !goodsBrowseDataGridView.Rows[e.RowIndex].IsNewRow)
            {
                string goodsId = goodsBrowseDataGridView.Rows[e.RowIndex].Cells["货物号"].Value.ToString();
                string goodsDesc = goodsBrowseDataGridView.Rows[e.RowIndex].Cells["货物描述"].Value.ToString();
                goodsIdTextBox.Text = goodsId;
                goodsDescTextBox.Text = goodsDesc;
            }
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            shopCart.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
