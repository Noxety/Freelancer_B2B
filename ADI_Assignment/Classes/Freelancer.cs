using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer_client.Classes
{
    public class Freelancer: User
    {
        private int freelancerId;
        private string skills;
        private string expertise;
        private string porfolio;
        private int appliedProjectId;

        public int FreelancerId { get => freelancerId; set => freelancerId = value; }
        public string Skills { get => skills; set => skills = value; }
        public string Expertise { get => expertise; set => expertise = value; }
        public string Porfolio { get => porfolio; set => porfolio = value; }
        public int AppliedProjectId { get => appliedProjectId; set => appliedProjectId = value; }

       
        

    }
}
