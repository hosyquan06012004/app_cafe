using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
	public partial class AdminMainForm : Form
	{
		public AdminMainForm()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void close_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) { 
				Application.Exit();
			}
		}

		private void logout_btn_Click(object sender, EventArgs e)
		{
			DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (check == DialogResult.Yes)
			{
				Form1 loginForm = new Form1();
				loginForm.Show();

				this.Hide();
			}
		}

		//private void button1_Click(object sender, EventArgs e)
		//{
		//	adminDashboardForm1.Visible = true;
		//	adminAddUsers1.Visible = false;
		//	adminAddProducts1.Visible = false;

		//}

		//private void button2_Click(object sender, EventArgs e)
		//{
		//	adminDashboardForm1.Visible = false;
		//	adminAddUsers1.Visible = true;
		//	adminAddProducts1.Visible = false;
		//}

		//private void button3_Click(object sender, EventArgs e)
		//{
		//	adminDashboardForm1.Visible = false;
		//	adminAddUsers1.Visible = false;
		//	adminAddProducts1.Visible = true;
		//}

		private void button1_Click_1(object sender, EventArgs e)
		{
			adminDashboardForm1.Visible = true;
			adminAddUsers1.Visible = false;
			adminAddProducts1.Visible = false;
			cashierCustomersForm1.Visible = false;

			AdminDashboardForm adForm =  adminDashboardForm1 as AdminDashboardForm;

			if(adForm != null)
			{
				adForm.refreshData();
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			adminDashboardForm1.Visible = false;
			adminAddUsers1.Visible = true;
			adminAddProducts1.Visible = false;
			cashierCustomersForm1.Visible = false;

			AdminAddUsers aaUser = adminAddUsers1 as AdminAddUsers;

			if (aaUser != null)
			{
				aaUser.refreshData();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			adminDashboardForm1.Visible = false;
			adminAddUsers1.Visible = false;
			adminAddProducts1.Visible = true;
			cashierCustomersForm1.Visible = false;
			AdminAddProducts aaProd = adminAddProducts1 as AdminAddProducts;

			if (aaProd != null)
			{
				aaProd.refreshData();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			adminDashboardForm1.Visible = false;
			adminAddUsers1.Visible = false;
			adminAddProducts1.Visible = false;
			cashierCustomersForm1.Visible = true;

			CashierCustomersForm aaCus = cashierCustomersForm1 as CashierCustomersForm;

			if (aaCus != null)
			{
				aaCus.refreshData();
			}
		}

		private void adminDashboardForm1_Load(object sender, EventArgs e)
		{

		}
	}
}
