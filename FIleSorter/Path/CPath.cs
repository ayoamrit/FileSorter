using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSorter.Exception;

namespace FileSorter.Path
{
    //Concrete implementation of the IPath interface
    public class CPath : IPath
    {

        //Property to store the path
        private string _path { get; set; }

        //Property to store the username
        private string _username { get; set; }

        //Constructor
        public CPath()
        {
            try
            {
                //Try to set username and path
                _username = SetUsername();
                _path = SetPath();
            }
            catch (IOException)
            {
                //If an exception occurs, throw an Path Exception
                throw new PathException();
            }
        }

        //Function to set the path
        public string SetPath()
        {
            //Return a formatted string representing the default download path
            return $"C:\\Users\\{_username}\\Downloads";
        }

        //Function to set the username
        public string SetUsername()
        {
            //Set the current environment username
            return Environment.UserName;
        }

        //Function to get the path
        public string GetPath()
        {
            //Return the stored path
            return _path;
        }

        //Function to validate the path
        public void ValidatePath()
        {
            //Statement to check whether is path exists or not
            if (!System.IO.Directory.Exists(_path))
            {
                //Throw an error if the path does not exist
                throw new PathNotFoundException(_path);
            }
        }
    }
}
