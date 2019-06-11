using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace OrderManagement
{
    //数据库管理类
    class SqlManage
    {
        private static SqlConnection mySqlConnection = new SqlConnection(); // 创建SqlConnection
        private static bool isConnectToDatabase = false;

        /* 数据库连接 */
        public static bool connectToDatabase(String connection)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open(); //打开连接
                mySqlConnection = conn;
                isConnectToDatabase = true;
            }
            catch(Exception)
            {
                MessageBox.Show("连接数据库失败!");
                return false;
            }
            return true; //返回连接对象
        }

        /* 断开数据库连接 */
        public static bool disConnectToDatabase()
        {
            try 
            {
                mySqlConnection.Close();  //关闭连接
                mySqlConnection.Dispose(); // 释放SqlConnection对象
                isConnectToDatabase = false;
            }
            catch(Exception)
            {
                MessageBox.Show("关闭数据库失败!");
                return false;
            }
            return true;
        }

        /* 查找销售管理员 */
        public static Salesman searchSalesman(int id, string password)
        {
            if (!isConnectToDatabase)
            {
                MessageBox.Show("未连接数据库!");
                return null;
            }
            Salesman salesman = null;

            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand
            
            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand(); 
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select * from [OrderDB].[dbo].[Salesman] where Salesman_Id = '" + id
                + "' and Salesman_Password = '" + password + "'";
            try
            {
                SqlDataReader myDataReader = mySqlCommand.ExecuteReader(); //执行查询指令并返回查询结果
                if (myDataReader.Read())
                {
                    string name = myDataReader["Salesman_Name"].ToString();
                    salesman = new Salesman(id, name, password);
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!");
                }
                myDataReader.Dispose();     // 释放SqlDataReader对象
            }
            catch(SqlException)
            {
                MessageBox.Show("Sql语句书写错误！");
            }
            mySqlCommand.Dispose();     // 释放SqlCommand对象
            return salesman; 
        }

        /* 查询普通用户 */
        public static Customer searchCustomer(int id, string password)
        {
            if (!isConnectToDatabase)
            {
                MessageBox.Show("未连接数据库!");
                return null;
            }
            Customer customer = null;

            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand(); 
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select * from [OrderDB].[dbo].[Customer] where Customer_Id = '" + id
                + "' and Customer_Password = '" + password + "'";
            try
            {
                SqlDataReader myDataReader = mySqlCommand.ExecuteReader(); //执行查询指令并返回查询结果  
                if (myDataReader.Read())
                {
                    string name = myDataReader["Customer_Name"].ToString();
                    string address = myDataReader["Customer_Address"].ToString();
                    customer = new Customer(id, name, password, address);
                    customer.Balance = float.Parse(myDataReader["Customer_Balance"].ToString());
                    customer.CustomerCreditLimit = float.Parse(myDataReader["Customer_Credit_Limit"].ToString());
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!");
                }
                myDataReader.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show("Sql语句书写错误！");
            }
            mySqlCommand.Dispose();
            return customer;
        }

        /* 查询库中最大的顾客号 */
        public static int queryMaxCustomerId()
        {
            int maxId = 0;
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select max(Customer_Id) from [OrderDB].[dbo].[Customer]";
            try
            {
                maxId = Convert.ToInt32(mySqlCommand.ExecuteScalar());
            }
            catch
            {
                maxId = 10000;
            }
            mySqlCommand.Dispose();
            return maxId;
        }

        /* 注册成为新顾客，理论上不能通过注册成为管理人员 */
        public static bool insertCustomer(Customer customer)
        {
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand(); 
            mySqlCommand.CommandType = CommandType.Text;
            int id = customer.CustomerId;
            string name = customer.Name;
            string password = customer.Password;
            string address = customer.Address;
            float balance = 0;
            float credit_limit = 1000;
            mySqlCommand.CommandText = "insert into [OrderDB].[dbo].[Customer](Customer_Id, Customer_Name, "
                 + "Customer_Password, Customer_Address, Customer_Balance, Customer_Credit_Limit)"
                 + " values(@id, @name, @password, @address, @balance, @credit_limit)";
            mySqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mySqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            mySqlCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            mySqlCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            mySqlCommand.Parameters.Add("@balance", SqlDbType.Float).Value = balance;
            mySqlCommand.Parameters.Add("@credit_limit", SqlDbType.Float).Value = credit_limit;
            try 
            {
                mySqlCommand.ExecuteNonQuery(); //执行插入SQL语句
            }
            catch(SqlException)
            {
                MessageBox.Show("插入出错!");
                mySqlCommand.Dispose();
                return false;
            }
            mySqlCommand.Dispose();
            return true;
        }

        /* 修改顾客个人信息,用户可以有充值功能 */
        public static bool updateCustomer(Customer customer)
        {
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand(); 
            mySqlCommand.CommandType = CommandType.Text;
            int id = customer.CustomerId;
            string password = customer.Password;
            string address = customer.Address;
            float balance = customer.Balance;

            mySqlCommand.CommandText = "update [OrderDB].[dbo].[Customer] set Customer_Password = @password," 
                + " Customer_Address = @address, Customer_Balance = @balance"
                + " where Customer_Id = '" + id + "'";
            mySqlCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            mySqlCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            mySqlCommand.Parameters.Add("@balance", SqlDbType.Float).Value = balance;
            try
            {
                mySqlCommand.ExecuteNonQuery(); //执行修改SQL语句
            }
            catch (SqlException)
            {
                MessageBox.Show("修改出错!");
                mySqlCommand.Dispose();
                return false;
            }
            mySqlCommand.Dispose();
            return true;
        }

        /* 查询库中最大的订单号 */
        public static int queryMaxOrderId()
        {
            int maxId = 0;
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand(); 
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select max(Order_Id) from [OrderDB].[dbo].[Order]";
            try
            {
                maxId = Convert.ToInt32(mySqlCommand.ExecuteScalar());
            }
            catch
            {
                maxId = 40000;
            }
            mySqlCommand.Dispose();
            return maxId;
        }

        /* 查询库中最大的订单号 */
        public static int queryMaxBillId()
        {
            int maxId = 0;
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select max(Bill_Id) from [OrderDB].[dbo].[Bill]";
            try
            {
                maxId = Convert.ToInt32(mySqlCommand.ExecuteScalar());
            }
            catch
            {
                maxId = 60000;
            }
            mySqlCommand.Dispose();
            return maxId;
        }

        /* 修改订单信息 */
        public static bool updateOrder(Order order)
        {
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            int orderId = order.Id;
            int customerId = order.CustomerId;
            DateTime dateTime = order.OrderTime;
            bool isDealed = order.IsDealed;

            mySqlCommand.CommandText = "update [OrderDB].[dbo].[Order] set Customer_Id = @customerId, Order_Date = @dateTime, Is_Dealed = @isDealed"
                + " where Order_Id = '" + orderId + "'";
            mySqlCommand.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
            mySqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = dateTime;
            mySqlCommand.Parameters.Add("@isDealed", SqlDbType.Bit).Value = isDealed;
            try
            {
                mySqlCommand.ExecuteNonQuery(); //执行修改SQL语句
            }
            catch (SqlException)
            {
                MessageBox.Show("修改出错!");
                mySqlCommand.Dispose();
                return false;
            }
            mySqlCommand.Dispose();
            return true;
        }

        /* 更新库存 */
        public static bool updateGoods(Goods goods)
        {
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            int goodsId = goods.GoodsId;
            float price = goods.Price;
            string mfrs = goods.Mfrs;
            int actualStore = goods.ActualStorage;
            int minStore = goods.MinStorage;
            string goodsDesc = goods.Desc;
            mySqlCommand.CommandText = "update [OrderDB].[dbo].[Goods] set Price = @price, Mfrs = @mfrs, Actual_Store = @actualStore,"
                + " Min_Store = @minStore, Goods_Desc = @goodsDesc"
                + " where Goods_Id = '" + goodsId + "'";
            mySqlCommand.Parameters.Add("@price", SqlDbType.Int).Value = price;
            mySqlCommand.Parameters.Add("@mfrs", SqlDbType.NVarChar).Value = mfrs;
            mySqlCommand.Parameters.Add("@actualStore", SqlDbType.Int).Value = actualStore;
            mySqlCommand.Parameters.Add("@minStore", SqlDbType.Int).Value = minStore;
            mySqlCommand.Parameters.Add("@goodsDesc", SqlDbType.NVarChar).Value = goodsDesc;
            try
            {
                mySqlCommand.ExecuteNonQuery(); //执行修改SQL语句
            }
            catch (SqlException)
            {
                MessageBox.Show("修改出错!");
                mySqlCommand.Dispose();
                return false;
            }
            mySqlCommand.Dispose();
            return true;
        }
        //查询订单库，生成订单号
        //int orderId = queryOrderNum() + 1;
        /* 新增订单，用户有 付款 功能， 付款之后管理员有 处理订单 功能*/
        public static bool insertOrder(int orderId, int customerId, DateTime orderTime)
        {
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand(); 
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "insert into [OrderDB].[dbo].[Order](Order_Id, Customer_Id, Order_Date, Is_Dealed)"
                 + "values(@orderId, @customerId, @orderDate, @isDealed)";
            mySqlCommand.Parameters.Add("@orderId", SqlDbType.Int).Value = orderId;
            mySqlCommand.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
            mySqlCommand.Parameters.Add("@orderDate", SqlDbType.DateTime).Value = orderTime;
            mySqlCommand.Parameters.Add("@isDealed", SqlDbType.Bit).Value = 0;
            try
            {
                mySqlCommand.ExecuteNonQuery(); //执行插入SQL语句
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                mySqlCommand.Dispose();
                return false;
            }
            mySqlCommand.Dispose();
            return true;
        }

        /* 插入账单 */
        public static bool insertBill(Bill bill)
        {
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "insert into [OrderDB].[dbo].[Bill](Bill_Id, Order_Id, Amount_Payable, Pay_Date, Pay_Amount)"
                 + "values(@billId, @orderId, @amountPayable, @payDate, @payAmount)";
            mySqlCommand.Parameters.Add("@billId", SqlDbType.Int).Value = bill.BillId;
            mySqlCommand.Parameters.Add("@orderId", SqlDbType.Int).Value = bill.OrderId;
            mySqlCommand.Parameters.Add("@amountPayable", SqlDbType.Float).Value = bill.AmountPayable;
            mySqlCommand.Parameters.Add("@payDate", SqlDbType.DateTime).Value = bill.PayDate;
            mySqlCommand.Parameters.Add("@payAmount", SqlDbType.Float).Value = bill.PayAmount;
            try
            {
                mySqlCommand.ExecuteNonQuery(); //执行插入SQL语句
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                mySqlCommand.Dispose();
                return false;
            }
            mySqlCommand.Dispose();
            return true;
        }

        //生成订单细则
        public static bool insertDetail(Detail detail)
        {
            int detailId = detail.DetailId; 
            int orderId = detail.OrderId;
            int goodsId = detail.GoodsId;
            int goodsNum = detail.GoodsNum;
            float amount = detail.Amount;
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "insert into [OrderDB].[dbo].[Detail](Detail_Id, Order_Id, "
                 + "Goods_Id, Goods_Num, Amount)"
                 + " values(@detailId, @orderId, @goodsId, @goodsNum, @amount)";
            mySqlCommand.Parameters.Add("@detailId", SqlDbType.Int).Value = detailId;
            mySqlCommand.Parameters.Add("@orderId", SqlDbType.Int).Value = orderId;
            mySqlCommand.Parameters.Add("@goodsId", SqlDbType.Int).Value = goodsId;
            mySqlCommand.Parameters.Add("@goodsNum", SqlDbType.Int).Value = goodsNum;
            mySqlCommand.Parameters.Add("@amount", SqlDbType.Float).Value = amount; 
            try
            {
                mySqlCommand.ExecuteNonQuery(); //执行插入SQL语句
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                mySqlCommand.Dispose();
                return false;
            }
            mySqlCommand.Dispose();
            return true;
        }

        /* 显示库存信息 */
        public static DataSet goodsBrowse()
        {
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select Goods_Id 货物号, Price 货物价格, Mfrs 生产厂商, Goods_Desc 货物描述, Actual_Store 库存 from [OrderDB].[dbo].[Goods]";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = mySqlCommand;
            DataSet dataSet = new DataSet();
            myDataAdapter.Fill(dataSet); //用查询结果填充数据集
            return dataSet;
        }

        /* 显示单个用户的订单信息  mode = 0; 查询所有， mode = 1, 查询已完成， mode = 2, 查询未完成*/ 
        public static DataSet showUserOrder(Customer customer, int mode)
        {
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            if(mode == 0)
            {
                mySqlCommand.CommandText = "select [OrderDB].[dbo].[Order].Order_Id 订单号, Customer_Id 顾客号, Order_Date 订货时间 from  [OrderDB].[dbo].[Order] "
                + " where [OrderDB].[dbo].[Order].Customer_Id ='" + customer.CustomerId + "'";
            }
            else if(mode == 1)
            {
                mySqlCommand.CommandText = "select [OrderDB].[dbo].[Order].Order_Id 订单号, Customer_Id 顾客号, Order_Date 订货时间 from  [OrderDB].[dbo].[Order] "
                + " where [OrderDB].[dbo].[Order].Is_Dealed = 1 and [OrderDB].[dbo].[Order].Customer_Id ='" + customer.CustomerId + "'";
            }
            else if (mode == 2)
            {
                mySqlCommand.CommandText = "select [OrderDB].[dbo].[Order].Order_Id 订单号, Customer_Id 顾客号, Order_Date 订货时间 from  [OrderDB].[dbo].[Order] "
                 + " where [OrderDB].[dbo].[Order].Is_Dealed = 0 and [OrderDB].[dbo].[Order].Customer_Id ='" + customer.CustomerId + "'";
            }
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = mySqlCommand;
            DataSet dataSet = new DataSet();
            myDataAdapter.Fill(dataSet); //用查询结果填充数据集
            return dataSet;
        }

        /* 显示所有用户的订单信息 */
        public static DataSet showAllUserOrder(int mode)
        {
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            if (mode == 0)
            {
                mySqlCommand.CommandText = "select [OrderDB].[dbo].[Order].Order_Id 订单号, Customer_Id 顾客号, Order_Date 订货时间 from  [OrderDB].[dbo].[Order] ";
            }
            else if (mode == 1)
            {
                mySqlCommand.CommandText = "select [OrderDB].[dbo].[Order].Order_Id 订单号, Customer_Id 顾客号, Order_Date 订货时间 from  [OrderDB].[dbo].[Order] where [OrderDB].[dbo].[Order].Is_Dealed = 1";
            }
            else if (mode == 2)
            {
                mySqlCommand.CommandText = "select [OrderDB].[dbo].[Order].Order_Id 订单号, Customer_Id 顾客号, Order_Date 订货时间 from  [OrderDB].[dbo].[Order] where [OrderDB].[dbo].[Order].Is_Dealed = 0";
            }
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = mySqlCommand;
            DataSet dataSet = new DataSet();
            myDataAdapter.Fill(dataSet); //用查询结果填充数据集
            return dataSet;
        }

        /* 查询库中某个商品的信息 */
        public static Goods goodsQuery(int goodsId)
        {
            Goods goods = null;
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select * from [OrderDB].[dbo].[Goods] where Goods_Id = '" + goodsId + "'";
            SqlDataReader myDataReader = mySqlCommand.ExecuteReader(); //执行查询指令并返回查询结果  
            if (myDataReader.Read())
            {
                float price = float.Parse((myDataReader["Price"]).ToString());
                string mfrs = (myDataReader["Mfrs"]).ToString();
                int actualStore = Convert.ToInt32(myDataReader["Actual_Store"]);
                int minStore = Convert.ToInt32(myDataReader["Min_Store"]);
                string goodsDesc = myDataReader["Goods_Desc"].ToString();
                goods = new Goods(goodsId, price, mfrs, actualStore, minStore, goodsDesc);
            }
            else
            {
                MessageBox.Show("查找商品信息出错!");
            }
            myDataReader.Close();
            mySqlCommand.Dispose();
            return goods;
        }

        /* 查询库中某个用户的信息 */
        public static Customer customerQuery(int customerId)
        {
            Customer customer = null;
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select * from [OrderDB].[dbo].[Customer] where Customer_Id = '" + customerId + "'";
            SqlDataReader myDataReader = mySqlCommand.ExecuteReader(); //执行查询指令并返回查询结果  
            if (myDataReader.Read())
            {
                string  customerName = myDataReader["Customer_Name"].ToString();
                string password = myDataReader["Customer_Password"].ToString();
                string address = myDataReader["Customer_Address"].ToString();
                customer = new Customer(customerId, customerName, password, address);
                customer.Balance = float.Parse(myDataReader["Customer_Balance"].ToString());
                customer.CustomerCreditLimit = float.Parse(myDataReader["Customer_Credit_Limit"].ToString());
            }
            else
            {
                MessageBox.Show("查找用户信息出错!");
            }
            myDataReader.Close();
            mySqlCommand.Dispose();
            return customer;
        }

        /* 查询库中某个订单的信息 */
        public static Order orderQuery(int orderId)
        {
            Order order = null;
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select * from [OrderDB].[dbo].[Order] where Order_Id = '" + orderId + "'";
            SqlDataReader myDataReader = mySqlCommand.ExecuteReader(); //执行查询指令并返回查询结果  
            if (myDataReader.Read())
            {
                int customerId = Convert.ToInt32(myDataReader["Customer_Id"]);
                DateTime orderTime = DateTime.Parse(myDataReader["Order_Date"].ToString());
                order = new Order(orderId, customerId, orderTime);
            }
            else
            {
                MessageBox.Show("查找订单信息出错!");
            }
            myDataReader.Close();
            mySqlCommand.Dispose();
            return order;
        }

        /* 查询库中某个订单的详细信息 */
        public static DataSet detailQuery(int orderId)
        {
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select Goods_Id 货物号, Goods_Num 订货数量, Amount 总金额 from [OrderDB].[dbo].[Detail] where Order_Id ='" + orderId + "'" ;
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = mySqlCommand;
            DataSet dataSet = new DataSet();
            myDataAdapter.Fill(dataSet); //用查询结果填充数据集
            return dataSet;
        }

        /* 查询某个订单总金额 */
        public static float amountQuery(int orderId)
        {
            int amount = 0;
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select sum(Amount) from [OrderDB].[dbo].[Detail] where Order_Id = '" + orderId + "'";
            try
            {
                amount = Convert.ToInt32(mySqlCommand.ExecuteScalar());
            }
            catch
            {
                MessageBox.Show("查找订单详情出错!");
            }
            mySqlCommand.Dispose();
            return amount;
        }

        /* 查询库中最大的订货细则号 */
        public static int queryMaxDetailId()
        {
            int maxId = 0;
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select max(Detail_Id) from [OrderDB].[dbo].[Detail]";
            try
            {
               maxId = Convert.ToInt32(mySqlCommand.ExecuteScalar());
            }
            catch
            {
                maxId = 30000;
            }
            mySqlCommand.Dispose();
            return maxId;
        }

        /* 查询库中最大的商品号 */
        public static int queryMaxGoodsId()
        {
            int maxId = 0;
            SqlCommand mySqlCommand = new SqlCommand(); // 创建SqlCommand

            /* 为SqlCommand对象绑定sqlConnection对象 */
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "select max(Goods_Id) from [OrderDB].[dbo].[Goods]";
            try
            {
                maxId = Convert.ToInt32(mySqlCommand.ExecuteScalar());
            }
            catch
            {
                maxId = 50000;
            }
            mySqlCommand.Dispose();
            return maxId;
        }

        //以下提供Dataset用法
            ///* 为SqlDataAdapter对象绑定所要执行的SqlCommand对象 */
            //SqlDataAdapter myDataAdapter = new SqlDataAdapter();   // 创建SqlDataAdapter
            //myDataAdapter.SelectCommand = mySqlCommand;
            //DataSet myDataSet = new DataSet(); // 创建DataSet
            //myDataAdapter.Fill(myDataSet, "Salesman"); // 将返回的数据集作为“表”填入DataSet中

            //DataTable myTable = myDataSet.Tables["Salesman"];
            //foreach (DataRow myRow in myTable.Rows)
            //{
            //    foreach (DataColumn myColumn in myTable.Columns)
            //    {
            //        Console.WriteLine(myRow[myColumn]);	//遍历表中的每个单元格
            //    }
            //}
    }
}
