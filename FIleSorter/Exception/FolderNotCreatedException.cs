using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.Exception
{
    public class FolderNotCreatedException : IOException
    {

        public FolderNotCreatedException(string folderName) : base($"'{folderName}': An error occurred while creating the folder")
        {

        }
    }
}
