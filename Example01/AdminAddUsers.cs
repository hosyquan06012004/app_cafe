using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
namespace Example01
{
	public partial class AdminAddUsers : UserControl
	{
		string path = "";
		SqlConnection connect = DB.Connect();
		public AdminAddUsers()
		{
			InitializeComponent();
			displayAddUsersData();
		}

		public void refreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}

				displayAddUsersData();
		}
		public void displayAddUsersData()
		{
			AdminAddUsersData userData = new AdminAddUsersData();
			List<AdminAddUsersData> listData = userData.usersListData();
			dataGridView1.DataSource = listData;
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		public bool emptyFields()
		{
			if (adminAddUsers_username.Text == "" || adminAddUsers_password.Text == "" || adminAddUsers_role.Text == "" || adminAddUsers_status.Text == "" || adminAddUsers_imageView.Image == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
		{
			if (emptyFields())
			{
				MessageBox.Show("Tất cả các trường không được để rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (connect.State == ConnectionState.Closed)
				{
					try
					{
						connect.Open();
						string selectUsername = "Select * from  users where username = @usern";

						using (SqlCommand checkUsername = new SqlCommand(selectUsername, connect))
						{
							checkUsername.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
							SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
							DataTable table = new DataTable();
							adapter.Fill(table);

							if (table.Rows.Count > 0)
							{
								string usern = adminAddUsers_username.Text.Substring(0, 1).ToUpper() + adminAddUsers_username.Text.Substring(1);
								MessageBox.Show(usern + " đã tồn tại", "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}else
							{
								string insertData = "insert into users (username,password,profile_image,role, status, date_reg) values (@usern, @pass, @image, @role, @status, @date)";
								DateTime today = DateTime.Today;

								 path = Path.Combine(@"D:\all tài liệu Sem 3\Windows Forms C#\btl winform\BTL_Winform_CafeShope_HoSyQuanB9392\Example01\User_Directory\" 
															+ adminAddUsers_username.Text.Trim() + ".jpg");
								string directoryPath = Path.GetDirectoryName(path);
								if (!Directory.Exists(directoryPath))
								{
									Directory.CreateDirectory(directoryPath);
								}
								File.Copy(adminAddUsers_imageView.ImageLocation, path, true);
								using (SqlCommand cmd = new SqlCommand(insertData, connect))
								{
									cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
									cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
									cmd.Parameters.AddWithValue("@image", path);
									cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
									cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
									cmd.Parameters.AddWithValue("@date", today);
									cmd.ExecuteNonQuery();
									MessageBox.Show("Thêm mới thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
									displayAddUsersData();
								}
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
			}
		}

		private void import_btn_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Filter = "Image Files (*.jpg; *.png|*jpg;*.png)";
				dialog.Title = "avatar";
				string imagePath = "";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					imagePath = dialog.FileName;
					adminAddUsers_imageView.ImageLocation = imagePath;
				}
			}
			catch(Exception ex) {
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		int id = 0;
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				id = (int)row.Cells[0].Value;
				adminAddUsers_username.Text = row.Cells[1].Value.ToString();
				adminAddUsers_password.Text = row.Cells[2].Value.ToString();
				adminAddUsers_role.Text = row.Cells[3].Value.ToString();
				adminAddUsers_status.Text = row.Cells[4].Value.ToString();

				string imagePath = row.Cells[5].Value.ToString();
				if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
				{
					adminAddUsers_imageView.Image = Image.FromFile(imagePath);
				}
				else
				{
					adminAddUsers_imageView.Image = null;
					MessageBox.Show("Không tìm thấy file ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				adminAddUsers_imageView.Image = null;

			}
		}


	
		private void adminAddUsers_updateBtn_Click(object sender, EventArgs e)
		{
			if (emptyFields())
			{
				MessageBox.Show("Tất cả các trường không được để rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DialogResult result = MessageBox.Show("Bạn có muốn update tên:" + adminAddUsers_username.Text.Trim() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					if (connect.State == ConnectionState.Closed)
					{
						try
						{
							connect.Open();
							string updateData = "update users set username = @usern, password= @pass, role = @role, status = @status where id = @id";

							//string newPath = Path.Combine(@"D:\all tài liệu Sem 3\Windows Forms C#\btl winform\BTL_Winform_CafeShope_HoSyQuanB9392\Example01\User_Directory\"+ adminAddUsers_username.Text.Trim() + ".jpg");
							//if (!string.IsNullOrEmpty(path) && File.Exists(path))
							//{
							//	File.Delete(path);
							//}
							//string directoryPath = Path.GetDirectoryName(newPath);
							//if (!Directory.Exists(directoryPath))
							//{
							//	Directory.CreateDirectory(directoryPath);
							//}
							//if (!string.IsNullOrEmpty(adminAddUsers_imageView.ImageLocation) && File.Exists(adminAddUsers_imageView.ImageLocation))
							//{
							//	File.Copy(adminAddUsers_imageView.ImageLocation, newPath, true);
							//}
							

							using (SqlCommand cmd = new SqlCommand(updateData, connect))
							{
								cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
								cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
								cmd.Parameters.AddWithValue("@image", path);
								cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
								cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
								cmd.Parameters.AddWithValue("@id", id);
								cmd.ExecuteNonQuery();
								clearFields();
								MessageBox.Show("Update thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
								displayAddUsersData();
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
				}

			}
		}


		public void clearFields()
		{
			adminAddUsers_username.Text = "";
			adminAddUsers_password.Text = "";
			adminAddUsers_role.SelectedIndex = -1;
			adminAddUsers_status.SelectedIndex = -1;
			adminAddUsers_imageView.Image = null;
			
		}
		private void adminAddUsers_clearBtn_Click(object sender, EventArgs e)
		{
			clearFields();
		}

		private void adminAddUsers_deleteBtn_Click(object sender, EventArgs e)
		{
			if (emptyFields())
			{
				MessageBox.Show("Tất cả các trường không được để rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DialogResult result = MessageBox.Show("Bạn có muốn xóa tên:" + adminAddUsers_username.Text.Trim() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					if (connect.State == ConnectionState.Closed)
					{
						try
						{
							connect.Open();
							string updateData = "delete from users where id = @id";



							using (SqlCommand cmd = new SqlCommand(updateData, connect))
							{

								cmd.Parameters.AddWithValue("@id", id);
								cmd.ExecuteNonQuery();
								clearFields();
								MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
								displayAddUsersData();
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
				}
			}
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			string search_name = txt_search.Text.Trim();

			AdminAddUsersData userData = new AdminAddUsersData();
			List<AdminAddUsersData> listData = userData.searchUsersListData(search_name);
			dataGridView1.DataSource = listData;
		}

		private void AdminAddUsers_Load(object sender, EventArgs e)
		{

		}
	}
}
