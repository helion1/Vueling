using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Common.Model {
    public class Student : EntityModel{
        public Student(DateTime birthday) {
            Birthday = birthday;
        }

        public DateTime Birthday { get; set; }
        public int Age { get; set; }
    }
}
