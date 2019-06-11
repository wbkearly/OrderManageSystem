using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Order
    {
        protected int id; //订单号
        protected int customerId; //顾客号
        protected DateTime orderTime; //订货日期
        protected bool isDealed; //是否已处理
        public int Id
        {
            get { return id; }
            set { id = value; } 
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public DateTime OrderTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }

        public bool IsDealed
        {
            get { return isDealed; }
            set { isDealed = value; }
        }

        public Order(int id, int customerId, DateTime orderTime)
        {
            this.id = id;
            this.customerId = customerId;
            this.orderTime = orderTime;
            this.isDealed = false;
        }
    }
}
