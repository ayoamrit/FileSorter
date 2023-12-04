using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.Exception
{
    public class PathException : IOException
    {
        public PathException() : base("An error while loading the path.")
        {

        }
    }
}
