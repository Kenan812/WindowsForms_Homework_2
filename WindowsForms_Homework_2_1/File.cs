using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Homework_2_1
{
    public class File
    {

        public string FolderPath { get; set; }

        public string Mask { get; set; }

        public File(string folderPath, string mask)
        {
            FolderPath = folderPath;
            Mask = mask;
        }

        public File()
        {
            FolderPath = "";
            Mask = "";
        }

    }
}
