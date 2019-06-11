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
    public partial class SalesmanForm : Form
    {
        private Salesman salesman = null;

        public SalesmanForm(Salesman salesman)
        {
            this.salesman = salesman;
            InitializeComponent();
        }

        private void SalesmanForm_Load(object sender, EventArgs e)
        {
            if (salesman == null) this.welcomeLabel.Text = "欢迎!";
            else this.welcomeLabel.Text = "欢迎," + salesman.Name + "!";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void orderQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderQueryForm orderQueryForm = new OrderQueryForm();
            orderQueryForm.Show();
        }

        private void stockStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsStatisticForm goodsStatisticForm = new GoodsStatisticForm();
            goodsStatisticForm.Show();
        }

        private void orderStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrderForm showOrderForm = new ShowOrderForm();
            showOrderForm.Show();
        }
    }
}
