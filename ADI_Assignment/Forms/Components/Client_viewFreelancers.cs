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
    public partial class Client_viewFreelancers : UserControl
    {
        Client client = new Client();
        DAO DAO = new DAO();
        public Client_viewFreelancers(Client c)
        {
            client = c;
            InitializeComponent();
            Client_viewFreelancers_Load(this, null);
        }

        private void Client_viewFreelancers_Load(object sender, EventArgs e)
        {
            flow_panel1.Controls.Clear();
            int cid = client.ClientId;
            List<Freelancer> freelancers = DAO.GetAllFreelancer();
            if (freelancers.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = "No Freelancers",
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                flow_panel1.Controls.Add(lbl);
            }
            foreach (Freelancer f in freelancers)
            {
                GroupBox gb = new GroupBox
                {
                    Text = f.Username,
                    Width = 200,
                    Height = 120,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                };
                Label lbl1 = new Label
                {
                    Text = "Name: " + f.Username,
                    AutoSize = true,
                    Location = new Point(10, 20)
                };
                Label lbl2 = new Label
                {
                    Text = "Skills: " + f.Skills,
                    AutoSize = true,
                    Location = new Point(10, 40)
                };
                Label lbl3 = new Label
                {
                    Text = "Porfolio: " + f.Porfolio,
                    AutoSize = true,
                    Location = new Point(10, 60)
                };
                Label lbl4 = new Label
                {
                    Text = "Phone: " + f.Phone,
                    AutoSize = true,
                    Location = new Point(10, 80)
                };
              
                gb.Controls.Add(lbl1);
                gb.Controls.Add(lbl2);
                gb.Controls.Add(lbl3);
                gb.Controls.Add(lbl4);
              
                flow_panel1.Controls.Add(gb);

            }

        }

               
    }
}
