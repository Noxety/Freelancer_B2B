using Freelancer_client.Classes;
using Guna.UI2.WinForms;
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
    public partial class Client_RateProject : UserControl
    {
        Client client = new Client();
        DAO DAO = new DAO();
        Freelancer free= new Freelancer();
        public Client_RateProject(Client c)
        {
            client = c;
            InitializeComponent();
            LoadForm(this, null);
        }
        private void LoadForm(object sender, EventArgs e)
        {
            flow_panel1.Controls.Clear();
            int cid = client.ClientId;
            List<Project> projects = DAO.ProjectsByStatus("Completed", cid);
       
            if (projects.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = "No Projects",
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                flow_panel1.Controls.Add(lbl);
            }
            foreach (Project p in projects)
            {
                Freelancer freelancer = DAO.GetFreelancerWithBidProject(p.ProjectId);
                free.FreelancerId=freelancer.FreelancerId;

                Rating rate = DAO.GetRatingListByProjectId(p.ProjectId);
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
                    Text = "Freelancer: " + freelancer.Username,
                    AutoSize = true,
                    Location = new Point(10, 100)
                };
                Label lbl5 = new Label
                {
                    Text = "Freelancer Expertise: " + freelancer.Expertise,
                    AutoSize = true,
                    Location = new Point(10, 120)
                };
    
                if(rate.RatingValue != 0)
                {
                    Label lbl6 = new Label
                    {
                        Text = "Rating: " + rate.RatingValue,
                        AutoSize = true,
                        Location = new Point(10, 140)
                    };

                    gb.Controls.Add(lbl);
                    gb.Controls.Add(lbl1);
                    gb.Controls.Add(lbl2);
                    gb.Controls.Add(lbl3);
                    gb.Controls.Add(lbl4);
                    gb.Controls.Add(lbl5);
                    gb.Controls.Add(lbl6);
                    flow_panel1.Controls.Add(gb);
                }
                else
                {
                    Guna2RatingStar rating = new Guna2RatingStar
                    {
                        Name = "ratingStar",
                        Location = new Point(10, 140),
                        Size = new Size(180, 30),
                        Value = 0,
                    };

                    Button btn = new Button
                    {
                        Text = "Rate",
                        Location = new Point(10, 180),
                        Tag = p.ProjectId,
                    };
                    btn.Click += new EventHandler(RateProject);

                    gb.Controls.Add(lbl);
                    gb.Controls.Add(lbl1);
                    gb.Controls.Add(lbl2);
                    gb.Controls.Add(lbl3);
                    gb.Controls.Add(lbl4);
                    gb.Controls.Add(lbl5);
                    gb.Controls.Add(rating);
                    gb.Controls.Add(btn);
                    flow_panel1.Controls.Add(gb);
                }
            }
        }

        private void RateProject(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int pid = (int)btn.Tag;
            GroupBox gb = (GroupBox)btn.Parent;
            Guna2RatingStar rating = gb.Controls.OfType<Guna2RatingStar>().FirstOrDefault(c => c.Name == "ratingStar");
            if (rating != null)
            {
                float rate = rating.Value;
                if(DAO.RateProject(pid, client.ClientId, free.FreelancerId, rate) == true)
                {
                    MessageBox.Show("Gave Rating Successful");
                    LoadForm(this, null);
                }
                else
                {
                    MessageBox.Show("Rating got error is there database connection?");
                }

            }
            else
            {
                MessageBox.Show("Rating control not found.");
            }
        }
    }
}
