using System;
using System.Windows.Forms;

namespace LessonBook
{
    public partial class AddStudentForm : Form
    {
        private Main mainForm = null;
        public AddStudentForm(Main m)
        {
            InitializeComponent();
            mainForm = m;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {
                try
                {
                    Student student = new Student(textBoxForname.Text, textBoxName.Text, textBoxIndex.Text, textBoxSubject.Text);
                    mainForm.AddStudent(student);
                    mainForm.AddStudentToDataGridView();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }
        }

        private bool ValidForm()
        {
            if (String.IsNullOrWhiteSpace(textBoxForname.Text))
            {
                MessageBox.Show("Uzupełnij imię !");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Uzupełnij nazwisko !");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBoxIndex.Text))
            {
                MessageBox.Show("Uzupełnij nr indeksu !");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBoxSubject.Text))
            {
                MessageBox.Show("Uzupełnij kierunek studiów !");
                return false;
            }
            else
                return true;
        }
    }
}
