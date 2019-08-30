using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        private int birth_month;

        public int BirthMonth
        {
            get { return birth_month; }
            private set { if (value > 12 || value < 1) { throw new Exception("Month out of range"); } birth_month = value; }
        }

        private int birth_day;

        
        public int BirthDay
        {
            get { return birth_day; }
            private set { birth_day = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string Season()
        {
            if (BirthMonth==1 || BirthMonth==12 || BirthMonth == 2)
            {
                return "Winter";
            }
            if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                return "Spring";
            }
            if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return "Summer";
            }
            if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
            {
                return "Autumn";
            }
            throw new Exception("birth month weird");

        }

        
        public Student(int bday, int bmonth, string name)
        {
            Name = name;
            BirthDay = bday;
            BirthMonth = bmonth;

        }


    }
}
