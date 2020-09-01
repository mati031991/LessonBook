namespace LessonBook
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ForName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.buttonDisplayNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(35, 18);
            this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(123, 34);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "Dodaj studenta";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ForName,
            this.Name,
            this.Index,
            this.Subject,
            this.MarkCount});
            this.dataGridView1.Location = new System.Drawing.Point(35, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(661, 447);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ForName
            // 
            this.ForName.HeaderText = "Imię";
            this.ForName.MinimumWidth = 6;
            this.ForName.Name = "ForName";
            this.ForName.ReadOnly = true;
            this.ForName.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Nazwisko";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // Index
            // 
            this.Index.HeaderText = "Nr indeksu";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Kierunek";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 125;
            // 
            // MarkCount
            // 
            this.MarkCount.HeaderText = "Liczba ocen";
            this.MarkCount.Name = "MarkCount";
            this.MarkCount.ReadOnly = true;
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Enabled = false;
            this.buttonAddNote.Location = new System.Drawing.Point(178, 18);
            this.buttonAddNote.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(123, 34);
            this.buttonAddNote.TabIndex = 2;
            this.buttonAddNote.Text = "Dodaj ocenę";
            this.buttonAddNote.UseVisualStyleBackColor = true;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // buttonDisplayNote
            // 
            this.buttonDisplayNote.Enabled = false;
            this.buttonDisplayNote.Location = new System.Drawing.Point(320, 18);
            this.buttonDisplayNote.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisplayNote.Name = "buttonDisplayNote";
            this.buttonDisplayNote.Size = new System.Drawing.Size(123, 34);
            this.buttonDisplayNote.TabIndex = 3;
            this.buttonDisplayNote.Text = "Wyświetl oceny";
            this.buttonDisplayNote.UseVisualStyleBackColor = true;
            this.buttonDisplayNote.Click += new System.EventHandler(this.buttonDisplayNote_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 583);
            this.Controls.Add(this.buttonDisplayNote);
            this.Controls.Add(this.buttonAddNote);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddStudent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.Button buttonDisplayNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkCount;
    }
}

