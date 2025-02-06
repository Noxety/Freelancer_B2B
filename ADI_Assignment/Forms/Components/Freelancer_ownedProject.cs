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
    public partial class Freelancer_ownedProject : UserControl
    {
        Freelancer freelancer = new Freelancer();
        DAO DAO = new DAO();
        public Freelancer_ownedProject(Freelancer free)
        {
            freelancer = free;
            InitializeComponent();
            Freelancer_ownedProject_Load(this, null);
        }

        private void Freelancer_ownedProject_Load(object sender, EventArgs e)
        {
            flow_panel11.Controls.Clear();
            int fid = freelancer.FreelancerId;
            List<Project> projects = DAO.Project_Freelancer(fid);

            if(projects.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = "No Projects",
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                flow_panel11.Controls.Add(lbl);
            }

            foreach (Project p in projects)
            {
               
                Client client = DAO.GetClientByProjectId(p.ProjectId);
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
                    Text = "Client: " +client.CompanyName,
                    AutoSize = true,
                    Location = new Point(10, 100)
                };
                

                Button btn = new Button
                {
                    Text = "Complete Project",
                    Location = new Point(10, 120),
                    Tag = p.ProjectId
                };
                if (p.ProjectStatus == "Completed")
                {
                    btn.Visible = false;
                };

                btn.Click += new EventHandler(ButtonClickEvent);
                gb.Controls.Add(lbl);
                gb.Controls.Add(lbl1);
                gb.Controls.Add(lbl2);
                gb.Controls.Add(lbl3);
                gb.Controls.Add(lbl4);
                gb.Controls.Add(btn);
                flow_panel11.Controls.Add(gb);
            }
        }

        private void ButtonClickEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int pid = (int)btn.Tag;
            DAO.CompleteProject(pid);
            Freelancer_ownedProject_Load(this, null);
        }
    }
}
