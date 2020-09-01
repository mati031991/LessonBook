namespace LessonBook
{
    public class Mark
    {
        public Mark(string course, string data, string value)
        {
            this.Course = course;
            this.Date = data;
            this.Value = value;
        }

        public string Course { get; private set; }
        public string Date { get; private set; }
        public string Value { get; private set; }
    }
}
