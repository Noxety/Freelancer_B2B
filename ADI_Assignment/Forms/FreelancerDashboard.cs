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
    public partial class FreelancerDashboard : Form
    {
        Freelancer freelancer = new Freelancer();
        public FreelancerDashboard(Freelancer free)
        {
            InitializeComponent();
            freelancer = free;
            lbl_welcome.Text = "Welcome " + freelancer.Username;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var freelancerpanel = new Freelancer_profile(freelancer)
            {
                Dock = DockStyle.Fill
            };

            freelancer_panel.Controls.Add(freelancerpanel);
            freelancer_panel.Visible = true;
            freelancerpanel.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var freelancerpanel = new Freelancer_viewprojects(freelancer)
            {
                Dock = DockStyle.Fill
            };
            freelancer_panel.Controls.Add(freelancerpanel);
            freelancer_panel.Visible = true;
            freelancerpanel.BringToFront();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            freelancer_panel.Controls.Clear();
            var freelancerpanel1 = new Freelancer_ownedProject(freelancer)
            {
                Dock = DockStyle.Fill
            };
            freelancer_panel.Controls.Add(freelancerpanel1);
            freelancer_panel.Visible = true;
            freelancerpanel1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            freelancer_panel.Controls.Clear();
            var freelancerpanel2 = new Freelancer_ViewRate(freelancer)
            {
                Dock = DockStyle.Fill
            };
            freelancer_panel.Controls.Add(freelancerpanel2);
            freelancer_panel.Visible = true;
            freelancerpanel2.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            freelancer_panel.Controls.Clear();
            var freelancerpanel3 = new Freelancer_ViewBid(freelancer)
            {
                Dock = DockStyle.Fill
            };
            freelancer_panel.Controls.Add(freelancerpanel3);
            freelancer_panel.Visible = true;
            freelancerpanel3.BringToFront();
        }
    }
}
