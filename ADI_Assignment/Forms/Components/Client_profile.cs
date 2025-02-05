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

namespace Freelancer_client.Forms.Components
{
    public partial class Client_profile : UserControl
    {
        DAO DAO = new DAO();
        Client client = new Client();
        public Client_profile(Client c)
        {
            InitializeComponent();
            client = c;

            lbl_name.Text = lbl_name.Text + client.CompanyName;
            lbl_email.Text = lbl_email.Text + client.CompanyEmail;
            lbl_phone.Text = lbl_phone.Text + client.CompanyPhone;
            lbl_website.Text = lbl_website.Text + client.CompanyWebsite;
            lbl_address.Text = lbl_address.Text + client.CompanyAddress;
            lbl_description.Text = lbl_description.Text + client.CompanyDescription;
       
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client_update client_Update = new Client_update(client);
            client_Update.ShowDialog();
            this.Parent.FindForm().Close();
           
        }

       

    }
}
