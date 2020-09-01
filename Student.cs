using System.Collections.Generic;

namespace LessonBook
{
    public class Student
    {

        public Student(string forname, string name, string index, string subject)
        {
            this.ForName = forname;
            this.Name = name;
            this.Index = index;
            this.Subject = subject;
        }

        public void AddMark(Mark mark)
        {
            if (Marks == null)
            {
                this.Marks = new List<Mark>();
                this.Marks.Add(mark);
            }
            else
                this.Marks.Add(mark);

        }

        public string ForName { get; private set; }

        public string Name { get; private set; }

        public string Index { get; private set; }

        public string Subject { get; private set; }

        public List<Mark> Marks { get; private set; }
    }
}
