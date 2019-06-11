using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Goods
    {
        protected int goodsId; //货物号
        protected float price; //单价
        protected string mfrs; //制造厂商
        protected int actualStorage; //厂商实际存货量
        protected int minStorage; //最低存货量
        protected string desc; //货物描述

        public int GoodsId
        {
            get { return goodsId; }
            set { goodsId = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Mfrs
        {
            get { return mfrs; }
            set { mfrs = value; }
        }

        public int ActualStorage
        {
            get { return actualStorage; }
            set { actualStorage = value; }
        }
        public int MinStorage
        {
            get { return minStorage; }
            set { minStorage = value; }
        }


        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        public Goods(int goodsId, float price, string mfrs, int actualStorage, int minStorage, string desc)
        {
            this.goodsId = goodsId;
            this.price = price;
            this.mfrs = mfrs;
            this.actualStorage = actualStorage;
            this.minStorage = minStorage;
            this.desc = desc;
        }
      
    }
}
