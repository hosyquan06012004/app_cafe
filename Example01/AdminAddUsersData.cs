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
	internal class AdminAddUsersData
	{
		SqlConnection connect = DB.Connect();
		public int ID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Role { get; set; }
		public string Status { get; set; }
		public string Image {  get; set; }
		public string DateRegistered { get; set; }
		public List<AdminAddUsersData> usersListData()
		{
			List<AdminAddUsersData> listData = new List<AdminAddUsersData>();
			if (connect.State != ConnectionState.Open)
			{
				try
				{
					connect.Open();
					string selectData = "select * from users";
					using (SqlCommand cmd = new SqlCommand(selectData, connect))
					{
						SqlDataReader reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							AdminAddUsersData usersData = new AdminAddUsersData();
							usersData.ID = (int)(reader["id"]);
							usersData.Username = (reader["username"]).ToString();
							usersData.Password = (reader["password"]).ToString();
							usersData.Role = (reader["role"]).ToString();
							usersData.Status = (reader["status"]).ToString();
							usersData.Image = (reader["profile_image"]).ToString();
							usersData.DateRegistered = (reader["date_reg"]).ToString();

							listData.Add(usersData);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi kết nối: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connect.Close();
				}
			}
			return listData;
		}

		public List<AdminAddUsersData> searchUsersListData(string search_name)
		{
			List<AdminAddUsersData> listData = new List<AdminAddUsersData>();
			if (connect.State != ConnectionState.Open)
			{
				try
				{
					connect.Open();
					string selectData = "select * from users where username like @searchName";
					using (SqlCommand cmd = new SqlCommand(selectData, connect))
					{
						cmd.Parameters.AddWithValue("@searchName", "%" + search_name + "%");

						SqlDataReader reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							AdminAddUsersData usersData = new AdminAddUsersData();
							usersData.ID = (int)(reader["id"]);
							usersData.Username = (reader["username"]).ToString();
							usersData.Password = (reader["password"]).ToString();
							usersData.Role = (reader["role"]).ToString();
							usersData.Status = (reader["status"]).ToString();
							usersData.Image = (reader["profile_image"]).ToString();
							usersData.DateRegistered = (reader["date_reg"]).ToString();

							listData.Add(usersData);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi kết nối: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
