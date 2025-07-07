namespace Example01
{
	partial class AdminMainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.close = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.logout_btn = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.adminDashboardForm1 = new Example01.AdminDashboardForm();
			this.cashierCustomersForm1 = new Example01.CashierCustomersForm();
			this.adminAddProducts1 = new Example01.AdminAddProducts();
			this.adminAddUsers1 = new Example01.AdminAddUsers();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.close);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1102, 32);
			this.panel1.TabIndex = 0;
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
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cafe Shop Management System";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.panel2.Controls.Add(this.logout_btn);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.ForeColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(0, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(203, 542);
			this.panel2.TabIndex = 1;
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
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(15, 360);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(171, 31);
			this.button4.TabIndex = 12;
			this.button4.Text = "Customers";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(15, 314);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(171, 31);
			this.button3.TabIndex = 11;
			this.button3.Text = "Add Products";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(15, 268);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(171, 31);
			this.button2.TabIndex = 10;
			this.button2.Text = "Add Cashier";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(15, 222);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(171, 31);
			this.button1.TabIndex = 9;
			this.button1.Text = "Dashboard";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
			this.label4.Click += new System.EventHandler(this.label3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(94, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 14);
			this.label3.TabIndex = 8;
			this.label3.Text = "Admin";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(44, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Admin\'s Portal";
			this.label2.Click += new System.EventHandler(this.label2_Click);
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
			this.panel3.Controls.Add(this.adminDashboardForm1);
			this.panel3.Controls.Add(this.cashierCustomersForm1);
			this.panel3.Controls.Add(this.adminAddProducts1);
			this.panel3.Controls.Add(this.adminAddUsers1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(203, 32);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(899, 542);
			this.panel3.TabIndex = 2;
			// 
			// adminDashboardForm1
			// 
			this.adminDashboardForm1.Location = new System.Drawing.Point(-3, 0);
			this.adminDashboardForm1.Name = "adminDashboardForm1";
			this.adminDashboardForm1.Size = new System.Drawing.Size(899, 542);
			this.adminDashboardForm1.TabIndex = 3;
			this.adminDashboardForm1.Load += new System.EventHandler(this.adminDashboardForm1_Load);
			// 
			// cashierCustomersForm1
			// 
			this.cashierCustomersForm1.Location = new System.Drawing.Point(0, 0);
			this.cashierCustomersForm1.Name = "cashierCustomersForm1";
			this.cashierCustomersForm1.Size = new System.Drawing.Size(899, 542);
			this.cashierCustomersForm1.TabIndex = 2;
			// 
			// adminAddProducts1
			// 
			this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
			this.adminAddProducts1.Name = "adminAddProducts1";
			this.adminAddProducts1.Size = new System.Drawing.Size(899, 542);
			this.adminAddProducts1.TabIndex = 1;
			// 
			// adminAddUsers1
			// 
			this.adminAddUsers1.Location = new System.Drawing.Point(6, -2);
			this.adminAddUsers1.Name = "adminAddUsers1";
			this.adminAddUsers1.Size = new System.Drawing.Size(899, 542);
			this.adminAddUsers1.TabIndex = 0;
			// 
			// AdminMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1102, 574);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "adminForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button logout_btn;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel3;
		private AdminAddUsers adminAddUsers1;
		private System.Windows.Forms.Label close;
		private AdminAddProducts adminAddProducts1;
		private CashierCustomersForm cashierCustomersForm1;
		private AdminDashboardForm adminDashboardForm1;
	}
}