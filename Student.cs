using System;

namespace Task1
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private Mark[] marksPool;
       
      

        public Student(Mark[] marksPool=null ,string firstName = "firstName not specified", 
            string lastName = "lastNamenot specified",int age = 0)
        {
            
            if (marksPool==null)
            {
                marksPool = new Mark[] { };
            }
            
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.marksPool = marksPool;
            
        }

        
        public string FirstNameProp
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastNameProp
        {
            get => lastName;
            set => lastName = value;
        }

        public int AgeProp
        {
            get => age;
            set => age = value;
        }

        public Mark[] MarksPoolProp
        {
            get => marksPool;
            set => marksPool = value;
        }

        public string GetingStrMarksPool()
        {
            string marksString = null;
            foreach (var mark in marksPool)
            {
                marksString += mark.SubjectNameProp + "|| mark:" +
                               mark.SubjectMarkProp + "\n";
            }
            return marksString;
        }

        public float GetAvgMark()
        {
            int avgMark = 0;
            foreach (var mark in marksPool)
            {
                avgMark +=mark.SubjectMarkProp ;
            }

            avgMark = avgMark == 0 ? 0 : avgMark / marksPool.Length;
            return avgMark ;
        }

        public void ResetAllMarks()
        {
            foreach (var mark in marksPool)
            {
                mark.SubjectMarkProp = 0 ;
            }
           
        }

        public override string ToString()
        {
            string stringForm = "FirstName:{0,-10} LastName:{1,-10} " +
                                "Age:{2,-4} AvgMark:{3,-4} \n{4}";
            string stringOutput = string.Format(stringForm, firstName,lastName,
                age, GetAvgMark(),GetingStrMarksPool());
            return stringOutput;
            
        }
    }
}