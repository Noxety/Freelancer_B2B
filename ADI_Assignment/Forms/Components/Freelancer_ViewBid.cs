using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Freelancer_client.Classes;

namespace Freelancer_client.Forms.Components
{
    public partial class Freelancer_ViewBid : UserControl
    {
        DAO DAO = new DAO();
        Freelancer freelancer = new Freelancer();
        public Freelancer_ViewBid(Freelancer free)
        {
            InitializeComponent();
            freelancer = free;
            Freelancer_ViewBid_Load(this,null);
        }

        private void Freelancer_ViewBid_Load(object sender, EventArgs e)
        {
            flow_panel11.Controls.Clear();
            int fid = freelancer.FreelancerId;
            List<Project> projects = DAO.Project_Freelancer(fid);

            if (projects.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = "No Projects",
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                flow_panel11.Controls.Add(lbl);
            }
            int count = 0;
            foreach (Project p in projects)
            {
                
                if (p.ProjectStatus == "Waiting")
                {
                    count++;
                    Client client = DAO.GetClientByProjectId(p.ProjectId);
                    GroupBox gb = new GroupBox
                    {
                        Text = p.ProjectName,
                        Width = 200,
                        Height = 200,
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
                        Text = "Client: " + client.CompanyName,
                        AutoSize = true,
                        Location = new Point(10, 100)
                    };

                    gb.Controls.Add(lbl);
                    gb.Controls.Add(lbl1);
                    gb.Controls.Add(lbl2);
                    gb.Controls.Add(lbl3);
                    gb.Controls.Add(lbl4);
                    flow_panel11.Controls.Add(gb);
                }

               
            }
            if(count == 0)
            {
                Label lbl = new Label
                {
                    Text = "No Bids",
                    AutoSize = true,
                    Location = new Point(10, 20)
                };
                flow_panel11.Controls.Add(lbl);
            }

        }

      
    }
}
