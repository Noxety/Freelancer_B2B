namespace Freelancer_client.Forms.Components
{
    partial class Client_profile
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
            this.gb_profile = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_website = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.gb_profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_profile
            // 
            this.gb_profile.BorderThickness = 2;
            this.gb_profile.Controls.Add(this.guna2Button5);
            this.gb_profile.Controls.Add(this.lbl_description);
            this.gb_profile.Controls.Add(this.lbl_website);
            this.gb_profile.Controls.Add(this.lbl_email);
            this.gb_profile.Controls.Add(this.lbl_phone);
            this.gb_profile.Controls.Add(this.lbl_address);
            this.gb_profile.Controls.Add(this.lbl_name);
            this.gb_profile.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gb_profile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gb_profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gb_profile.Location = new System.Drawing.Point(2, 2);
            this.gb_profile.Name = "gb_profile";
            this.gb_profile.Size = new System.Drawing.Size(690, 456);
            this.gb_profile.TabIndex = 2;
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderThickness = 1;
            this.guna2Button5.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.White;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.Location = new System.Drawing.Point(504, 406);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(161, 34);
            this.guna2Button5.TabIndex = 13;
            this.guna2Button5.Text = "Update Profile";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_description.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.Black;
            this.lbl_description.Location = new System.Drawing.Point(36, 288);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(96, 23);
            this.lbl_description.TabIndex = 18;
            this.lbl_description.Text = "Description - ";
            // 
            // lbl_website
            // 
            this.lbl_website.AutoSize = true;
            this.lbl_website.BackColor = System.Drawing.Color.Transparent;
            this.lbl_website.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_website.ForeColor = System.Drawing.Color.Black;
            this.lbl_website.Location = new System.Drawing.Point(39, 240);
            this.lbl_website.Name = "lbl_website";
            this.lbl_website.Size = new System.Drawing.Size(135, 23);
            this.lbl_website.TabIndex = 17;
            this.lbl_website.Text = "Company Website - ";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(39, 192);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(122, 23);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Company Email - ";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.Black;
            this.lbl_phone.Location = new System.Drawing.Point(36, 144);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(125, 23);
            this.lbl_phone.TabIndex = 15;
            this.lbl_phone.Text = "Company Phone - ";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_address.Location = new System.Drawing.Point(36, 96);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(138, 23);
            this.lbl_address.TabIndex = 14;
            this.lbl_address.Text = "Company Address - ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(36, 48);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(122, 23);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "Company Name - ";
            // 
            // Client_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_profile);
            this.Name = "Client_profile";
            this.Size = new System.Drawing.Size(690, 456);
            this.gb_profile.ResumeLayout(false);
            this.gb_profile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gb_profile;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_website;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_name;
    }
}
