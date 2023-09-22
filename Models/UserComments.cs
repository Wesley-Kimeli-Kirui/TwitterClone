using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterClone.Models
{
    public class UserComments
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}