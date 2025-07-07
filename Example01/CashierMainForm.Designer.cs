namespace Example01
{
	partial class CashierMainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.adminDashboardForm1 = new Example01.AdminDashboardForm();
			this.adminAddProducts1 = new Example01.AdminAddProducts();
			this.cashierOrderForm1 = new Example01.CashierOrderForm();
			this.cashierCustomersForm1 = new Example01.CashierCustomersForm();
			this.panel2 = new System.Windows.Forms.Panel();
			this.order_btn = new System.Windows.Forms.Button();
			this.logout_btn = new System.Windows.Forms.Button();
			this.customer_btn = new System.Windows.Forms.Button();
			this.addProducts_btn = new System.Windows.Forms.Button();
			this.doashboar_btn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.close = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1102, 574);
			this.panel1.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.adminDashboardForm1);
			this.panel4.Controls.Add(this.adminAddProducts1);
			this.panel4.Controls.Add(this.cashierOrderForm1);
			this.panel4.Controls.Add(this.cashierCustomersForm1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(203, 32);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(899, 542);
			this.panel4.TabIndex = 4;
			// 
			// adminDashboardForm1
			// 
			this.adminDashboardForm1.Location = new System.Drawing.Point(0, 0);
			this.adminDashboardForm1.Name = "adminDashboardForm1";
			this.adminDashboardForm1.Size = new System.Drawing.Size(899, 542);
			this.adminDashboardForm1.TabIndex = 0;
			// 
			// adminAddProducts1
			// 
			this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
			this.adminAddProducts1.Name = "adminAddProducts1";
			this.adminAddProducts1.Size = new System.Drawing.Size(899, 542);
			this.adminAddProducts1.TabIndex = 2;
			// 
			// cashierOrderForm1
			// 
			this.cashierOrderForm1.Location = new System.Drawing.Point(0, 0);
			this.cashierOrderForm1.Name = "cashierOrderForm1";
			this.cashierOrderForm1.Size = new System.Drawing.Size(899, 542);
			this.cashierOrderForm1.TabIndex = 1;
			// 
			// cashierCustomersForm1
			// 
			this.cashierCustomersForm1.Location = new System.Drawing.Point(0, 0);
			this.cashierCustomersForm1.Name = "cashierCustomersForm1";
			this.cashierCustomersForm1.Size = new System.Drawing.Size(899, 542);
			this.cashierCustomersForm1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.panel2.Controls.Add(this.order_btn);
			this.panel2.Controls.Add(this.logout_btn);
			this.panel2.Controls.Add(this.customer_btn);
			this.panel2.Controls.Add(this.addProducts_btn);
			this.panel2.Controls.Add(this.doashboar_btn);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.username);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.ForeColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(0, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(203, 542);
			this.panel2.TabIndex = 3;
			// 
			// order_btn
			// 
			this.order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.order_btn.Location = new System.Drawing.Point(15, 317);
			this.order_btn.Name = "order_btn";
			this.order_btn.Size = new System.Drawing.Size(171, 31);
			this.order_btn.TabIndex = 14;
			this.order_btn.Text = "Order";
			this.order_btn.UseVisualStyleBackColor = true;
			this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
			// 
			// logout_btn
			// 
			this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logout_btn.Location = new System.Drawing.Point(15, 500);
			this.logout_btn.Name = "logout_btn";
			this.logout_btn.Size = new System.Drawing.Size(171, 31);
			this.logout_btn.TabIndex = 13;
			this.logout_btn.Text = "Logout";
			this.logout_btn.UseVisualStyleBackColor = true;
			this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
			// 
			// customer_btn
			// 
			this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customer_btn.Location = new System.Drawing.Point(15, 366);
			this.customer_btn.Name = "customer_btn";
			this.customer_btn.Size = new System.Drawing.Size(171, 31);
			this.customer_btn.TabIndex = 12;
			this.customer_btn.Text = "Customers";
			this.customer_btn.UseVisualStyleBackColor = true;
			this.customer_btn.Click += new System.EventHandler(this.customer_btn_Click);
			// 
			// addProducts_btn
			// 
			this.addProducts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addProducts_btn.Location = new System.Drawing.Point(15, 270);
			this.addProducts_btn.Name = "addProducts_btn";
			this.addProducts_btn.Size = new System.Drawing.Size(171, 31);
			this.addProducts_btn.TabIndex = 11;
			this.addProducts_btn.Text = "Add Products";
			this.addProducts_btn.UseVisualStyleBackColor = true;
			this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
			// 
			// doashboar_btn
			// 
			this.doashboar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.doashboar_btn.Location = new System.Drawing.Point(15, 222);
			this.doashboar_btn.Name = "doashboar_btn";
			this.doashboar_btn.Size = new System.Drawing.Size(171, 31);
			this.doashboar_btn.TabIndex = 9;
			this.doashboar_btn.Text = "Dashboard";
			this.doashboar_btn.UseVisualStyleBackColor = true;
			this.doashboar_btn.Click += new System.EventHandler(this.doashboar_btn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "username:";
			// 
			// username
			// 
			this.username.AutoSize = true;
			this.username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.ForeColor = System.Drawing.Color.White;
			this.username.Location = new System.Drawing.Point(94, 185);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(52, 14);
			this.username.TabIndex = 8;
			this.username.Text = "Cashier";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(44, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Cashier\'s Portal";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(47, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(111, 115);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.close);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1102, 32);
			this.panel3.TabIndex = 1;
			// 
			// close
			// 
			this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.close.AutoSize = true;
			this.close.BackColor = System.Drawing.Color.Transparent;
			this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.close.Location = new System.Drawing.Point(1070, 9);
			this.close.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(18, 18);
			this.close.TabIndex = 6;
			this.close.Text = "X";
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cafe Shop Management System";
			// 
			// CashierMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1102, 574);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CashierMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CarshierMainForm";
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label close;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button order_btn;
		private System.Windows.Forms.Button logout_btn;
		private System.Windows.Forms.Button customer_btn;
		private System.Windows.Forms.Button addProducts_btn;
		private System.Windows.Forms.Button doashboar_btn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label username;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel4;
		private AdminAddProducts adminAddProducts1;
		private CashierOrderForm cashierOrderForm1;
		private CashierCustomersForm cashierCustomersForm1;
		private AdminDashboardForm adminDashboardForm1;
	}
}