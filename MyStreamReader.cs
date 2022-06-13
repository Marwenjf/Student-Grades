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
    public class MyStreamReader: StreamReader
    {
       public MyStreamReader(Stream stream): base(stream)
       {
           
       }
       public MyStreamReader(string path): base(path)
       {

       }

        public int ReadInteger()
        {
            int b = base.Read();
            if (b == -1)
            {
                return null;
            }
            return b;
        }
        public int ReadBoolean()
        {
            int b = base.Read();
        }
        public int ReadString()
        {
            int b = base.Read();
        }
    }  
} 