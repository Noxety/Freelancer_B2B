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
    public partial class Freelancer_profile : UserControl
    {
        Freelancer freelancer = new Freelancer();
        public Freelancer_profile(Freelancer free)
        {
            InitializeComponent();
            freelancer = free;
            lbl_name.Text = lbl_name.Text + freelancer.Username;
            lbl_email.Text = lbl_email.Text + freelancer.Email;
            lbl_skills.Text = lbl_skills.Text + freelancer.Skills;
            lbl_expertise.Text = lbl_expertise.Text + freelancer.Expertise;
            lbl_porfolio.Text = lbl_porfolio.Text + freelancer.Porfolio;
            lbl_phone.Text = lbl_phone.Text + freelancer.Phone;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Freelancer_update freelancer_Update = new Freelancer_update(freelancer);
            freelancer_Update.ShowDialog();
            this.Parent.FindForm().Close();
        }
    }
}
