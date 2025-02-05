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
    public partial class Freelancer_viewprojects : UserControl
    {
        DAO DAO = new DAO();
        Freelancer freelancer = new Freelancer();
        Client client = new Client();
        public Freelancer_viewprojects(Freelancer free)
        {
            InitializeComponent();
            freelancer = free;
        }

        private void Freelancer_viewprojects_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Project> projects = DAO.ProjectsByExpertise(freelancer.Expertise);
            
            foreach (Project p in projects)
            {
                client = DAO.GetClientByProjectId(p.ProjectId);
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
                Label lbl5 = new Label
                {
                    Text = "Client Email: " + client.CompanyEmail,
                    AutoSize = true,
                    Location = new Point(10, 120)
                };
                Label lbl6 = new Label
                {
                    Text = "Client Phone: " + client.CompanyPhone,
                    AutoSize = true,
                    Location = new Point(10, 140)
                };
                Button btn = new Button
                {
                    Text = "Apply",
                    Location = new Point(10, 160),
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
                gb.Controls.Add(btn);
                flowLayoutPanel1.Controls.Add(gb);
            }


        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int projectId = (int)btn.Tag;
            MessageBox.Show(projectId.ToString());
            if (DAO.ApplyProject(projectId,freelancer.FreelancerId)==true)
            {
                MessageBox.Show("Applied Successfully");
            }
            else
            {
                MessageBox.Show("Already Applied");
            }
        }
    }
}
