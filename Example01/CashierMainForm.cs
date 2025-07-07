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
	public partial class CashierMainForm : Form
	{
		public CashierMainForm()
		{
			InitializeComponent();
		}

		private void close_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
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

		private void addProducts_btn_Click(object sender, EventArgs e)
		{
			adminDashboardForm1.Visible = false;
			adminAddProducts1.Visible = true;
			cashierOrderForm1.Visible = false;
			cashierCustomersForm1.Visible = false;


		}

		private void adminDashboardForm1_Load(object sender, EventArgs e)
		{

		}

		private void customer_btn_Click(object sender, EventArgs e)
		{
			adminDashboardForm1.Visible = false;
			adminAddProducts1.Visible = false;
			cashierOrderForm1.Visible = false;
			cashierCustomersForm1.Visible = true;
			CashierCustomersForm aaCus = cashierCustomersForm1 as CashierCustomersForm;

			if (aaCus != null)
			{
				aaCus.refreshData();
			}
		}

		private void doashboar_btn_Click(object sender, EventArgs e)
		{
			adminDashboardForm1.Visible = true;
			adminAddProducts1.Visible = false;
			cashierOrderForm1.Visible = false;
			cashierCustomersForm1.Visible = false;
			AdminDashboardForm adForm = adminDashboardForm1 as AdminDashboardForm;

			if (adForm != null)
			{
				adForm.refreshData();
			}
		}

		private void order_btn_Click(object sender, EventArgs e)
		{
			adminDashboardForm1.Visible = false;
			adminAddProducts1.Visible = false;
			cashierOrderForm1.Visible = true;
			cashierCustomersForm1.Visible = false;
		}
	}
}
