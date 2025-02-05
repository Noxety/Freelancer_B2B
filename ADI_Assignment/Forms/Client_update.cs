using Freelancer_client.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelancer_client.Forms
{
    public partial class Client_update : Form
    {
        DAO DAO = new DAO();
        Client client = new Client();
        public Client_update(Client c)
        {
            InitializeComponent();
            client = c;
            txt_c_u_name.PlaceholderText = client.CompanyName;
            txt_c_u_email.PlaceholderText = client.CompanyEmail;
            txt_c_u_phone.PlaceholderText = client.CompanyPhone;
            txt_c_u_website.PlaceholderText = client.CompanyWebsite;
            txt_c_u_address.PlaceholderText = client.CompanyAddress;
            txt_c_u_description.PlaceholderText = client.CompanyDescription;
        }
        private void btn_c_update_Click_1(object sender, EventArgs e)
        {
            Client client1 = new Client();
            client1.ClientId = client.ClientId;
            client1.CompanyName = txt_c_u_name.Text;
            client1.CompanyEmail = txt_c_u_email.Text;
            client1.CompanyPhone = txt_c_u_phone.Text;
            client1.CompanyWebsite = txt_c_u_website.Text;
            client1.CompanyAddress = txt_c_u_address.Text;
            client1.CompanyDescription = txt_c_u_description.Text;
            if (DAO.UpdateClient(client1) == true)
            {
                MessageBox.Show("Profile Updated Successfully");

                gb_update.Visible = false;
                this.Hide();
                ClientDashboard clientDashboard = new ClientDashboard(client1);
                clientDashboard.ShowDialog();
                this.Close();


                client = client1;

            }
            else
            {
                MessageBox.Show("Error in updating profile");
            }
        }
    }
}
