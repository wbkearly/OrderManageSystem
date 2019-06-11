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
    public partial class GoodsStatisticForm : Form
    {
        public GoodsStatisticForm()
        {
            InitializeComponent();
        }

        private void GoodsStatisticForm_Load(object sender, EventArgs e)
        {
            myDataGridView.DataSource = SqlManage.goodsBrowse().Tables[0];
            for (int i = 0; i < myDataGridView.Rows.Count - 1; i++)
            {
                int store = int.Parse(myDataGridView.Rows[i].Cells[4].Value.ToString());
                int goodsId = int.Parse(myDataGridView.Rows[i].Cells[0].Value.ToString());
                if (store < SqlManage.goodsQuery(goodsId).MinStorage)
                {
                    for (int j = 0; j < myDataGridView.ColumnCount; j++)
                        myDataGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }      
            }
        }

        private void shuaXinButton_Click(object sender, EventArgs e)
        {
            myDataGridView.DataSource = SqlManage.goodsBrowse().Tables[0];
            for (int i = 0; i < myDataGridView.Rows.Count; i++)
            {
                int store = int.Parse(myDataGridView.Rows[i].Cells[4].Value.ToString());
                int goodsId = int.Parse(myDataGridView.Rows[i].Cells[0].Value.ToString());
                if (store < SqlManage.goodsQuery(goodsId).MinStorage)
                    myDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Red;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
