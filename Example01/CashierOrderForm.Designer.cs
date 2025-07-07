namespace Example01
{
	partial class CashierOrderForm
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrderForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.cashierOrderForm_menuTable = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cashierOrderForm_clearBtn = new System.Windows.Forms.Button();
			this.cashierOrderForm_removeBtn = new System.Windows.Forms.Button();
			this.cashierOrderForm_addBtn = new System.Windows.Forms.Button();
			this.cashierOrderForm_price = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cashierOrderForm_quantity = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.cashierOrderForm_prodName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cashierOrderForm_productID = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cashierOrderForm_type = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cashierOrderForm_recieptBtn = new System.Windows.Forms.Button();
			this.cashierOrderForm_payBtn = new System.Windows.Forms.Button();
			this.cashierOrderForm_change = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.cashierOrderForm_amount = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cashierOrderForm_orderPrice = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cashierOrderForm_orderTable = new System.Windows.Forms.DataGridView();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_menuTable)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantity)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.cashierOrderForm_menuTable);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(568, 254);
			this.panel1.TabIndex = 0;
			// 
			// cashierOrderForm_menuTable
			// 
			this.cashierOrderForm_menuTable.AllowUserToAddRows = false;
			this.cashierOrderForm_menuTable.AllowUserToDeleteRows = false;
			this.cashierOrderForm_menuTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.cashierOrderForm_menuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.cashierOrderForm_menuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cashierOrderForm_menuTable.EnableHeadersVisualStyles = false;
			this.cashierOrderForm_menuTable.Location = new System.Drawing.Point(14, 30);
			this.cashierOrderForm_menuTable.Name = "cashierOrderForm_menuTable";
			this.cashierOrderForm_menuTable.ReadOnly = true;
			this.cashierOrderForm_menuTable.RowHeadersVisible = false;
			this.cashierOrderForm_menuTable.Size = new System.Drawing.Size(538, 212);
			this.cashierOrderForm_menuTable.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "Menu";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.cashierOrderForm_clearBtn);
			this.panel2.Controls.Add(this.cashierOrderForm_removeBtn);
			this.panel2.Controls.Add(this.cashierOrderForm_addBtn);
			this.panel2.Controls.Add(this.cashierOrderForm_price);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.cashierOrderForm_quantity);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.cashierOrderForm_prodName);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.cashierOrderForm_productID);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.cashierOrderForm_type);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new System.Drawing.Point(13, 273);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(568, 254);
			this.panel2.TabIndex = 1;
			// 
			// cashierOrderForm_clearBtn
			// 
			this.cashierOrderForm_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.cashierOrderForm_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cashierOrderForm_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_clearBtn.ForeColor = System.Drawing.Color.White;
			this.cashierOrderForm_clearBtn.Location = new System.Drawing.Point(399, 196);
			this.cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
			this.cashierOrderForm_clearBtn.Size = new System.Drawing.Size(149, 39);
			this.cashierOrderForm_clearBtn.TabIndex = 30;
			this.cashierOrderForm_clearBtn.Text = "CLEAR";
			this.cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
			// 
			// cashierOrderForm_removeBtn
			// 
			this.cashierOrderForm_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.cashierOrderForm_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cashierOrderForm_removeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_removeBtn.ForeColor = System.Drawing.Color.White;
			this.cashierOrderForm_removeBtn.Location = new System.Drawing.Point(218, 196);
			this.cashierOrderForm_removeBtn.Name = "cashierOrderForm_removeBtn";
			this.cashierOrderForm_removeBtn.Size = new System.Drawing.Size(149, 39);
			this.cashierOrderForm_removeBtn.TabIndex = 29;
			this.cashierOrderForm_removeBtn.Text = "REMOVE";
			this.cashierOrderForm_removeBtn.UseVisualStyleBackColor = false;
			// 
			// cashierOrderForm_addBtn
			// 
			this.cashierOrderForm_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.cashierOrderForm_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cashierOrderForm_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_addBtn.ForeColor = System.Drawing.Color.White;
			this.cashierOrderForm_addBtn.Location = new System.Drawing.Point(31, 196);
			this.cashierOrderForm_addBtn.Name = "cashierOrderForm_addBtn";
			this.cashierOrderForm_addBtn.Size = new System.Drawing.Size(149, 39);
			this.cashierOrderForm_addBtn.TabIndex = 28;
			this.cashierOrderForm_addBtn.Text = "ADD";
			this.cashierOrderForm_addBtn.UseVisualStyleBackColor = false;
			this.cashierOrderForm_addBtn.Click += new System.EventHandler(this.cashierOrderForm_addBtn_Click);
			// 
			// cashierOrderForm_price
			// 
			this.cashierOrderForm_price.AutoSize = true;
			this.cashierOrderForm_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_price.Location = new System.Drawing.Point(118, 120);
			this.cashierOrderForm_price.Name = "cashierOrderForm_price";
			this.cashierOrderForm_price.Size = new System.Drawing.Size(0, 15);
			this.cashierOrderForm_price.TabIndex = 27;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(48, 120);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 15);
			this.label8.TabIndex = 26;
			this.label8.Text = "Price ($):";
			// 
			// cashierOrderForm_quantity
			// 
			this.cashierOrderForm_quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_quantity.Location = new System.Drawing.Point(399, 74);
			this.cashierOrderForm_quantity.Name = "cashierOrderForm_quantity";
			this.cashierOrderForm_quantity.Size = new System.Drawing.Size(153, 25);
			this.cashierOrderForm_quantity.TabIndex = 25;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(327, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 15);
			this.label5.TabIndex = 24;
			this.label5.Text = "Quantity:";
			// 
			// cashierOrderForm_prodName
			// 
			this.cashierOrderForm_prodName.AutoSize = true;
			this.cashierOrderForm_prodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_prodName.Location = new System.Drawing.Point(118, 79);
			this.cashierOrderForm_prodName.Name = "cashierOrderForm_prodName";
			this.cashierOrderForm_prodName.Size = new System.Drawing.Size(0, 15);
			this.cashierOrderForm_prodName.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 15);
			this.label3.TabIndex = 22;
			this.label3.Text = "Product Name:";
			// 
			// cashierOrderForm_productID
			// 
			this.cashierOrderForm_productID.FormattingEnabled = true;
			this.cashierOrderForm_productID.Location = new System.Drawing.Point(399, 27);
			this.cashierOrderForm_productID.Name = "cashierOrderForm_productID";
			this.cashierOrderForm_productID.Size = new System.Drawing.Size(153, 21);
			this.cashierOrderForm_productID.TabIndex = 21;
			this.cashierOrderForm_productID.SelectedIndexChanged += new System.EventHandler(this.cashierOrderForm_productID_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(313, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 15);
			this.label2.TabIndex = 20;
			this.label2.Text = "Product ID:";
			// 
			// cashierOrderForm_type
			// 
			this.cashierOrderForm_type.FormattingEnabled = true;
			this.cashierOrderForm_type.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
			this.cashierOrderForm_type.Location = new System.Drawing.Point(121, 31);
			this.cashierOrderForm_type.Name = "cashierOrderForm_type";
			this.cashierOrderForm_type.Size = new System.Drawing.Size(153, 21);
			this.cashierOrderForm_type.TabIndex = 19;
			this.cashierOrderForm_type.SelectedIndexChanged += new System.EventHandler(this.cashierOrderForm_type_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(73, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 15);
			this.label6.TabIndex = 18;
			this.label6.Text = "Type:";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.cashierOrderForm_recieptBtn);
			this.panel3.Controls.Add(this.cashierOrderForm_payBtn);
			this.panel3.Controls.Add(this.cashierOrderForm_change);
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.cashierOrderForm_amount);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.cashierOrderForm_orderPrice);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.cashierOrderForm_orderTable);
			this.panel3.Location = new System.Drawing.Point(600, 13);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(284, 514);
			this.panel3.TabIndex = 2;
			// 
			// cashierOrderForm_recieptBtn
			// 
			this.cashierOrderForm_recieptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.cashierOrderForm_recieptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cashierOrderForm_recieptBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_recieptBtn.ForeColor = System.Drawing.Color.White;
			this.cashierOrderForm_recieptBtn.Location = new System.Drawing.Point(14, 462);
			this.cashierOrderForm_recieptBtn.Name = "cashierOrderForm_recieptBtn";
			this.cashierOrderForm_recieptBtn.Size = new System.Drawing.Size(257, 39);
			this.cashierOrderForm_recieptBtn.TabIndex = 35;
			this.cashierOrderForm_recieptBtn.Text = "RECIEPT";
			this.cashierOrderForm_recieptBtn.UseVisualStyleBackColor = false;
			this.cashierOrderForm_recieptBtn.Click += new System.EventHandler(this.button4_Click);
			// 
			// cashierOrderForm_payBtn
			// 
			this.cashierOrderForm_payBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.cashierOrderForm_payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cashierOrderForm_payBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_payBtn.ForeColor = System.Drawing.Color.White;
			this.cashierOrderForm_payBtn.Location = new System.Drawing.Point(14, 417);
			this.cashierOrderForm_payBtn.Name = "cashierOrderForm_payBtn";
			this.cashierOrderForm_payBtn.Size = new System.Drawing.Size(257, 39);
			this.cashierOrderForm_payBtn.TabIndex = 34;
			this.cashierOrderForm_payBtn.Text = "PAY";
			this.cashierOrderForm_payBtn.UseVisualStyleBackColor = false;
			this.cashierOrderForm_payBtn.Click += new System.EventHandler(this.cashierOrderForm_payBtn_Click);
			// 
			// cashierOrderForm_change
			// 
			this.cashierOrderForm_change.AutoSize = true;
			this.cashierOrderForm_change.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_change.Location = new System.Drawing.Point(146, 370);
			this.cashierOrderForm_change.Name = "cashierOrderForm_change";
			this.cashierOrderForm_change.Size = new System.Drawing.Size(17, 17);
			this.cashierOrderForm_change.TabIndex = 33;
			this.cashierOrderForm_change.Text = "0";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(58, 370);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(82, 15);
			this.label13.TabIndex = 32;
			this.label13.Text = "Change ($):";
			// 
			// cashierOrderForm_amount
			// 
			this.cashierOrderForm_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_amount.Location = new System.Drawing.Point(139, 333);
			this.cashierOrderForm_amount.Name = "cashierOrderForm_amount";
			this.cashierOrderForm_amount.Size = new System.Drawing.Size(122, 21);
			this.cashierOrderForm_amount.TabIndex = 31;
			this.cashierOrderForm_amount.TextChanged += new System.EventHandler(this.cashierOrderForm_amount_TextChanged);
			this.cashierOrderForm_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrderForm_amount_KeyDown);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(51, 334);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 15);
			this.label11.TabIndex = 30;
			this.label11.Text = "Amount ($):";
			// 
			// cashierOrderForm_orderPrice
			// 
			this.cashierOrderForm_orderPrice.AutoSize = true;
			this.cashierOrderForm_orderPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashierOrderForm_orderPrice.Location = new System.Drawing.Point(216, 306);
			this.cashierOrderForm_orderPrice.Name = "cashierOrderForm_orderPrice";
			this.cashierOrderForm_orderPrice.Size = new System.Drawing.Size(15, 15);
			this.cashierOrderForm_orderPrice.TabIndex = 29;
			this.cashierOrderForm_orderPrice.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(146, 306);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 15);
			this.label10.TabIndex = 28;
			this.label10.Text = "Price ($):";
			// 
			// cashierOrderForm_orderTable
			// 
			this.cashierOrderForm_orderTable.AllowUserToAddRows = false;
			this.cashierOrderForm_orderTable.AllowUserToDeleteRows = false;
			this.cashierOrderForm_orderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.cashierOrderForm_orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.cashierOrderForm_orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cashierOrderForm_orderTable.EnableHeadersVisualStyles = false;
			this.cashierOrderForm_orderTable.Location = new System.Drawing.Point(14, 9);
			this.cashierOrderForm_orderTable.Name = "cashierOrderForm_orderTable";
			this.cashierOrderForm_orderTable.ReadOnly = true;
			this.cashierOrderForm_orderTable.RowHeadersVisible = false;
			this.cashierOrderForm_orderTable.Size = new System.Drawing.Size(257, 278);
			this.cashierOrderForm_orderTable.TabIndex = 6;
			// 
			// printDocument1
			// 
			this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// CashierOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "CashierOrderForm";
			this.Size = new System.Drawing.Size(899, 542);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_menuTable)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantity)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView cashierOrderForm_menuTable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown cashierOrderForm_quantity;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label cashierOrderForm_prodName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cashierOrderForm_productID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cashierOrderForm_type;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label cashierOrderForm_price;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button cashierOrderForm_clearBtn;
		private System.Windows.Forms.Button cashierOrderForm_removeBtn;
		private System.Windows.Forms.Button cashierOrderForm_addBtn;
		private System.Windows.Forms.Label cashierOrderForm_orderPrice;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView cashierOrderForm_orderTable;
		private System.Windows.Forms.Button cashierOrderForm_recieptBtn;
		private System.Windows.Forms.Button cashierOrderForm_payBtn;
		private System.Windows.Forms.Label cashierOrderForm_change;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox cashierOrderForm_amount;
		private System.Windows.Forms.Label label11;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
	}
}
