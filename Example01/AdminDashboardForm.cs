using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Example01
{
	public partial class AdminDashboardForm : UserControl
	{
		public SqlConnection connect = DB.Connect();
		public AdminDashboardForm()
		{
			InitializeComponent();

			displayTotalCashier();
			displayTotalCustomers();
			displayTotalIncome();
			displayTodaysIncome();
		}


		public void refreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}

			displayTotalCashier();
			displayTotalCustomers();
			displayTotalIncome();
			displayTodaysIncome();
		}
		public void displayTotalCashier()
		{
			if (connect.State == ConnectionState.Closed)
			{
				try
				{
					connect.Open();

					string selectData = "SELECT COUNT(id) FROM users WHERE role = @role AND status = @status";

					using (SqlCommand cmd = new SqlCommand(selectData, connect))
					{
						cmd.Parameters.AddWithValue("@role", "Cashier");
						cmd.Parameters.AddWithValue("@status", "Active");

						SqlDataReader reader = cmd.ExecuteReader();

						if (reader.Read())
						{
							int count = Convert.ToInt32(reader[0]);
							dashboard_TC.Text = count.ToString();

						}

						reader.Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connect.Close();
				}
			}
		}

		public void displayTotalCustomers()
		{
			if (connect.State == ConnectionState.Closed)
			{
				try
				{
					connect.Open();

					string selectData = "SELECT COUNT(id) FROM customers";

					using (SqlCommand cmd = new SqlCommand(selectData, connect))
					{

						SqlDataReader reader = cmd.ExecuteReader();

						if (reader.Read())
						{
							int count = Convert.ToInt32(reader[0]);
							dashboard_TCust.Text = count.ToString();
						}

						reader.Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connect.Close();
				}
			}
		}

        public void displayTodaysIncome()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_price) FROM customers WHERE DATE = @date";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            object value = reader[0];
                            float todaysIncome = 0;

                            if (value != DBNull.Value)
                            {
                                todaysIncome = Convert.ToSingle(value);
                            }

                            dashboard_TI.Text = "$" + todaysIncome.ToString("0.00");
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        public void displayTotalIncome()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_price) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            object value = reader[0];
                            float totalIncome = 0;

                            if (value != DBNull.Value)
                            {
                                totalIncome = Convert.ToSingle(value);
                            }

                            dashboard_TIn.Text = "$" + totalIncome.ToString("0.00");
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }



        private void AdminDashboardForm_Load(object sender, EventArgs e)
		{

		}
	}
}
