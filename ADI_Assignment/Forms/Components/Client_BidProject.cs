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
    public partial class Client_BidProject : UserControl
    {
        Client client = new Client();
        DAO DAO = new DAO();
        public Client_BidProject(Client c)
        {
            client = c;
            InitializeComponent();
            Client_BidViewLoad(this, null);

        }

        private void Client_BidViewLoad(object sender, EventArgs e)
        {
            flow_panel.Controls.Clear();
            int cid = client.ClientId;


            List<Project> projects = DAO.ProjectsByStatus("Waiting", cid);
            Freelancer freelancer = new Freelancer();

            foreach (Project p in projects)
            {
                freelancer = DAO.GetFreelancerWithBidProject(p.ProjectId);
                GroupBox gb = new GroupBox
                {
                    Text = p.ProjectName,
                    Width = 200,
                    Height = 290,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                };
                Label lbl = new Label
                {
                    Text = "Description: " + p.ProjectDescription,
                    AutoSize = true,
                    Location = new Point(10, 20)
                };
                Label lbl1 = new Label
                {
                    Text = "Budget: " + p.ProjectBudget,
                    AutoSize = true,
                    Location = new Point(10, 40)
                };
                Label lbl2 = new Label
                {
                    Text = "Skills: " + p.ProjectSkills,
                    AutoSize = true,
                    Location = new Point(10, 60)
                };
                Label lbl3 = new Label
                {
                    Text = "Status: " + p.ProjectStatus,
                    AutoSize = true,
                    Location = new Point(10, 80)
                };
                Label lbl4 = new Label
                {
                    Text = "Duration: " + p.ProjectDuration,
                    AutoSize = true,
                    Location = new Point(10, 100)
                };
                Label lbl5 = new Label
                {
                    Text = "Deadline: " + p.ProjectDeadline,
                    AutoSize = true,
                    Location = new Point(10, 120)
                };
                Label lbl6 = new Label
                {
                    Text = "Created Date: " + p.ProjectCreatedDate,
                    AutoSize = true,
                    Location = new Point(10, 140)
                };
                Label lbl7 = new Label
                {
                    Text = "Completed Date: " + p.ProjectCompletedDate,
                    AutoSize = true,
                    Location = new Point(10, 160)
                };
                Label lbl8 = new Label
                {
                    Text = "Freelancer: " + freelancer.Username,
                    AutoSize = true,
                    Location = new Point(10, 180)
                };
                Label lbl9 = new Label
                {
                    Text = "Freelancer Email: " + freelancer.Email,
                    AutoSize = true,
                    Location = new Point(10, 200)
                };
                Label lbl10 = new Label
                {
                    Text = "Freelancer Phone: " + freelancer.Phone,
                    AutoSize = true,
                    Location = new Point(10, 220)
                };
                Label lbl11 = new Label
                {
                    Text = "Freelancer Porfolio: " + freelancer.Porfolio,
                    AutoSize = true,
                    Location = new Point(10, 240)
                };
                Button btn = new Button
                {
                    Text = "Accept",
                    Location = new Point(10, 260),
                    Tag = p.ProjectId
                };

                btn.Click += new EventHandler(ButtonClicked);
                gb.Controls.Add(lbl);
                gb.Controls.Add(lbl1);
                gb.Controls.Add(lbl2);
                gb.Controls.Add(lbl3);
                gb.Controls.Add(lbl4);
                gb.Controls.Add(lbl5);
                gb.Controls.Add(lbl6);
                gb.Controls.Add(lbl7);
                gb.Controls.Add(lbl8);
                gb.Controls.Add(lbl9);
                gb.Controls.Add(lbl10);
                gb.Controls.Add(lbl11);
                gb.Controls.Add(btn);
                flow_panel.Controls.Add(gb);
            }

            if (projects.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = "No Projects Available",
                    AutoSize = true,
                    Location = new Point(10, 20)
                };
                flow_panel.Controls.Add(lbl);
            }
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int pid = Convert.ToInt32(button.Tag);
            if (DAO.AcceptedProject(pid, client.ClientId) == true)
            {
                MessageBox.Show("Bid Accepted");
                Client_BidViewLoad(this, null);
            }
            else
            {
                MessageBox.Show("Error in accepting bid");
            }
        }
    }
}
