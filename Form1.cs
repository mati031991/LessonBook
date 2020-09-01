using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LessonBook
{
    public partial class Main : Form
    {
        private int clickedcolumn = -1;
        private List<Student> students = new List<Student>();
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm(this);
            DialogResult dr = addStudentForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Dodano studenta");
            }
        }

        internal void AddStudentToDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            foreach (var studentsitem in students)
            {
                dataGridView1.Rows.Add(studentsitem.ForName, studentsitem.Name, studentsitem.Index, studentsitem.Subject);
            }
        }

        internal void AddStudent(Student student)
        {
            students.Add(student);
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            clickedcolumn = dataGridView1.SelectedRows.Count;
            if (clickedcolumn != -1)
            {
                AddNoteForm addNoteForm = new AddNoteForm(clickedcolumn - 1, students);
                DialogResult dr = addNoteForm.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Dodano ocene");
                }
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAddNote.Enabled = true;
            buttonDisplayNote.Enabled = true;
        }

        private void buttonDisplayNote_Click(object sender, EventArgs e)
        {
            clickedcolumn = dataGridView1.SelectedRows.Count;
            if (clickedcolumn != -1)
            {
                DisplayNoteForm displayNoteForm = new DisplayNoteForm(clickedcolumn - 1, students);
                DialogResult dr = displayNoteForm.ShowDialog();
            }

        }
    }
}
