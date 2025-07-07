namespace Example01
{
	partial class AdminAddProducts
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.adminAddProducts_deleteBtn = new System.Windows.Forms.Button();
			this.adminAddProducts_clearBtn = new System.Windows.Forms.Button();
			this.adminAddProducts_addBtn = new System.Windows.Forms.Button();
			this.adminAddProducts_updateBtn = new System.Windows.Forms.Button();
			this.adminAddProducts_importImage = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.adminAddProducts_imageView = new System.Windows.Forms.PictureBox();
			this.adminAddProducts_price = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.adminAddProducts_status = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.adminAddProducts_stock = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.adminAddProducts_name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.adminAddProducts_type = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.adminAddProducts_id = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_search = new System.Windows.Forms.TextBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.adminAddProducts_imageView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_search);
			this.panel1.Controls.Add(this.txt_search);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(868, 313);
			this.panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.Location = new System.Drawing.Point(12, 42);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(841, 255);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Data of Products";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.adminAddProducts_deleteBtn);
			this.panel2.Controls.Add(this.adminAddProducts_clearBtn);
			this.panel2.Controls.Add(this.adminAddProducts_addBtn);
			this.panel2.Controls.Add(this.adminAddProducts_updateBtn);
			this.panel2.Controls.Add(this.adminAddProducts_importImage);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.adminAddProducts_price);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.adminAddProducts_status);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.adminAddProducts_stock);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.adminAddProducts_name);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.adminAddProducts_type);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.adminAddProducts_id);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(12, 342);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(868, 184);
			this.panel2.TabIndex = 1;
			// 
			// adminAddProducts_deleteBtn
			// 
			this.adminAddProducts_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.adminAddProducts_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.adminAddProducts_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminAddProducts_deleteBtn.ForeColor = System.Drawing.Color.White;
			this.adminAddProducts_deleteBtn.Location = new System.Drawing.Point(360, 137);
			this.adminAddProducts_deleteBtn.Name = "adminAddProducts_deleteBtn";
			this.adminAddProducts_deleteBtn.Size = new System.Drawing.Size(102, 39);
			this.adminAddProducts_deleteBtn.TabIndex = 25;
			this.adminAddProducts_deleteBtn.Text = "DELETE";
			this.adminAddProducts_deleteBtn.UseVisualStyleBackColor = false;
			this.adminAddProducts_deleteBtn.Click += new System.EventHandler(this.adminAddProducts_deleteBtn_Click);
			// 
			// adminAddProducts_clearBtn
			// 
			this.adminAddProducts_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.adminAddProducts_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.adminAddProducts_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminAddProducts_clearBtn.ForeColor = System.Drawing.Color.White;
			this.adminAddProducts_clearBtn.Location = new System.Drawing.Point(493, 137);
			this.adminAddProducts_clearBtn.Name = "adminAddProducts_clearBtn";
			this.adminAddProducts_clearBtn.Size = new System.Drawing.Size(102, 39);
			this.adminAddProducts_clearBtn.TabIndex = 24;
			this.adminAddProducts_clearBtn.Text = "CLEAR";
			this.adminAddProducts_clearBtn.UseVisualStyleBackColor = false;
			this.adminAddProducts_clearBtn.Click += new System.EventHandler(this.adminAddProducts_clearBtn_Click);
			// 
			// adminAddProducts_addBtn
			// 
			this.adminAddProducts_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.adminAddProducts_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.adminAddProducts_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminAddProducts_addBtn.ForeColor = System.Drawing.Color.White;
			this.adminAddProducts_addBtn.Location = new System.Drawing.Point(73, 137);
			this.adminAddProducts_addBtn.Name = "adminAddProducts_addBtn";
			this.adminAddProducts_addBtn.Size = new System.Drawing.Size(102, 39);
			this.adminAddProducts_addBtn.TabIndex = 23;
			this.adminAddProducts_addBtn.Text = "ADD";
			this.adminAddProducts_addBtn.UseVisualStyleBackColor = false;
			this.adminAddProducts_addBtn.Click += new System.EventHandler(this.adminAddProducts_addBtn_Click);
			// 
			// adminAddProducts_updateBtn
			// 
			this.adminAddProducts_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.adminAddProducts_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.adminAddProducts_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminAddProducts_updateBtn.ForeColor = System.Drawing.Color.White;
			this.adminAddProducts_updateBtn.Location = new System.Drawing.Point(206, 137);
			this.adminAddProducts_updateBtn.Name = "adminAddProducts_updateBtn";
			this.adminAddProducts_updateBtn.Size = new System.Drawing.Size(102, 39);
			this.adminAddProducts_updateBtn.TabIndex = 22;
			this.adminAddProducts_updateBtn.Text = "UPDATE";
			this.adminAddProducts_updateBtn.UseVisualStyleBackColor = false;
			this.adminAddProducts_updateBtn.Click += new System.EventHandler(this.adminAddProducts_updateBtn_Click);
			// 
			// adminAddProducts_importImage
			// 
			this.adminAddProducts_importImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.adminAddProducts_importImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.adminAddProducts_importImage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminAddProducts_importImage.ForeColor = System.Drawing.Color.White;
			this.adminAddProducts_importImage.Location = new System.Drawing.Point(734, 146);
			this.adminAddProducts_importImage.Name = "adminAddProducts_importImage";
			this.adminAddProducts_importImage.Size = new System.Drawing.Size(96, 30);
			this.adminAddProducts_importImage.TabIndex = 21;
			this.adminAddProducts_importImage.Text = "Import";
			this.adminAddProducts_importImage.UseVisualStyleBackColor = false;
			this.adminAddProducts_importImage.Click += new System.EventHandler(this.adminAddProducts_importImage_Click);
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel3.Controls.Add(this.adminAddProducts_imageView);
			this.panel3.Location = new System.Drawing.Point(734, 19);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(96, 118);
			this.panel3.TabIndex = 20;
			// 
			// adminAddProducts_imageView
			// 
			this.adminAddProducts_imageView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.adminAddProducts_imageView.Location = new System.Drawing.Point(0, 0);
			this.adminAddProducts_imageView.Name = "adminAddProducts_imageView";
			this.adminAddProducts_imageView.Size = new System.Drawing.Size(96, 118);
			this.adminAddProducts_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.adminAddProducts_imageView.TabIndex = 0;
			this.adminAddProducts_imageView.TabStop = false;
			// 
			// adminAddProducts_price
			// 
			this.adminAddProducts_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminAddProducts_price.Location = new System.Drawing.Point(442, 57);
			this.adminAddProducts_price.Name = "adminAddProducts_price";
			this.adminAddProducts_price.Size = new System.Drawing.Size(153, 21);
			this.adminAddProducts_price.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(369, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 18;
			this.label4.Text = "Price ($):";
			// 
			// adminAddProducts_status
			// 
			this.adminAddProducts_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.adminAddProducts_status.FormattingEnabled = true;
			this.adminAddProducts_status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
			this.adminAddProducts_status.Location = new System.Drawing.Point(442, 96);
			this.adminAddProducts_status.Name = "adminAddProducts_status";
			this.adminAddProducts_status.Size = new System.Drawing.Size(153, 21);
			this.adminAddProducts_status.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(383, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 15);
			this.label6.TabIndex = 16;
			this.label6.Text = "Status:";
			// 
			// adminAddProducts_stock
			// 
			this.adminAddProducts_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminAddProducts_stock.Location = new System.Drawing.Point(442, 21);
			this.adminAddProducts_stock.Name = "adminAddProducts_stock";
			this.adminAddProducts_stock.Size = new System.Drawing.Size(153, 21);
			this.adminAddProducts_stock.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(392, 27);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "Stock";
			// 
			// adminAddProducts_name
			// 
			this.adminAddProducts_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminAddProducts_name.Location = new System.Drawing.Point(123, 57);
			this.adminAddProducts_name.Name = "adminAddProducts_name";
			this.adminAddProducts_name.Size = new System.Drawing.Size(153, 21);
			this.adminAddProducts_name.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Product Name:";
			// 
			// adminAddProducts_type
			// 
			this.adminAddProducts_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.adminAddProducts_type.FormattingEnabled = true;
			this.adminAddProducts_type.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
			this.adminAddProducts_type.Location = new System.Drawing.Point(123, 96);
			this.adminAddProducts_type.Name = "adminAddProducts_type";
			this.adminAddProducts_type.Size = new System.Drawing.Size(153, 21);
			this.adminAddProducts_type.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(75, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "Type:";
			// 
			// adminAddProducts_id
			// 
			this.adminAddProducts_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminAddProducts_id.Location = new System.Drawing.Point(123, 21);
			this.adminAddProducts_id.Name = "adminAddProducts_id";
			this.adminAddProducts_id.Size = new System.Drawing.Size(153, 21);
			this.adminAddProducts_id.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Product ID:";
			// 
			// txt_search
			// 
			this.txt_search.BackColor = System.Drawing.Color.White;
			this.txt_search.ForeColor = System.Drawing.Color.Black;
			this.txt_search.Location = new System.Drawing.Point(560, 10);
			this.txt_search.Multiline = true;
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(189, 19);
			this.txt_search.TabIndex = 4;
			// 
			// btn_search
			// 
			this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_search.ForeColor = System.Drawing.Color.White;
			this.btn_search.Location = new System.Drawing.Point(755, 4);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(98, 33);
			this.btn_search.TabIndex = 5;
			this.btn_search.Text = "Search Name";
			this.btn_search.UseVisualStyleBackColor = false;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// AdminAddProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "AdminAddProducts";
			this.Size = new System.Drawing.Size(899, 542);
			this.Load += new System.EventHandler(this.AdminAddProducts_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.adminAddProducts_imageView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox adminAddProducts_price;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox adminAddProducts_status;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox adminAddProducts_stock;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox adminAddProducts_name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox adminAddProducts_type;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox adminAddProducts_id;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button adminAddProducts_importImage;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox adminAddProducts_imageView;
		private System.Windows.Forms.Button adminAddProducts_deleteBtn;
		private System.Windows.Forms.Button adminAddProducts_clearBtn;
		private System.Windows.Forms.Button adminAddProducts_addBtn;
		private System.Windows.Forms.Button adminAddProducts_updateBtn;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.TextBox txt_search;
	}
}
