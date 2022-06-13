using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades
{
    [Serializable]
    public class MyStreamWriter: StreamWriter
    {
       public MyStreamWriter(Stream stream): base(stream)
       {
           
       }
       public MyStreamWriter(string path): base(path)
       {

       }

        public int WriteInteger()
        {
            int b = base.Read();
        }
        public int WriteBoolean()
        {
            int b = base.Read();
        }
        public int WriteString()
        {
            int b = base.Read();
        }
    }  
} 