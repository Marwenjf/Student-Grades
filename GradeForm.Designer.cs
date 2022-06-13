using System.Drawing;
using System.Windows.Forms;

namespace Student_Grades
{
    partial class GradeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Text = "Grades Form";

            this.labelName = new Label();
            this.labelStudentId = new Label();
            this.labelClass = new Label();
            this.labelGrade = new Label();

            this.textBoxName = new TextBox();
            this.textBoxStudentId = new TextBox();
            this.textBoxClass = new TextBox();
            this.textBoxGrade = new TextBox();
            this.textBoxLoadedGrade = new TextBox();

            this.btnSave = new Button();
            this.btnLoad = new Button();

            this.labelName.Text = "Name:";
            this.labelStudentId.Text = "Student ID:";
            this.labelClass.Text = "Class:";
            this.labelGrade.Text = "Grade:";

            this.btnSave.Text = "Save";
            this.btnLoad.Text = "Load";

            this.labelName.Location = new System.Drawing.Point(20, 20);
            this.labelStudentId.Location = new System.Drawing.Point(20, 50);
            this.labelClass.Location = new System.Drawing.Point(20, 80);
            this.labelGrade.Location = new System.Drawing.Point(20, 110);
        
            this.textBoxName.Location = new System.Drawing.Point(120, 20);
            this.textBoxName.Size = new System.Drawing.Size(140, 20);

            this.textBoxStudentId.Location = new System.Drawing.Point(120, 50);
            this.textBoxStudentId.Size = new System.Drawing.Size(140, 20);

            this.textBoxClass.Location = new System.Drawing.Point(120, 80);
            this.textBoxClass.Size = new System.Drawing.Size(140, 20);

            this.textBoxGrade.Location = new System.Drawing.Point(120, 110);
            this.textBoxGrade.Size = new System.Drawing.Size(140, 20);

            this.btnSave.Location = new System.Drawing.Point(90, 150);
            this.btnSave.Size = new System.Drawing.Size(50, 25);
            this.btnLoad.Location = new System.Drawing.Point(145, 150);
            this.btnLoad.Size = new System.Drawing.Size(50, 25);
            
            this.textBoxLoadedGrade.ReadOnly = true;
            this.textBoxLoadedGrade.Multiline = true;
            this.textBoxLoadedGrade.ScrollBars = ScrollBars.Vertical;
            this.textBoxLoadedGrade.Location = new System.Drawing.Point(20, 200);
            this.textBoxLoadedGrade.Size = new System.Drawing.Size(260, 110);

            this.Controls.Add( this.labelName);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.textBoxLoadedGrade);
        }

        private Label labelName;
        private Label labelStudentId;
        private Label labelClass;
        private Label labelGrade;
        private TextBox textBoxName;
        private TextBox textBoxStudentId;
        private TextBox textBoxClass;
        private TextBox textBoxGrade;
        private Button btnSave;
        private Button btnLoad;
        private TextBox textBoxLoadedGrade;

        #endregion
    }
}

