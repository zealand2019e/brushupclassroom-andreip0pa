using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {

        private string className;

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
        private List<Student> students;

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        private DateTime semesterStart;

        public DateTime SemesterStart
        {
            get { return semesterStart; }
            set { semesterStart = value; }
        }
        public ClassRoom()
        {
            students = new List<Student>();

        }

        //Task 6 Method
        public int NumberOfPeopleWithBirhtMonth(int month)
        {
            int[] months = new int[13];
            foreach (var item in Students)
            {
                months[item.BirthMonth]++;
            }
            return months[month];
        }


    }
}
