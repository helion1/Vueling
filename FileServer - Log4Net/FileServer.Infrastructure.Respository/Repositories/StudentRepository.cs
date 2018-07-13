using FileServer.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Infrastructure.Respository.Repositories {
    public class StudentRepository  : GenericRepository<Student>{
        public new Student Insert(Student student) {
            student.Age = CalculateAge(student.Birthday);
            return base.Insert(student);
        }

        protected int CalculateAge(DateTime birthday) {
            var today = DateTime.Today;
            int age = today.Year - birthday.Year;
            if(today.Month < birthday.Month || (today.Month == birthday.Month && today.Day < birthday.Day)) {
                age--;
            }
            return age;
        }
    }
}
