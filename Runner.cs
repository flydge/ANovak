using System;
using System.Collections.Generic;
using System.Security;

namespace Task1
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {

            const int numbOfMarks = 5;
           
            Mark[] marksArr = new Mark[numbOfMarks];
            
            for (int i = 0; i < numbOfMarks; i++)
            {
                marksArr[i] = new Mark("SubjectName:"+i, i);
               
            }
            // Student student = new Student();   // using optional arguments
            Student student = new Student(firstName:"Artyom",lastName:"Novak"
                ,age:21,marksPool:marksArr);
            // student.ResetAllMarks();  //all student’s marks equal to zero
            Console.WriteLine(student);
         

        }
    }
}