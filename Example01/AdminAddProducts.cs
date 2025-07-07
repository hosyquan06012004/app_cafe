using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace Example01
{
	public partial class AdminAddProducts : UserControl
	{
		string path = "";
		SqlConnection connect = DB.Connect();
		public AdminAddProducts()
		{
			InitializeComponent();
			displayData();
		}

		public void refreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}

			displayData();
		}
		public bool emptyFields()
		{
			if (adminAddProducts_id.Text == "" || adminAddProducts_name.Text == "" || adminAddProducts_type.SelectedIndex == -1 ||
				adminAddProducts_stock.Text == ""|| adminAddProducts_price.Text == "" || adminAddProducts_status.SelectedIndex == -1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void adminAddProducts_addBtn_Click(object sender, EventArgs e)
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
						string selectProdID = "Select * from  products where prod_id = @prodID";

						using (SqlCommand selectPID = new SqlCommand(selectProdID, connect))
						{
							selectPID.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
							SqlDataAdapter adapter = new SqlDataAdapter(selectPID);
							DataTable table = new DataTable();
							adapter.Fill(table);

							if (table.Rows.Count > 0)
							{
								
								MessageBox.Show("mã: " + adminAddProducts_id.Text.Trim() + " đã tồn tại", "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								
								string insertData = "insert into products (prod_id,prod_name,prod_type,prod_stock, prod_price, prod_status,prod_image,date_insert) values " +
									"(@prodID, @prodName, @prodType, @prodStock, @prodPrice, @prodStatus, @prodImage, @dateInsert)";
								DateTime today = DateTime.Today;

								path = Path.Combine(@"D:\all tài liệu Sem 3\Windows Forms C#\btl winform\BTL_Winform_CafeShope_HoSyQuanB9392\Example01\Product_Directory\"
														   + adminAddProducts_id.Text.Trim() + ".jpg");
								string directoryPath = Path.GetDirectoryName(path);
								if (!Directory.Exists(directoryPath))
								{
									Directory.CreateDirectory(directoryPath);
								}
								File.Copy(adminAddProducts_imageView.ImageLocation, path, true);

								using (SqlCommand cmd = new SqlCommand(insertData, connect))
								{
									cmd.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
									cmd.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
									cmd.Parameters.AddWithValue("@prodType", adminAddProducts_type.Text.Trim());
									int stockValue;
									if (int.TryParse(adminAddProducts_stock.Text.Trim(), out stockValue))
									{
										cmd.Parameters.AddWithValue("@prodStock", stockValue);
									}
									else
									{
										MessageBox.Show("Vui lòng nhập số hợp lệ cho sản phẩm tồn kho yêu cầu số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
									float PriceValue;
									if (float.TryParse(adminAddProducts_price.Text.Trim(), out PriceValue))
									{
										cmd.Parameters.AddWithValue("@prodPrice", stockValue);
									}
									else
									{
										MessageBox.Show("Vui lòng nhập số hợp lệ cho giá bắt buộc là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
									cmd.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.Text.Trim());
									cmd.Parameters.AddWithValue("@prodImage", path);
									cmd.Parameters.AddWithValue("@dateInsert", today);

									cmd.ExecuteNonQuery();
									clearFields();
									MessageBox.Show("Thêm mới thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
									displayData();
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

		private void adminAddProducts_importImage_Click(object sender, EventArgs e)
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
					adminAddProducts_imageView.ImageLocation = imagePath;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void clearFields()
		{
			adminAddProducts_id.Text = "";
			adminAddProducts_name.Text = "";
			adminAddProducts_type.SelectedIndex = -1;
			adminAddProducts_stock.Text = "";
			adminAddProducts_price.Text = "";
			adminAddProducts_id.Text = "";
			adminAddProducts_status.SelectedIndex = -1;
			adminAddProducts_imageView.Image = null;
		
		}

		private void adminAddProducts_clearBtn_Click(object sender, EventArgs e)
		{
			clearFields();
		}

		private void AdminAddProducts_Load(object sender, EventArgs e)
		{

		}
		public void displayData()
		{
			AdminAddProductsData proData = new AdminAddProductsData();
			List<AdminAddProductsData> listData = proData.productListData();
			dataGridView1.DataSource = listData;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1) {
				//adminAddProducts_id.ReadOnly = true;
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				adminAddProducts_id.Text = row.Cells[1].Value.ToString();
				adminAddProducts_name.Text = row.Cells[2].Value.ToString();
				adminAddProducts_type.Text = row.Cells[3].Value.ToString();
				adminAddProducts_stock.Text = row.Cells[4].Value.ToString();
				adminAddProducts_price.Text = row.Cells[5].Value.ToString();
				adminAddProducts_status.Text = row.Cells[6].Value.ToString();

				string imagePath = row.Cells[7].Value.ToString();
				try
				{
					if (imagePath != null) 
					{ 
						adminAddProducts_imageView.Image =Image.FromFile(imagePath);
					}
					else
					{
						adminAddProducts_imageView.Image = null;
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					adminAddProducts_imageView.Image = null;

				}
			}


		}

		private void adminAddProducts_updateBtn_Click(object sender, EventArgs e)
		{
			if (emptyFields())
			{
				MessageBox.Show("Tất cả các trường không được để rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DialogResult check = MessageBox.Show("Bạn có muốn update mã sản phẩm:" + adminAddProducts_id.Text.Trim() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (check == DialogResult.Yes)
				{
					if (connect.State == ConnectionState.Closed)
					{
						try
						{
							connect.Open();

							string checkEmpty = "select * from products where prod_id = @cProdID";

							using (SqlCommand cmd = new SqlCommand(checkEmpty, connect)) 
							{
								cmd.Parameters.AddWithValue("@cProdID", adminAddProducts_id.Text.Trim());
								DataTable table = new DataTable();
								SqlDataAdapter adapter = new SqlDataAdapter(cmd);
								int num = adapter.Fill(table);
								if (num > 0) {
									string updateData = "update products set prod_name=@prodName,prod_type=@prodType,prod_stock= @prodStock,prod_price=@prodPrice,prod_status=@prodStatus," +
									"date_update=@dateUpdate where prod_id = @prodID";

									DateTime today = DateTime.Today;


									using (SqlCommand updateD = new SqlCommand(updateData, connect))
									{
										updateD.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
										updateD.Parameters.AddWithValue("@prodType", adminAddProducts_type.Text.Trim());
										int stockValue;
										if (int.TryParse(adminAddProducts_stock.Text.Trim(), out stockValue))
										{
											updateD.Parameters.AddWithValue("@prodStock", stockValue);
										}
										else
										{
											MessageBox.Show("Vui lòng nhập số hợp lệ cho sản phẩm tồn kho yêu cầu số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
										}

										float PriceValue;
										if (float.TryParse(adminAddProducts_price.Text.Trim(), out PriceValue))
										{
											updateD.Parameters.AddWithValue("@prodPrice", PriceValue);
										}
										else
										{
											MessageBox.Show("Vui lòng nhập số hợp lệ cho giá bắt buộc là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
										}
										updateD.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.Text.Trim());
										updateD.Parameters.AddWithValue("@dateUpdate", today);
										updateD.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());

										updateD.ExecuteNonQuery();
										clearFields();
										MessageBox.Show("Cập nhập thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
										displayData();
									}
								}
								else
								{
									MessageBox.Show("Không thể cập nhập. mã:" + adminAddProducts_id.Text.Trim() + " không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		}

		private void adminAddProducts_deleteBtn_Click(object sender, EventArgs e)
		{
			if (emptyFields())
			{
				MessageBox.Show("Tất cả các trường không được để rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DialogResult check = MessageBox.Show("Bạn có muốn xóa mã sản phẩm:" + adminAddProducts_id.Text.Trim() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (check == DialogResult.Yes)
				{
					if (connect.State == ConnectionState.Closed)
					{
						try
						{

							connect.Open();
							string deleteData = "update products set date_delete = @dateDelete where prod_id = @prodID";
							DateTime today = DateTime.Today;

									using (SqlCommand delete = new SqlCommand(deleteData, connect))
									{
										delete.Parameters.AddWithValue("@dateDelete", today);
										delete.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());

										delete.ExecuteNonQuery();
										clearFields();
										MessageBox.Show("Xóa thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
										displayData();
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

			AdminAddProductsData proData = new AdminAddProductsData();
			List<AdminAddProductsData> listData = proData.SearchProductListData(search_name);
			dataGridView1.DataSource = listData;
		}
	}
}
