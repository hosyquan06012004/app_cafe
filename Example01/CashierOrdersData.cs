using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Example01
{
	internal class CashierOrdersData
	{
		SqlConnection connect = DB.Connect();
		public int CID { get; set; }
		public string ProdID { get; set; }
		public string ProdName { get; set; }
		public string ProdType { get; set; }
		public int Qty { get; set; }
		public string Price { get; set; }

		public List<CashierOrdersData> ordersListData()
		{
			List<CashierOrdersData> listData = new List<CashierOrdersData>();

			if (connect.State == ConnectionState.Closed)
			{
				try
				{
					connect.Open();

					int custID = 0;	
					string selectCusData = "SELECT MAX(customer_id) from orders";
					using (SqlCommand getCustData = new SqlCommand(selectCusData,connect)) 
					{
						object result = getCustData.ExecuteScalar();
						if (result != DBNull.Value)
						{
							int temp = Convert.ToInt32(result);
							if (temp == 0)
							{
								custID = 1;
							}
							else
							{
								custID = temp;
							}
						}
						else
						{
                            Console.WriteLine("lỗi id");
                        }
					}

					string selectOrders = "select * from orders where customer_id = @customerID";
					using (SqlCommand cmd = new SqlCommand(selectOrders, connect))
					{
						cmd.Parameters.AddWithValue("@customerID", custID);
						SqlDataReader reader = cmd.ExecuteReader();
						while(reader.Read())
						{
							CashierOrdersData coData = new CashierOrdersData();
							coData.CID = (int)reader["customer_id"];
							coData.ProdID = reader["prod_id"].ToString();
							coData.ProdName = reader["prod_name"].ToString();
							coData.ProdType = reader["prod_type"].ToString();
							coData.Qty = (int)reader["qty"];
							coData.Price = reader["prod_price"].ToString();

							listData.Add(coData);
						}
					}
				}
				catch (Exception ex)
				{
                    Console.WriteLine("Kết nối lỗi: " +ex);

                }
				finally
				{
					connect.Close();
				}
			}

			return listData;
		}
	}
}
