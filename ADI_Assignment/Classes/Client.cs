using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer_client.Classes
{
    public class Client: User
    {
        private int clientid;
        private string companyName;
        private string companyAddress;
        private string companyPhone;
        private string companyEmail;
        private string companyWebsite;
        private string companyDescription;
        private int postedProjectId;

        public int ClientId { get => clientid; set => clientid = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string CompanyAddress { get => companyAddress; set => companyAddress = value; }
        public string CompanyPhone { get => companyPhone; set => companyPhone = value; }
        public string CompanyEmail { get => companyEmail; set => companyEmail = value; }
        public string CompanyWebsite { get => companyWebsite; set => companyWebsite = value; }
        public string CompanyDescription { get => companyDescription; set => companyDescription = value; }
        public int PostedProjectId { get => postedProjectId; set => postedProjectId = value; }


    }
}
