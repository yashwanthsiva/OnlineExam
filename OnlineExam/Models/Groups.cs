using OnlineExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
        public ICollection<Students> Students { get; set; }
        public ICollection<Exams> Exams { get; set; }

    }
}
