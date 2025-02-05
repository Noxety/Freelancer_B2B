using Freelancer_client.Classes;
using Freelancer_client.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Freelancer_client
{
    public partial class Login : Form
    {
        DAO dao = new DAO();
        public Login()
        {
            InitializeComponent();
        }
        private void HoverButton_MouseEnter(object sender, EventArgs e)
        {
            Label button = sender as Label;
            if (button != null)
            {
                button.ForeColor = Color.LightBlue; // Change background color on hover
            }
        }

        private void HoverButton_MouseLeave(object sender, EventArgs e)
        {
            Label button = sender as Label;
            if (button != null)
            {
                button.ForeColor = Color.Black; // Reset background color
            }
        }
        private void btn_freelance_Click(object sender, EventArgs e)
        {
            gb_free.Size = new Size(363, 300);
            if (gb_client.Size.Height == 300)
            {
                gb_client.Size = new Size(363, 90);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gb_client.Size = new Size(363, 300);
            if (gb_free.Size.Height == 300)
            {
                gb_free.Size = new Size(363, 90);
            }
        }

        private void btn_client_login_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client = dao.FindClient(txt_c_username.Text, txt_c_password.Text);
           
            if (client != null)
            {
                this.Hide();
                ClientDashboard dashboard = new ClientDashboard(client);
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void linklbl_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
            this.Close();
        }

        private void btn_free_login_Click(object sender, EventArgs e)
        {
            Freelancer freelancer = new Freelancer();

            
            freelancer = dao.FindFreelancer(txt_free_username.Text, txt_free_password.Text);
            if (freelancer != null)
            {
                this.Hide();
                FreelancerDashboard dashboard = new FreelancerDashboard(freelancer);
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
