using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer_client.Classes
{
    public class Project
    {
        private int projectId;
        private string projectName;
        private string projectDescription;
        private string projectSkills;
        private double projectBudget;
        private string projectDuration;
        private string projectStatus;   
        private string projectDeadline;
        private DateTime projectCompletedDate;
        private DateTime projectCreatedDate;

        public int ProjectId { get => projectId; set => projectId = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public string ProjectDescription { get => projectDescription; set => projectDescription = value; }
        public string ProjectSkills { get => projectSkills; set => projectSkills = value; }
        public double ProjectBudget { get => projectBudget; set => projectBudget = value; }
        public string ProjectDuration { get => projectDuration; set => projectDuration = value; }
        public string ProjectStatus { get => projectStatus; set => projectStatus = value; }
        public string ProjectDeadline { get => projectDeadline; set => projectDeadline = value; }
        public DateTime ProjectCompletedDate { get => projectCompletedDate; set => projectCompletedDate = value; }
        public DateTime ProjectCreatedDate { get => projectCreatedDate; set => projectCreatedDate = value; }


    }
}
