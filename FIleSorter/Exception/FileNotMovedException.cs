using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.Exception
{
    public class FileNotMovedException : IOException
    {
        public FileNotMovedException(string filename) : base($"'{filename}': ")
        {

        }
    }
}
