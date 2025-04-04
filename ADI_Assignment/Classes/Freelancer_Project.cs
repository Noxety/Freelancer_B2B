using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer_client.Classes
{
    public class Freelancer_Project
    {
        private int id;
        private int freelancer_id;
        private int project_id;
        private DateTime applied_date;
        public int Id { get => id; set => id = value; }
        public int Freelancer_id { get => freelancer_id; set => freelancer_id = value; }
        public int Project_id { get => project_id; set => project_id = value; }
        public DateTime Applied_date { get => applied_date; set => applied_date = value; }
    }
}
