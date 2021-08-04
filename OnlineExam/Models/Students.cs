using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
        public string CVFileName { get; set; }
        public string PictureFileName { get; set; }
        public int GroupsId { get; set; }
        public Groups Groups { get; set; }
        public ICollection<ExamResults> ExamResults { get; set; }

    }
}
