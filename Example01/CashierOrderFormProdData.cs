using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace Example01
{
	internal class CashierOrderFormProdData
	{
		SqlConnection connect = DB.Connect();

		public int ID { get; set; }
		public string ProductID { get; set; }
		public string ProductName { get; set; }
		public string Type { get; set; }
		public string Stock { get; set; }
		public string Price { get; set; }
		public string Status { get; set; }

		public List<CashierOrderFormProdData> availableProductsData()
		{
			List<CashierOrderFormProdData> listData = new List<CashierOrderFormProdData>();
			if (connect.State == ConnectionState.Closed)
			{
				try
				{
					connect.Open();
					string selectData = "select * from products where prod_status = @status AND date_delete IS null";

					using (SqlCommand cmd = new SqlCommand(selectData, connect))
					{
						cmd.Parameters.AddWithValue("@status", "Available");
						SqlDataReader reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							CashierOrderFormProdData apd = new CashierOrderFormProdData();
							apd.ID = (int)reader["id"];
							apd.ProductID = reader["prod_id"].ToString();
							apd.ProductName = reader["prod_name"].ToString();
							apd.Type = reader["prod_type"].ToString();
							apd.Stock = reader["prod_stock"].ToString();
							apd.Price = reader["prod_price"].ToString();
							apd.Status = reader["prod_status"].ToString();

							listData.Add(apd);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
