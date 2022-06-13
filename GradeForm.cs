using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Student_Grades
{
    public partial class GradeForm : Form
    {   string fileName = "grades.txt"; 
        public GradeForm()
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;
            btnLoad.Click += btnLoad_Click;
        }

        private void btnSave_Click(object sender,EventArgs e)
        {     
            try  
           {        FileStream fileStream;
                    BinaryFormatter bf = new BinaryFormatter();
                    if(File.Exists(fileName)) File.Delete(fileName);
                    fileStream = File.Create(fileName);
                    //StreamWriter stream = new StreamWriter(fileName);
                    Student std = new Student();
                    if (textBoxName.Text.Contains(" "))
                    {
                        String[] name = textBoxName.Text.Split(' ');
                        std.FirstName = name[0];
                        std.LastName = "";
                        if(name[1] != null)
                        std.LastName = name[1];
                    }
                    else{
                        std.FirstName = textBoxName.Text;
                        std.LastName = "Not Found";
                    } 
                    
                    std.StudentId = textBoxStudentId.Text;
                    std.StudentClass = textBoxClass.Text;
                    std.StudentGrade = textBoxGrade.Text;
                    //stream.WriteLine(std);
                    //stream.Close();
                    bf.Serialize(fileStream,std);
                    fileStream.Close();
                    MessageBox.Show("New line added");
                    textBoxName.Text = "";
                    textBoxStudentId.Text = "";
                    textBoxClass.Text = "";
                    textBoxGrade.Text = "";
           }  
           catch(Exception exp)  
           {  
                MessageBox.Show(exp.Message);  
           }  
            
      }

        private void btnLoad_Click(object sender,EventArgs e)
        {    FileStream fileStream;
             BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(fileName))
            {   
                fileStream = File.OpenRead(fileName);
                 Student std = bf.Deserialize(fileStream) as Student;
                 textBoxLoadedGrade.AppendText(std.LastName+", "+std.FirstName+": "+std.StudentId+" \""+std.StudentClass+"\" \""+std.StudentGrade+"\"");
                //StreamReader stream = new StreamReader(fileName);
                //textBoxLoadedGrade.AppendText(stream.ReadToEnd());
                fileStream.Close();

            }
            else
                MessageBox.Show("There was a problem loading the file");    
        }

    }
}
