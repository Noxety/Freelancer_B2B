using Freelancer_client.Classes;
using Freelancer_client.Forms.Components;
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
    public partial class ClientDashboard : Form
    {
        DAO DAO = new DAO();
        Client client = new Client();
        public ClientDashboard(Client c)
        {
            InitializeComponent();
            client = c;
            lbl_welcome.Text = "Welcome " + client.Username;
          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var clientpanel = new Client_profile(client)
            {
                Dock = DockStyle.Fill
            };
            
            client_panel.Controls.Add(clientpanel);
            client_panel.Visible = true;
            clientpanel.BringToFront();

        }

       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            var clientpanel1 = new Client_AddProject(client)
            {
                Dock = DockStyle.Fill
            };
           
            client_panel.Controls.Add(clientpanel1);
            client_panel.Visible = true;
            clientpanel1.BringToFront();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        
            var clientpanel2 = new Client_viewprojects(client)
            {
                Dock = DockStyle.Fill
            };
           
            client_panel.Controls.Add(clientpanel2);
            client_panel.Visible = true;
            clientpanel2.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
        
            var clientpanel3 = new Client_BidProject(client)
            {
                Dock = DockStyle.Fill
            };
            client_panel.Controls.Add(clientpanel3);
            client_panel.Visible = true;
            clientpanel3.BringToFront();
        }
    }
}
