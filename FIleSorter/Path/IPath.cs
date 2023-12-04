using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.Path
{
    interface IPath
    {
        //Function to set the path
        string SetPath();

        //Function to set the username
        string SetUsername();

        //Function to get the path
        string GetPath();
    }
}
