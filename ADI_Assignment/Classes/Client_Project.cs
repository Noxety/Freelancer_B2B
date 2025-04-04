using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer_client.Classes
{
    public class Client_Project
    {
        private int id;
        private int client_id;
        private int project_id;

        public int Id { get => id; set => id = value; }
        public int Client_id { get => client_id; set => client_id = value; }
        public int Project_id { get => project_id; set => project_id = value; }

    }
}
