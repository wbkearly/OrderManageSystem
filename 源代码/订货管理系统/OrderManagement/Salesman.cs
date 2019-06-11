using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class Salesman
    {
        protected int salesmanId; //职工号
        protected string name; //姓名
        protected string password; //密码

        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Salesman(int salesmanId, String name, String password) //构造函数
        {
            this.salesmanId = salesmanId;
            this.name = name;
            this.password = password;
        }
    }
}
