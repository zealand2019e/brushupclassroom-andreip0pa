using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom myClass = new ClassRoom();
            myClass.ClassName = "3Q";
            myClass.SemesterStart = new DateTime(2019, 8, 26);
            myClass.Students.Add(new Student(4, 10, "Andrei"));
            myClass.Students.Add(new Student(10, 6, "Will"));
            myClass.Students.Add(new Student(17, 10, "Bartosz"));

           // throws month out of range exception
           // myClass.Students.Add(new Student(14, 14, "Greg"));  
           //

            Console.WriteLine(myClass.ClassName);
            Console.WriteLine(myClass.SemesterStart.ToString());
            foreach (var item in myClass.Students)
            {
                Console.WriteLine(item.Name+" "+item.BirthDay+" "+item.BirthMonth);
            }
            Console.WriteLine(myClass.NumberOfPeopleWithBirhtMonth(10).ToString());

            Console.ReadLine();
        }
    }
}
