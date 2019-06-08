using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class StringFunctions
    {
        delegate bool IsTeenage(Student student);
        Student st = new Student();
        IsTeenage isTeenage = st => st.Age > 13 && st.Age < 18; 
        //Clone()
        
        public void ReferenceString()
        {
            string s1 = "I live in this town";
            string s2 =(String)s1.Clone();
            s1 = "I dont live in this town";
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);
           
        }
    }
}
