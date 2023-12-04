using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.Exception
{
    public class PathNotFoundException : IOException
    {
        public PathNotFoundException(string _path) : base($"'{_path}': The path does not exist")
        {

        }
    }
}
