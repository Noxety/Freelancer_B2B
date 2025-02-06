using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer_client.Classes
{
    public class Rating
    {
        private int ratingId;
        private int clientId;
        private int projectId;
        private int freelancerId;
        private float rating;

        public int RatingId { get => ratingId; set => ratingId = value; }
        public int ClientId { get => clientId; set => clientId = value; }
        public int ProjectId { get => projectId; set => projectId = value; }
        public int FreelancerId { get => freelancerId; set => freelancerId = value; }
        public float RatingValue { get => rating; set => rating = value; }

    }
}
