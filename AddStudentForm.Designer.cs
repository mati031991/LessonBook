namespace LessonBook
{
    partial class AddStudentForm
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
            this.labelForname = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxForname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForname
            // 
            this.labelForname.AutoSize = true;
            this.labelForname.Location = new System.Drawing.Point(45, 80);
            this.labelForname.Name = "labelForname";
            this.labelForname.Size = new System.Drawing.Size(37, 17);
            this.labelForname.TabIndex = 0;
            this.labelForname.Text = "Imię:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(45, 124);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(71, 17);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Nazwisko:";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(45, 169);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(80, 17);
            this.labelIndex.TabIndex = 3;
            this.labelIndex.Text = "Nr Indeksu:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(45, 209);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(68, 17);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Kierunek:";
            // 
            // textBoxForname
            // 
            this.textBoxForname.Location = new System.Drawing.Point(167, 80);
            this.textBoxForname.Name = "textBoxForname";
            this.textBoxForname.Size = new System.Drawing.Size(177, 22);
            this.textBoxForname.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(167, 124);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(177, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(167, 169);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(177, 22);
            this.textBoxIndex.TabIndex = 6;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(167, 209);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(177, 22);
            this.textBoxSubject.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(102, 282);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(156, 43);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 377);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxForname);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.labelForname);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForname;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxForname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button buttonAdd;
    }
}