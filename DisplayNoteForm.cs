using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LessonBook
{
    public partial class DisplayNoteForm : Form
    {
        private int v;
        private List<Student> students;

        public DisplayNoteForm(int v, List<Student> students)
        {
            InitializeComponent();
            this.v = v;
            this.students = students;
        }

        private void DisplayNoteForm_Load(object sender, EventArgs e)
        {
            DisplayNodes();
        }

        private void DisplayNodes()
        {
            foreach (var item in students[v].Marks)
            {
                dataGridView1.Rows.Add(item.Course, item.Date, item.Value);
            }
        }
    }
}
