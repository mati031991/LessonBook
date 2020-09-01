using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LessonBook
{
    public partial class AddNoteForm : Form
    {
        private int StudentCount = -1;
        List<Student> students = null;
        public AddNoteForm(int s, List<Student> sl)
        {
            InitializeComponent();
            StudentCount = s;
            students = sl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {
                Mark mark = new Mark(textBoxCourse.Text, textBoxData.Text, textBoxValue.Text);
                students[StudentCount].AddMark(mark);
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ValidForm()
        {
            if (String.IsNullOrWhiteSpace(textBoxCourse.Text))
            {
                MessageBox.Show("Podaj nazwę przedmiotu !");
                return false;
            }

            if (String.IsNullOrWhiteSpace(textBoxData.Text))
            {
                MessageBox.Show("Podaj datę wystawienia przedmiotu !");
                return false;
            }

            if (String.IsNullOrWhiteSpace(textBoxValue.Text))
            {
                MessageBox.Show("Podaj ocenę z przedmiotu !");
                return false;
            }
            else
                return true;
        }
    }
}
