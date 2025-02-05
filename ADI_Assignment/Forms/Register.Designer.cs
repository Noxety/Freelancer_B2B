namespace Freelancer_client.Forms
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.radio_free = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radio_client = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_skill = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_expertise = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_porfolio = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_freelance_con = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.gb_client = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_companyDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_companyWebsite = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_companyEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_companyPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_companyAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_companyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_c_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_client_con = new Guna.UI2.WinForms.Guna2Button();
            this.txt_c_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_c_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_c_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gb_freelance = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gb_client.SuspendLayout();
            this.gb_freelance.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome !!!";
            // 
            // radio_free
            // 
            this.radio_free.AutoSize = true;
            this.radio_free.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_free.CheckedState.BorderThickness = 0;
            this.radio_free.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_free.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radio_free.CheckedState.InnerOffset = -4;
            this.radio_free.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_free.Location = new System.Drawing.Point(19, 58);
            this.radio_free.Name = "radio_free";
            this.radio_free.Size = new System.Drawing.Size(107, 29);
            this.radio_free.TabIndex = 8;
            this.radio_free.Text = "Freelancer";
            this.radio_free.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radio_free.UncheckedState.BorderThickness = 2;
            this.radio_free.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radio_free.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radio_free.CheckedChanged += new System.EventHandler(this.load_freelancer);
            this.radio_free.VisibleChanged += new System.EventHandler(this.load_freelancer);
            this.radio_free.Click += new System.EventHandler(this.load_freelancer);
            // 
            // radio_client
            // 
            this.radio_client.AutoSize = true;
            this.radio_client.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_client.CheckedState.BorderThickness = 0;
            this.radio_client.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_client.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radio_client.CheckedState.InnerOffset = -4;
            this.radio_client.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_client.Location = new System.Drawing.Point(132, 58);
            this.radio_client.Name = "radio_client";
            this.radio_client.Size = new System.Drawing.Size(71, 29);
            this.radio_client.TabIndex = 9;
            this.radio_client.Text = "Client";
            this.radio_client.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radio_client.UncheckedState.BorderThickness = 2;
            this.radio_client.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radio_client.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radio_client.CheckedChanged += new System.EventHandler(this.load_client);
            this.radio_client.VisibleChanged += new System.EventHandler(this.load_client);
            this.radio_client.Click += new System.EventHandler(this.load_client);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username ";
            // 
            // txt_username
            // 
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Location = new System.Drawing.Point(145, 59);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(200, 30);
            this.txt_username.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email ";
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(145, 168);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(200, 30);
            this.txt_email.TabIndex = 12;
            // 
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Location = new System.Drawing.Point(145, 112);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(200, 30);
            this.txt_password.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Skills";
            // 
            // txt_skill
            // 
            this.txt_skill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_skill.DefaultText = "";
            this.txt_skill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_skill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_skill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_skill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_skill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_skill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_skill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_skill.Location = new System.Drawing.Point(145, 280);
            this.txt_skill.Name = "txt_skill";
            this.txt_skill.PasswordChar = '\0';
            this.txt_skill.PlaceholderText = "";
            this.txt_skill.SelectedText = "";
            this.txt_skill.Size = new System.Drawing.Size(200, 67);
            this.txt_skill.TabIndex = 15;
            this.txt_skill.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(451, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Expertise";
            // 
            // txt_expertise
            // 
            this.txt_expertise.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_expertise.DefaultText = "";
            this.txt_expertise.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_expertise.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_expertise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_expertise.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_expertise.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_expertise.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_expertise.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_expertise.Location = new System.Drawing.Point(556, 59);
            this.txt_expertise.Name = "txt_expertise";
            this.txt_expertise.PasswordChar = '\0';
            this.txt_expertise.PlaceholderText = "";
            this.txt_expertise.SelectedText = "";
            this.txt_expertise.Size = new System.Drawing.Size(200, 30);
            this.txt_expertise.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(451, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Porfolio";
            // 
            // txt_porfolio
            // 
            this.txt_porfolio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_porfolio.DefaultText = "";
            this.txt_porfolio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_porfolio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_porfolio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_porfolio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_porfolio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_porfolio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_porfolio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_porfolio.Location = new System.Drawing.Point(556, 108);
            this.txt_porfolio.Name = "txt_porfolio";
            this.txt_porfolio.PasswordChar = '\0';
            this.txt_porfolio.PlaceholderText = "";
            this.txt_porfolio.SelectedText = "";
            this.txt_porfolio.Size = new System.Drawing.Size(200, 30);
            this.txt_porfolio.TabIndex = 19;
            // 
            // btn_freelance_con
            // 
            this.btn_freelance_con.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_freelance_con.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_freelance_con.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_freelance_con.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_freelance_con.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_freelance_con.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_freelance_con.ForeColor = System.Drawing.Color.White;
            this.btn_freelance_con.Location = new System.Drawing.Point(456, 159);
            this.btn_freelance_con.Name = "btn_freelance_con";
            this.btn_freelance_con.Size = new System.Drawing.Size(300, 37);
            this.btn_freelance_con.TabIndex = 20;
            this.btn_freelance_con.Text = "Confirm";
            this.btn_freelance_con.Click += new System.EventHandler(this.btn_freelance_con_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Phone Number";
            // 
            // txt_phone
            // 
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.DefaultText = "";
            this.txt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Location = new System.Drawing.Point(145, 225);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(200, 30);
            this.txt_phone.TabIndex = 23;
            // 
            // gb_client
            // 
            this.gb_client.Controls.Add(this.txt_companyDesc);
            this.gb_client.Controls.Add(this.label18);
            this.gb_client.Controls.Add(this.txt_companyWebsite);
            this.gb_client.Controls.Add(this.label17);
            this.gb_client.Controls.Add(this.txt_companyEmail);
            this.gb_client.Controls.Add(this.label16);
            this.gb_client.Controls.Add(this.txt_companyPhone);
            this.gb_client.Controls.Add(this.label12);
            this.gb_client.Controls.Add(this.txt_companyAddress);
            this.gb_client.Controls.Add(this.label11);
            this.gb_client.Controls.Add(this.txt_companyName);
            this.gb_client.Controls.Add(this.label10);
            this.gb_client.Controls.Add(this.txt_c_phone);
            this.gb_client.Controls.Add(this.label9);
            this.gb_client.Controls.Add(this.btn_client_con);
            this.gb_client.Controls.Add(this.txt_c_password);
            this.gb_client.Controls.Add(this.txt_c_email);
            this.gb_client.Controls.Add(this.label13);
            this.gb_client.Controls.Add(this.label14);
            this.gb_client.Controls.Add(this.txt_c_username);
            this.gb_client.Controls.Add(this.label15);
            this.gb_client.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_client.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gb_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gb_client.Location = new System.Drawing.Point(19, 93);
            this.gb_client.Name = "gb_client";
            this.gb_client.Size = new System.Drawing.Size(853, 356);
            this.gb_client.TabIndex = 24;
            // 
            // txt_companyDesc
            // 
            this.txt_companyDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_companyDesc.DefaultText = "";
            this.txt_companyDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_companyDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_companyDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_companyDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyDesc.Location = new System.Drawing.Point(576, 263);
            this.txt_companyDesc.Name = "txt_companyDesc";
            this.txt_companyDesc.PasswordChar = '\0';
            this.txt_companyDesc.PlaceholderText = "";
            this.txt_companyDesc.SelectedText = "";
            this.txt_companyDesc.Size = new System.Drawing.Size(248, 85);
            this.txt_companyDesc.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(407, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(159, 25);
            this.label18.TabIndex = 34;
            this.label18.Text = "Company Description";
            // 
            // txt_companyWebsite
            // 
            this.txt_companyWebsite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_companyWebsite.DefaultText = "";
            this.txt_companyWebsite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_companyWebsite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_companyWebsite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyWebsite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyWebsite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyWebsite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_companyWebsite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyWebsite.Location = new System.Drawing.Point(576, 213);
            this.txt_companyWebsite.Name = "txt_companyWebsite";
            this.txt_companyWebsite.PasswordChar = '\0';
            this.txt_companyWebsite.PlaceholderText = "";
            this.txt_companyWebsite.SelectedText = "";
            this.txt_companyWebsite.Size = new System.Drawing.Size(248, 30);
            this.txt_companyWebsite.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(407, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 25);
            this.label17.TabIndex = 32;
            this.label17.Text = "Company Website";
            // 
            // txt_companyEmail
            // 
            this.txt_companyEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_companyEmail.DefaultText = "";
            this.txt_companyEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_companyEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_companyEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_companyEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyEmail.Location = new System.Drawing.Point(576, 160);
            this.txt_companyEmail.Name = "txt_companyEmail";
            this.txt_companyEmail.PasswordChar = '\0';
            this.txt_companyEmail.PlaceholderText = "";
            this.txt_companyEmail.SelectedText = "";
            this.txt_companyEmail.Size = new System.Drawing.Size(248, 30);
            this.txt_companyEmail.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(407, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 25);
            this.label16.TabIndex = 30;
            this.label16.Text = "Company Email";
            // 
            // txt_companyPhone
            // 
            this.txt_companyPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_companyPhone.DefaultText = "";
            this.txt_companyPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_companyPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_companyPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_companyPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyPhone.Location = new System.Drawing.Point(576, 107);
            this.txt_companyPhone.Name = "txt_companyPhone";
            this.txt_companyPhone.PasswordChar = '\0';
            this.txt_companyPhone.PlaceholderText = "";
            this.txt_companyPhone.SelectedText = "";
            this.txt_companyPhone.Size = new System.Drawing.Size(248, 30);
            this.txt_companyPhone.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(407, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Company Phone";
            // 
            // txt_companyAddress
            // 
            this.txt_companyAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_companyAddress.DefaultText = "";
            this.txt_companyAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_companyAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_companyAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_companyAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyAddress.Location = new System.Drawing.Point(576, 54);
            this.txt_companyAddress.Name = "txt_companyAddress";
            this.txt_companyAddress.PasswordChar = '\0';
            this.txt_companyAddress.PlaceholderText = "";
            this.txt_companyAddress.SelectedText = "";
            this.txt_companyAddress.Size = new System.Drawing.Size(248, 30);
            this.txt_companyAddress.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(407, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Company Address";
            // 
            // txt_companyName
            // 
            this.txt_companyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_companyName.DefaultText = "";
            this.txt_companyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_companyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_companyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_companyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_companyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_companyName.Location = new System.Drawing.Point(145, 262);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.PasswordChar = '\0';
            this.txt_companyName.PlaceholderText = "";
            this.txt_companyName.SelectedText = "";
            this.txt_companyName.Size = new System.Drawing.Size(200, 30);
            this.txt_companyName.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(18, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Company Name";
            // 
            // txt_c_phone
            // 
            this.txt_c_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_c_phone.DefaultText = "";
            this.txt_c_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_c_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_c_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_c_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_c_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_c_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_c_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_c_phone.Location = new System.Drawing.Point(145, 212);
            this.txt_c_phone.Name = "txt_c_phone";
            this.txt_c_phone.PasswordChar = '\0';
            this.txt_c_phone.PlaceholderText = "";
            this.txt_c_phone.SelectedText = "";
            this.txt_c_phone.Size = new System.Drawing.Size(200, 30);
            this.txt_c_phone.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(18, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Phone Number";
            // 
            // btn_client_con
            // 
            this.btn_client_con.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_client_con.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_client_con.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_client_con.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_client_con.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_client_con.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_client_con.ForeColor = System.Drawing.Color.White;
            this.btn_client_con.Location = new System.Drawing.Point(23, 309);
            this.btn_client_con.Name = "btn_client_con";
            this.btn_client_con.Size = new System.Drawing.Size(322, 37);
            this.btn_client_con.TabIndex = 20;
            this.btn_client_con.Text = "Confirm";
            this.btn_client_con.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txt_c_password
            // 
            this.txt_c_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_c_password.DefaultText = "";
            this.txt_c_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_c_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_c_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_c_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_c_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_c_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_c_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_c_password.Location = new System.Drawing.Point(145, 106);
            this.txt_c_password.Name = "txt_c_password";
            this.txt_c_password.PasswordChar = '*';
            this.txt_c_password.PlaceholderText = "";
            this.txt_c_password.SelectedText = "";
            this.txt_c_password.Size = new System.Drawing.Size(200, 30);
            this.txt_c_password.TabIndex = 13;
            // 
            // txt_c_email
            // 
            this.txt_c_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_c_email.DefaultText = "";
            this.txt_c_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_c_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_c_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_c_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_c_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_c_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_c_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_c_email.Location = new System.Drawing.Point(145, 159);
            this.txt_c_email.Name = "txt_c_email";
            this.txt_c_email.PasswordChar = '\0';
            this.txt_c_email.PlaceholderText = "";
            this.txt_c_email.SelectedText = "";
            this.txt_c_email.Size = new System.Drawing.Size(200, 30);
            this.txt_c_email.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(18, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "Email ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(18, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "Password ";
            // 
            // txt_c_username
            // 
            this.txt_c_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_c_username.DefaultText = "";
            this.txt_c_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_c_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_c_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_c_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_c_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_c_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_c_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_c_username.Location = new System.Drawing.Point(145, 53);
            this.txt_c_username.Name = "txt_c_username";
            this.txt_c_username.PasswordChar = '\0';
            this.txt_c_username.PlaceholderText = "";
            this.txt_c_username.SelectedText = "";
            this.txt_c_username.Size = new System.Drawing.Size(200, 30);
            this.txt_c_username.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(18, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "Username ";
            // 
            // gb_freelance
            // 
            this.gb_freelance.Controls.Add(this.txt_phone);
            this.gb_freelance.Controls.Add(this.label8);
            this.gb_freelance.Controls.Add(this.btn_freelance_con);
            this.gb_freelance.Controls.Add(this.txt_porfolio);
            this.gb_freelance.Controls.Add(this.label7);
            this.gb_freelance.Controls.Add(this.txt_expertise);
            this.gb_freelance.Controls.Add(this.label6);
            this.gb_freelance.Controls.Add(this.txt_skill);
            this.gb_freelance.Controls.Add(this.label5);
            this.gb_freelance.Controls.Add(this.txt_password);
            this.gb_freelance.Controls.Add(this.txt_email);
            this.gb_freelance.Controls.Add(this.label4);
            this.gb_freelance.Controls.Add(this.label3);
            this.gb_freelance.Controls.Add(this.txt_username);
            this.gb_freelance.Controls.Add(this.label2);
            this.gb_freelance.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_freelance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gb_freelance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gb_freelance.Location = new System.Drawing.Point(19, 93);
            this.gb_freelance.Name = "gb_freelance";
            this.gb_freelance.Size = new System.Drawing.Size(853, 356);
            this.gb_freelance.TabIndex = 7;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.gb_client);
            this.Controls.Add(this.radio_client);
            this.Controls.Add(this.radio_free);
            this.Controls.Add(this.gb_freelance);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.gb_client.ResumeLayout(false);
            this.gb_client.PerformLayout();
            this.gb_freelance.ResumeLayout(false);
            this.gb_freelance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton radio_free;
        private Guna.UI2.WinForms.Guna2RadioButton radio_client;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_skill;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_expertise;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_porfolio;
        private Guna.UI2.WinForms.Guna2Button btn_freelance_con;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
        private Guna.UI2.WinForms.Guna2GroupBox gb_client;
        private Guna.UI2.WinForms.Guna2TextBox txt_c_phone;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btn_client_con;
        private Guna.UI2.WinForms.Guna2TextBox txt_c_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_c_email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txt_c_username;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2GroupBox gb_freelance;
        private Guna.UI2.WinForms.Guna2TextBox txt_companyName;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_companyEmail;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txt_companyPhone;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txt_companyAddress;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txt_companyWebsite;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txt_companyDesc;
        private System.Windows.Forms.Label label18;
    }
}