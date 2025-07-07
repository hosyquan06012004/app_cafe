namespace Example01
{
	partial class RegisterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			this.close = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.register_loginBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.register_btn = new System.Windows.Forms.Button();
			this.register_showPass = new System.Windows.Forms.CheckBox();
			this.register_cPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.register_username = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.register_password = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// close
			// 
			this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.close.AutoSize = true;
			this.close.BackColor = System.Drawing.Color.Transparent;
			this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.close.Location = new System.Drawing.Point(494, 14);
			this.close.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(18, 18);
			this.close.TabIndex = 5;
			this.close.Text = "X";
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.register_loginBtn);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(249, 350);
			this.panel1.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(56, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 118);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(8, 157);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(237, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Cafe Shop Management System";
			// 
			// register_loginBtn
			// 
			this.register_loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.register_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.register_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register_loginBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_loginBtn.ForeColor = System.Drawing.Color.White;
			this.register_loginBtn.Location = new System.Drawing.Point(12, 308);
			this.register_loginBtn.Name = "register_loginBtn";
			this.register_loginBtn.Size = new System.Drawing.Size(223, 30);
			this.register_loginBtn.TabIndex = 4;
			this.register_loginBtn.Text = "SING IN";
			this.register_loginBtn.UseVisualStyleBackColor = false;
			this.register_loginBtn.Click += new System.EventHandler(this.register_loginBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(37, 280);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Already have  an account?";
			// 
			// register_btn
			// 
			this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_btn.ForeColor = System.Drawing.Color.White;
			this.register_btn.Location = new System.Drawing.Point(283, 296);
			this.register_btn.Name = "register_btn";
			this.register_btn.Size = new System.Drawing.Size(102, 30);
			this.register_btn.TabIndex = 13;
			this.register_btn.Text = "SING UP";
			this.register_btn.UseVisualStyleBackColor = false;
			this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
			// 
			// register_showPass
			// 
			this.register_showPass.AutoSize = true;
			this.register_showPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_showPass.Location = new System.Drawing.Point(283, 263);
			this.register_showPass.Name = "register_showPass";
			this.register_showPass.Size = new System.Drawing.Size(117, 18);
			this.register_showPass.TabIndex = 12;
			this.register_showPass.Text = "ShowPassword";
			this.register_showPass.UseVisualStyleBackColor = true;
			this.register_showPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// register_cPassword
			// 
			this.register_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_cPassword.Location = new System.Drawing.Point(280, 231);
			this.register_cPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.register_cPassword.Name = "register_cPassword";
			this.register_cPassword.PasswordChar = '*';
			this.register_cPassword.Size = new System.Drawing.Size(204, 24);
			this.register_cPassword.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(276, 211);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Confirm Password:";
			// 
			// register_username
			// 
			this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_username.Location = new System.Drawing.Point(279, 109);
			this.register_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.register_username.Name = "register_username";
			this.register_username.Size = new System.Drawing.Size(204, 24);
			this.register_username.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(276, 87);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Username:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(275, 47);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 22);
			this.label5.TabIndex = 9;
			this.label5.Text = "REGISTER";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(276, 149);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 15);
			this.label7.TabIndex = 7;
			this.label7.Text = "Password:";
			// 
			// register_password
			// 
			this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_password.Location = new System.Drawing.Point(279, 171);
			this.register_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.register_password.Name = "register_password";
			this.register_password.PasswordChar = '*';
			this.register_password.Size = new System.Drawing.Size(204, 24);
			this.register_password.TabIndex = 10;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 350);
			this.Controls.Add(this.close);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.register_btn);
			this.Controls.Add(this.register_showPass);
			this.Controls.Add(this.register_password);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.register_cPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.register_username);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegisterForm";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label close;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button register_loginBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button register_btn;
		private System.Windows.Forms.CheckBox register_showPass;
		private System.Windows.Forms.TextBox register_cPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox register_username;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox register_password;
	}
}