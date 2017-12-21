namespace Task1
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private Mark[] marksPool;

        public Student()
        {
        }

        public Student(string firstName, string lastName, int age, Mark[] marksPool)
        {
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
            foreach (var VARIABLE in marksPool)
            {
                marksString += VARIABLE.SubjectNameProp + "||" +
                               VARIABLE.SubjectMarkProp + "\n";
            }
            return marksString;
        }

        public float GetAvgMark()
        {
            int avgMark = 0;
            foreach (var VARIABLE in marksPool)
            {
                avgMark +=VARIABLE.SubjectMarkProp ;
            }
            
            return avgMark / marksPool.Length;
        }

        public void ResetAllMarks()
        {
            foreach (var VARIABLE in marksPool)
            {
                VARIABLE.SubjectMarkProp = 0 ;
            }
           
        }

        public override string ToString()
        {
            return  "FirstName: "+firstName + "||" + "LastName:"+lastName+
                    "||" + "Age:"+age+ "|| \n"+ GetingStrMarksPool()+ "\n"+
                    "AvgMark:"+GetAvgMark();
        }
    }
}