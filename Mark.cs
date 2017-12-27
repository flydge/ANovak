namespace Task1
{
    public class Mark
    {
        private string SubjectName;
        private int SubjectMark;

        public Mark()
        {
        }

        public Mark(string subjectName = "SubjectName not specified", int subjectMark = 0) 
        {
            SubjectName = subjectName;
            SubjectMark = subjectMark;
        }

        public string SubjectNameProp
        {
            get => SubjectName;
            set => SubjectName = value;
        }

        public int SubjectMarkProp
        {
            get => SubjectMark;
            set => SubjectMark = value;
        }
    }
}