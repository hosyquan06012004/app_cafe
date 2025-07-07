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
	public partial class Form1 : Form
	{
		SqlConnection connect = DB.Connect();
		public Form1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void login_registerBtn_Click(object sender, EventArgs e)
		{
			RegisterForm regForm = new RegisterForm();	
			regForm.Show();

			this.Hide();
		}

		public bool emptyFields()
		{
			if(login_username.Text == "" || login_password.Text == "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void login_showPass_CheckedChanged(object sender, EventArgs e)
		{
			login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
		}

		private void login_btn_Click(object sender, EventArgs e)
		{
			if (emptyFields())
			{
				MessageBox.Show("Các trường không được để rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (connect.State == ConnectionState.Closed) 
				{
					try
					{
						connect.Open();
						string selectAccount = "select count(*) from users where username=@usern AND password=@pass AND status = @status";
						using (SqlCommand cmd = new SqlCommand(selectAccount, connect))
						{
							cmd.Parameters.AddWithValue("@usern", login_username.Text);
							cmd.Parameters.AddWithValue("@pass", login_password.Text);
							cmd.Parameters.AddWithValue("@status", "Active");

							int rowCount = (int)cmd.ExecuteScalar();
							if (rowCount > 0)
							{
								string selectRole = "select role from users where username=@usern AND password=@pass";
								using (SqlCommand getRole = new SqlCommand(selectRole,connect)) 
								{
									getRole.Parameters.AddWithValue("@usern", login_username.Text);
									getRole.Parameters.AddWithValue("@pass", login_password.Text);

									string userRole = getRole.ExecuteScalar() as string;

									MessageBox.Show("Đăng nhập thành công", "Thông tin đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
									if (userRole == "Admin")
									{
										AdminMainForm adminForm = new AdminMainForm();
										adminForm.Show();

										this.Hide();
									}
									else if (userRole == "Cashier")
									{
										CashierMainForm cashierForm = new CashierMainForm();
										cashierForm.Show();

										this.Hide();
									}
								}
							}
							else
							{
								MessageBox.Show("Đăng nhập thất bại kiểm tra tên đăng nhập hoặc password hoặc không có quản trị viên nào phê duyệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}



						}

					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi kết nối: "+ ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error );
					}
					finally
					{
						connect.Close();
					}
				}	
			}
		}
	}
}
