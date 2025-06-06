﻿using Freelancer_client.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Freelancer_client.Forms
{
    public partial class Register : Form
    {
        DAO DAO = new DAO();
      

        public Register()
        {
            InitializeComponent();
        

        }

        private void load_freelancer(object sender, EventArgs e)
        {
            gb_freelance.Visible = true;
            gb_client.Visible = false;
        }

        private void load_client(object sender, EventArgs e)
        {
            gb_freelance.Visible = false;
            gb_client.Visible = true;
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_conpass.Text == txt_c_password.Text)
            {
                Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])[A-Za-z\d@$!%*?&]{8,12}$");
                if(!regex.IsMatch(txt_c_password.Text))
                {
                    MessageBox.Show("Password must be 8-12 characters long and contain at least one uppercase letter, one lowercase letter.");
                    return;
                }
                else
                {
                    Client client = new Client();
                    client.Username = txt_c_username.Text;
                    client.Password = txt_c_password.Text;
                    client.Email = txt_c_email.Text;
                    client.Phone = txt_c_phone.Text;
                    client.CompanyName = txt_companyName.Text;
                    client.CompanyAddress = txt_companyAddress.Text;
                    client.CompanyPhone = txt_companyPhone.Text;
                    client.CompanyEmail = txt_companyEmail.Text;
                    client.CompanyWebsite = txt_companyWebsite.Text;
                    client.CompanyDescription = txt_companyDesc.Text;

                    client.PostedProjectId = 0;

                    if (DAO.InsertClient(client) == true)
                    {
                        MessageBox.Show("Client Registered Successfully");
                        this.Hide();
                        Login log = new Login();
                        log.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error in Registering Client . Is there Database Connection ? ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Confirm Password and Password doesn't match");
            }
        }

        private void btn_freelance_con_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == txt_conpass_free.Text)
            {
                Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])[A-Za-z\d@$!%*?&]{8,12}$");
                if (!regex.IsMatch(txt_password.Text))
                {
                    MessageBox.Show("Password must be 8-12 characters long and contain at least one uppercase letter, one lowercase letter.");
                    return;
                }
                else
                {
                    Freelancer freelancer = new Freelancer();
                    freelancer.Username = txt_username.Text;
                    freelancer.Password = txt_password.Text;
                    freelancer.Email = txt_email.Text;
                    freelancer.Phone = txt_phone.Text;
                    freelancer.Skills = txt_skill.Text;
                    freelancer.Expertise = txt_expertise.Text;
                    freelancer.Porfolio = txt_porfolio.Text;

                    freelancer.AppliedProjectId = 0;

                    if (DAO.InsertFreelancer(freelancer) == true)
                    {
                        MessageBox.Show("Freelancer Registered Successfully");
                        this.Hide();
                        Login log = new Login();
                        log.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error in Registering Freelancer");
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Confirm Password and Password doesn't match");

            }


        }
    }
}
