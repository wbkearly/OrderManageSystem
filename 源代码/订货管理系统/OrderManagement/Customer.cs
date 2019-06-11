using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class Customer //顾客类
    {
        protected string name; //顾客姓名
        protected int customerId; //顾客号
        protected string password; //登录密码
        protected string address; //顾客地址
        protected float balance; //余额
        protected float customerCreditLimit; //赊购限额

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public float CustomerCreditLimit
        {
            get { return customerCreditLimit; }
            set { customerCreditLimit = value; }
        }

        public Customer(int customerId, String name, String password, String address) //构造函数
        {
            this.customerId = customerId;
            this.name = name;
            this.password = password;
            this.address = address;
        }

        public Customer(int customerId, String name, String password, String address, float balance, float customerCreditLimit) //构造函数
        {
            this.customerId = customerId;
            this.name = name;
            this.password = password;
            this.address = address;
            this.balance = balance;
            this.customerCreditLimit = customerCreditLimit;
        }
    }
}
