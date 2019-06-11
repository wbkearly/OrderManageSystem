using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Detail
    {
        protected int detailId; //订货细则号
        public int DetailId
        {
            get { return detailId; }
            set { detailId = value; }
        }
        protected int orderId; //订单号
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        protected int goodsId; //商品号
        public int GoodsId
        {
            get { return goodsId; }
            set { goodsId = value; }
        }
        protected int goodsNum; //商品数额
        public int GoodsNum
        {
            get { return goodsNum; }
            set { goodsNum = value; }
        }

        protected float amount; //金额
        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        protected int discId; //折扣号
        public int DiscId
        {
            get { return discId; }
            set { discId = value; }
        }

        public Detail(int detailId, int orderId, int goodsId, int goodsNum, float amount, int discId)
        {
            this.detailId = detailId;
            this.orderId = orderId;
            this.goodsId = goodsId;
            this.goodsNum = goodsNum;
            this.amount = amount;
            this.discId = discId;
        }
    }
}
