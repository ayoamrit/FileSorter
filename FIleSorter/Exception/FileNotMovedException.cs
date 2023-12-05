using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.Exception
{
    public class FileNotMovedException : IOException
    {
        public FileNotMovedException(string filename) : base($"'{filename}': An error occurred while moving the file. This error could occur when there are two files of the same name.")
        {

        }
    }
}
