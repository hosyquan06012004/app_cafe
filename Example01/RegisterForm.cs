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
namespace Example01
{
	public partial class RegisterForm : Form
	{
		SqlConnection connect = DB.Connect();
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
			register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void register_loginBtn_Click(object sender, EventArgs e)
		{
			Form1 loginForm = new Form1();
			loginForm.Show();

			this.Hide();
		}
		public bool emptyFields()
		{
			if(register_username.Text == "" ||  register_password.Text == "" || register_cPassword.Text == "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void register_btn_Click(object sender, EventArgs e)
		{
			if (emptyFields())
			{
				MessageBox.Show("tất cả các trường không được để rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if(connect.State == ConnectionState.Closed)
				{
					try
					{
						connect.Open();
						string selectUsername = "Select * from  users where username = @usern";

						using (SqlCommand checkUsername = new SqlCommand(selectUsername, connect))
						{
							checkUsername.Parameters.AddWithValue("@usern", register_username.Text.Trim());
							SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
							DataTable table = new DataTable();
							adapter.Fill(table);

							if(table.Rows.Count > 0)
							{
								string usern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
								MessageBox.Show(usern + " đã tồn tại", "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error );
							}
							else if(register_password.Text != register_cPassword.Text)
							{
								MessageBox.Show("Nhập lại mật khẩu không trùng nhau", "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error);

							}
							else if(register_password.Text.Length < 8)
							{
								MessageBox.Show("Mật phải lớn hơn 8 ký tự", "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error);

							}
							else
							{
								string insertData = "insert into users (username,password,profile_image,role, status, date_reg) values (@usern, @pass, @image, @role, @status, @date)";
								DateTime today = DateTime.Today;
								using (SqlCommand cmd = new SqlCommand(insertData, connect))
								{
									cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
									cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
									cmd.Parameters.AddWithValue("@image", "");
									cmd.Parameters.AddWithValue("@role", "Cashier");
									cmd.Parameters.AddWithValue("@status", "Active");
									cmd.Parameters.AddWithValue("@date", today);
									cmd.ExecuteNonQuery();
									MessageBox.Show("Đăng ký thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
									Form1 loginForm = new Form1();
									loginForm.Show();
									this.Hide();
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Đăng ký lỗi: " + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}
					finally
					{
						connect.Close();
					}
				}
				
			}
		}

		private void RegisterForm_Load(object sender, EventArgs e)
		{

		}
	}
}
