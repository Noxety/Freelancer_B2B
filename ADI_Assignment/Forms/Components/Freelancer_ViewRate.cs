using Freelancer_client.Classes;
using MySqlX.XDevAPI;
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
    public partial class Freelancer_ViewRate : UserControl
    {
        Freelancer freelancer = new Freelancer();
        DAO dao = new DAO();
        Classes.Client client = new Classes.Client();
        Rating rating = new Rating();

        public Freelancer_ViewRate(Freelancer f)
        {
            freelancer = f;
            InitializeComponent();
            LoadForm(this, null);
        }

        private void LoadForm(object sender, EventArgs e)
        {
           List<Project> projects = new List<Project>();
            projects = dao.Project_Freelancer(freelancer.FreelancerId);
            foreach (Project project in projects)
                foreach (Project p in projects)
                {
                    client = dao.GetClientByProjectId(p.ProjectId);
                    rating = dao.GetRatingListByProjectId(p.ProjectId);
                 
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
                    Label lbl7 = new Label
                    {
                        Text = "Rating: " + rating.RatingValue + " / 5",
                        AutoSize = true,
                        Location = new Point(10, 160)
                    };
                    gb.Controls.Add(lbl);
                    gb.Controls.Add(lbl1);
                    gb.Controls.Add(lbl2);
                    gb.Controls.Add(lbl3);
                    gb.Controls.Add(lbl4);
                    gb.Controls.Add(lbl5);
                    gb.Controls.Add(lbl6);
                    gb.Controls.Add(lbl7);
                    flow_panel1.Controls.Add(gb);
                }

        }
    }
}
