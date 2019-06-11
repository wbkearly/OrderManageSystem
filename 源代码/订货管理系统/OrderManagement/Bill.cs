using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Bill
    {
        protected int billId; //账单号
        protected int orderId; //订单号
        protected float amountPayable; //应付金额
        protected DateTime payDate; //付款日期
        protected float payAmount; //付款金额

        public int BillId
        {
            get { return billId; }
            set { billId = value; }
        }

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public float AmountPayable
        {
            get { return amountPayable; }
            set { amountPayable = value; }
        }

        public DateTime PayDate
        {
            get { return payDate; }
            set { payDate = value; }
        }
        public float PayAmount
        {
            get { return payAmount; }
            set { payAmount = value; }
        }

        public Bill(int billId, int orderId, float amountPayable, DateTime payDate, float payAmount)
        {
            this.billId = billId;
            this.orderId = orderId;
            this.amountPayable = amountPayable;
            this.payDate = payDate;
            this.payAmount = payAmount;
        }
    }
}
