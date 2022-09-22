using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPP.Infrastructure.Models
{
    public class StudentInfo
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }

        public int GenderID { get; set; }

        public Gender Gender { get; set; }
    }
}
