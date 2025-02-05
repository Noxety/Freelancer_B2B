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
    public partial class Client_AddProject : UserControl
    {
        Client client = new Client();
        DAO DAO = new DAO();
        public Client_AddProject(Client c)
        {
            InitializeComponent();
            client = c;
           
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            project.ProjectName = txt_name.Text;
            project.ProjectDescription = txt_description.Text;
            project.ProjectSkills = txt_skill.Text;
            project.ProjectBudget = Convert.ToDouble(txt_budget.Text);
            project.ProjectDuration = txt_duration.Text;
            project.ProjectStatus = "Pending";
            project.ProjectDeadline = txt_deadline.Text;
            project.ProjectCreatedDate = DateTime.Now;
            project.ProjectCompletedDate = DateTime.Now;
            int id = client.ClientId;

            if (DAO.CreateProject(project,id) == true)
            {
                MessageBox.Show("Project Posted Successfully");
            }
            else
            {
                MessageBox.Show("Error in posting project");
            }
        }
    }
}
