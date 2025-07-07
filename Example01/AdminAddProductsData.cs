using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Example01
{
	internal class AdminAddProductsData
	{
		public int ID {  get; set; }
		public string ProductID { get; set; }
		public string ProductName { get; set; }
		public string Type { get; set; }
		public string Stock { get; set; }
		public string Price { get; set; }
		public string Status { get; set; }
		public string Image { get; set; }
		public string DateInsert { get; set; }
		public string DateUpdate { get; set; }


		SqlConnection connect = DB.Connect();
		public List<AdminAddProductsData> productListData()
		{
			List<AdminAddProductsData> listData = new List<AdminAddProductsData>();
			if(connect.State == ConnectionState.Closed)
			{
				try
				{
					connect.Open();
					string selectData = "select * from products where date_delete IS null";
					using (SqlCommand cmd = new SqlCommand(selectData, connect))
					{
						SqlDataReader reader = cmd.ExecuteReader();
						while(reader.Read()){
							AdminAddProductsData apd = new AdminAddProductsData();
							apd.ID = (int)reader["id"];
							apd.ProductID= reader["prod_id"].ToString(); 
							apd.ProductName= reader["prod_name"].ToString(); 
							apd.Type= reader["prod_type"].ToString(); 
							apd.Stock= reader["prod_stock"].ToString(); 
							apd.Price= reader["prod_price"].ToString(); 
							apd.Status= reader["prod_status"].ToString(); 
							apd.Image= reader["prod_image"].ToString(); 
							apd.DateInsert= reader["date_insert"].ToString(); 
							apd.DateUpdate= reader["date_update"].ToString(); 
							listData.Add(apd);
						}
					}
				}
				catch (Exception ex) {
					MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connect.Close();
				}
			}
			return listData;
		}

		public List<AdminAddProductsData> SearchProductListData(string search_name)
		{
			List<AdminAddProductsData> listData = new List<AdminAddProductsData>();
			if (connect.State == ConnectionState.Closed)
			{
				try
				{
					connect.Open();
					string selectData = "select * from products where date_delete IS null AND prod_name LIKE @sProName";
					using (SqlCommand cmd = new SqlCommand(selectData, connect))
					{
						cmd.Parameters.AddWithValue("@sProName", "%" + search_name + "%");
						SqlDataReader reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							AdminAddProductsData apd = new AdminAddProductsData();
							apd.ID = (int)reader["id"];
							apd.ProductID = reader["prod_id"].ToString();
							apd.ProductName = reader["prod_name"].ToString();
							apd.Type = reader["prod_type"].ToString();
							apd.Stock = reader["prod_stock"].ToString();
							apd.Price = reader["prod_price"].ToString();
							apd.Status = reader["prod_status"].ToString();
							apd.Image = reader["prod_image"].ToString();
							apd.DateInsert = reader["date_insert"].ToString();
							apd.DateUpdate = reader["date_update"].ToString();
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
