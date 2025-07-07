using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Example01
{
	public partial class CashierOrderForm : UserControl
	{
		public static int getCustID;
		SqlConnection connect = DB.Connect();
		public CashierOrderForm()
		{
			InitializeComponent();


			displayAvailableProds();
			displayAllOrders();

			displayTotalPrice();
		}

		public void refreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}


			displayAvailableProds();
			displayAllOrders();

			displayTotalPrice();
		}
		public void displayAvailableProds()
		{
			CashierOrderFormProdData allProds = new CashierOrderFormProdData();
			List<CashierOrderFormProdData> listData = allProds.availableProductsData();
			cashierOrderForm_menuTable.DataSource = listData;
		}


		public void displayAllOrders()
		{
			CashierOrdersData allOrders = new CashierOrdersData();
			List<CashierOrdersData> listData = allOrders.ordersListData();
			cashierOrderForm_orderTable.DataSource = listData;
		}



		



		private void cashierOrderForm_type_SelectedIndexChanged(object sender, EventArgs e)
		{
			cashierOrderForm_productID.SelectedIndex = -1;
			cashierOrderForm_productID.Items.Clear();
			cashierOrderForm_prodName.Text = "";
			cashierOrderForm_price.Text = "";

			string selectedValue = cashierOrderForm_type.SelectedItem as string;
			if (connect.State == ConnectionState.Closed)
			{
				try
				{
					connect.Open();
					if (selectedValue != null)
					{
						try
						{
							string selectedData = $"select * from products where prod_type = '{selectedValue}' AND prod_status = @status AND date_delete IS null";
							using (SqlCommand cmd = new SqlCommand(selectedData, connect))
							{
								cmd.Parameters.AddWithValue("@status", "Available");
								using (SqlDataReader reader = cmd.ExecuteReader())
								{
									while (reader.Read())
									{
										string value = reader["prod_id"].ToString();
										cashierOrderForm_productID.Items.Add(value);
									}
								}
							}
						}
						catch (Exception exx)
						{
							MessageBox.Show("Lỗi: " + exx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

					}
				}
				catch (Exception ex)
				{

					MessageBox.Show("Kết nỗi lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connect.Close();
				}
			}




		}

		private void cashierOrderForm_productID_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedValue = cashierOrderForm_productID.SelectedItem as string;
			if (selectedValue != null)
			{
				if (connect.State == ConnectionState.Closed)
				{
					try
					{
						connect.Open();
						if (selectedValue != null)
						{
							try
							{
								string selectedData = $"select * from products where prod_id = '{selectedValue}' AND prod_status = @status AND date_delete IS null";
								using (SqlCommand cmd = new SqlCommand(selectedData, connect))
								{
									cmd.Parameters.AddWithValue("@status", "Available");
									using (SqlDataReader reader = cmd.ExecuteReader())
									{
										while (reader.Read())
										{
											string prodName = reader["prod_name"].ToString();
											string proPrice = reader["prod_price"].ToString();

											cashierOrderForm_prodName.Text = prodName;
											cashierOrderForm_price.Text = proPrice;
										}
									}
								}
							}
							catch (Exception exx)
							{
								MessageBox.Show("Lỗi: " + exx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}

						}
					}
					catch (Exception ex)
					{

						MessageBox.Show("Kết nỗi lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						connect.Close();
					}
				}
			}
		}

		private float totalPrice;
		public void displayTotalPrice()
		{
			IDGennerator();
			
			if (connect.State == ConnectionState.Closed)
			{
				try
				{
					connect.Open();
					string selectData = "select SUM(prod_price) from orders where customer_id = @custID";

					using (SqlCommand cmd = new SqlCommand(selectData, connect))
					{
						cmd.Parameters.AddWithValue("@custID", idGen);
						object result = cmd.ExecuteScalar();

						
						if(result != DBNull.Value)
						{
							totalPrice = Convert.ToSingle(result);
							cashierOrderForm_orderPrice.Text = totalPrice.ToString("0.00");
						}
						else
						{
							totalPrice = 0;
							cashierOrderForm_orderPrice.Text = "0.00";
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Kết nối tính tổng lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connect.Close();
				}
			}
		}

		private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
		{

			IDGennerator();
			
			if (cashierOrderForm_type.SelectedIndex == -1 || cashierOrderForm_productID.SelectedIndex == -1
				|| cashierOrderForm_prodName.Text == "" || cashierOrderForm_quantity.Value == 0 || cashierOrderForm_price.Text == "")
			{
				MessageBox.Show("Vui lòng chọn đầy đủ thông tin sản phẩm: ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (connect.State == ConnectionState.Closed)
				{
					try
					{
						connect.Open();

						float getPrice = 0;
						string selectOrder = "select * from products where prod_id = @prodID";
						using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
						{
							getOrder.Parameters.AddWithValue("@prodID", cashierOrderForm_productID.Text.Trim());

							using (SqlDataReader reader = getOrder.ExecuteReader())
							{
								if (reader.Read())
								{
									object rawValue = reader["prod_price"];
									if (rawValue != DBNull.Value)
									{
										getPrice = Convert.ToSingle(rawValue);
									}
								}
							}
						}


						string insertOrder = "insert into orders (customer_id, prod_id,prod_name,prod_type, qty, prod_price, order_date) values " +
							"(@customerID,@prodID,@prodName,@prodType, @qty, @prodPrice, @orderDate)";
						DateTime today = DateTime.Today;
						using (SqlCommand cmd = new SqlCommand(insertOrder, connect))
						{
							cmd.Parameters.AddWithValue("@customerID", idGen);
							cmd.Parameters.AddWithValue("@prodID", cashierOrderForm_productID.Text.Trim());
							cmd.Parameters.AddWithValue("@prodName", cashierOrderForm_prodName.Text.Trim());
							cmd.Parameters.AddWithValue("@prodType", cashierOrderForm_type.Text.Trim());
							float totalPrice = (getPrice * (int)cashierOrderForm_quantity.Value);
							cmd.Parameters.AddWithValue("@qty", cashierOrderForm_quantity.Value);
							cmd.Parameters.AddWithValue("@prodPrice", totalPrice);
							cmd.Parameters.AddWithValue("@orderDate", today);

							cmd.ExecuteNonQuery();
							
							displayAllOrders();
							
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
			displayTotalPrice();
		}





		private int idGen = 0;
		public void IDGennerator()
		{
			using (SqlConnection connect = DB.Connect())
			{
				connect.Open();
				string selectID = "select MAX(customer_id) from customers";
				using (SqlCommand cmd = new SqlCommand(selectID, connect))
				{
					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						int temp = Convert.ToInt32(result);
						if (temp == 0)
						{
							idGen = 1;
						}
						else
						{
							idGen = temp + 1;
						}
					}
					else
					{
						idGen = 1;
					}
					getCustID = idGen;
				}
			}
		}

		private void cashierOrderForm_amount_TextChanged(object sender, EventArgs e)
		{
		
			
		}

		private void cashierOrderForm_amount_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				try
				{
					float getAmount = Convert.ToSingle(cashierOrderForm_amount.Text);
					float getChange = (getAmount - totalPrice);
					if (getChange <= 0)
					{
						cashierOrderForm_amount.Text = "";
						cashierOrderForm_change.Text = "";
					}
					else
					{
						cashierOrderForm_change.Text = getChange.ToString();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cashierOrderForm_amount.Text = "";
					cashierOrderForm_change.Text = "";
				}
			}
		}

		private void cashierOrderForm_payBtn_Click(object sender, EventArgs e)
		{
			if(cashierOrderForm_amount.Text == "" || cashierOrderForm_change.Text == "")
			{
				MessageBox.Show("Có gì đó không ổn: " , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if(MessageBox.Show("Bạn có chắc muốn thanh toán không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if(connect.State== ConnectionState.Closed)
					{
						try
						{
							connect.Open();

							IDGennerator();
							displayTotalPrice();

							string insertData = "insert into customers (customer_id, total_price, amount, change, date)" +
								"values (@custID, @totalPrice, @amount, @change, @date)";
							DateTime today = DateTime.Today;

							using(SqlCommand cmd = new SqlCommand(insertData, connect))
							{
								cmd.Parameters.AddWithValue("@custID", idGen);
								cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
								cmd.Parameters.AddWithValue("@amount", cashierOrderForm_amount.Text.Trim());
								cmd.Parameters.AddWithValue("@change", cashierOrderForm_change.Text.Trim());
								cmd.Parameters.AddWithValue("@date", today);

								cmd.ExecuteNonQuery();

								MessageBox.Show("Đã thanh toán", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}catch(Exception ex)
						{
							MessageBox.Show("Lỗi Thanh toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						finally
						{
							connect.Close();
						}
					}
				}
			}
			displayTotalPrice();
		}

		int rowIndex = 0;
		//receip
		private void button4_Click(object sender, EventArgs e)
		{
			printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
			printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog();
		}


		private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{
			 rowIndex = 0;
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			displayTotalPrice();

			float y = 0;
			int count = 0;
			int colWidth = 120;
			int headerMargin = 10;
			int tableMargin = 20;

			Font font = new Font("Arial", 12);
			Font bold = new Font("Arial", 12, FontStyle.Bold);
			Font headerFont = new Font("Arial", 16, FontStyle.Bold);
			Font labelFont = new Font("Arial", 14, FontStyle.Bold);

			float margin = e.MarginBounds.Top;

			StringFormat alignCenter = new StringFormat();
			alignCenter.Alignment = StringAlignment.Center;
			alignCenter.LineAlignment = StringAlignment.Center;

			string headerText = "MarcoMan's Cafe Shop";
			y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
			e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
				+ (cashierOrderForm_orderTable.Columns.Count / 2) * colWidth, y, alignCenter);

			count++;
			y += tableMargin;

			string[] header = { "CID", "ProdID", "ProdName", "ProdType", "Qty", "Price" };

			for (int i = 0; i < header.Length; i++)
			{
				y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
				e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
			}
			count++;

			float rSpace = e.MarginBounds.Bottom - y;

			while (rowIndex < cashierOrderForm_orderTable.Rows.Count)
			{
				DataGridViewRow row = cashierOrderForm_orderTable.Rows[rowIndex];

				for (int i = 0; i < cashierOrderForm_orderTable.Columns.Count; i++)
				{
					object cellValue = row.Cells[i].Value;
					string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

					y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
					e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
				}
				count++;
				rowIndex++;

				if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
				{
					e.HasMorePages = true;
					return;
				}
			}

			int labelMargin = (int)Math.Min(rSpace, 200);

			DateTime today = DateTime.Now;

			float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width;

			y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
			e.Graphics.DrawString("Total Price: \t$" + totalPrice + "\nAmount: \t$"
				+ cashierOrderForm_amount.Text + "\n\t\t------------\nChange: \t$" + cashierOrderForm_change.Text, labelFont, Brushes.Black, labelX, y);

			labelMargin = (int)Math.Min(rSpace, -40);

			string labelText = today.ToString();
			y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
			e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width, y);

		}
	}
}
