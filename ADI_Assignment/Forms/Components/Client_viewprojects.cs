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
    public partial class Client_viewprojects : UserControl
    {
        Client client = new Client();
        DAO DAO = new DAO();
        public Client_viewprojects(Client c)
        {
            InitializeComponent();
            client = c;
            Client_viewprojects_Load(this, null);
        }
        private void Client_viewprojects_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Project> projects = DAO.Project_client(client.ClientId);
            foreach (Project p in projects)
            {
                Rating rating = new Rating();
                rating = DAO.GetRatingListByProjectId(p.ProjectId);

                if(rating == null)
                {
                    rating = new Rating();
                    rating.RatingValue = 0;
                }
                GroupBox gb = new GroupBox
                {
                    Text = p.ProjectName,
                Width = 200,
                Height = 160,
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
                    Text = "Posted on: " + p.ProjectCreatedDate,
                    AutoSize = true,
                    Location = new Point(10, 100)
                };
                Label lbl5 = new Label
                {
                    Text = "Deadline: " + p.ProjectDeadline,
                    AutoSize = true,
                    Location = new Point(10, 120)
                };
                if(p.ProjectStatus == "Completed")
                {
                    Label lbl6 = new Label
                    {
                        Text = "Rating: " + rating.RatingValue,
                        AutoSize = true,
                        Location = new Point(10, 140)
                    };
                    gb.Controls.Add(lbl6);
                }
                gb.Controls.Add(lbl);
                gb.Controls.Add(lbl1);
                gb.Controls.Add(lbl2);
                gb.Controls.Add(lbl3);
                gb.Controls.Add(lbl4);
                gb.Controls.Add(lbl5);
            
                flowLayoutPanel1.Controls.Add(gb);
            }


        }
    }
}
