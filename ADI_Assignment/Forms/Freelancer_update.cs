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

namespace Freelancer_client.Forms
{
    public partial class Freelancer_update : Form
    {
        DAO DAO = new DAO();
        Freelancer freelancer = new Freelancer();
        public Freelancer_update(Freelancer f)
        {
            InitializeComponent();
            freelancer = f;
            txt_f_name.PlaceholderText = freelancer.Username;
            txt_f_email.PlaceholderText = freelancer.Email;
            txt_f_phone.PlaceholderText = freelancer.Phone;
            txt_f_skills.PlaceholderText = freelancer.Skills;
            txt_f_expertise.PlaceholderText = freelancer.Expertise;
            txt_f_porfolio.PlaceholderText = freelancer.Porfolio;


        }

        private void btn_c_update_Click(object sender, EventArgs e)
        {
            Freelancer freelancer1 = new Freelancer();
            freelancer1.FreelancerId = freelancer.FreelancerId;
            freelancer1.Id = freelancer.Id;
            freelancer1.Username = txt_f_name.Text;
            freelancer1.Email = txt_f_email.Text;
            freelancer1.Phone = txt_f_phone.Text;
            freelancer1.Skills = txt_f_skills.Text;
            freelancer1.Expertise = txt_f_expertise.Text;
            freelancer1.Porfolio = txt_f_porfolio.Text;
            if (DAO.UpdateFreelancer(freelancer1) == true)
            {
                MessageBox.Show("Profile Updated Successfully");

                this.Hide();
                FreelancerDashboard freelancerDashboard = new FreelancerDashboard(freelancer1);
                freelancerDashboard.ShowDialog();
                this.Close();
            }
        }
    }
}
