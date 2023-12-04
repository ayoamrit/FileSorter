using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.FileHandler
{
    public class File
    {
        //Private fields to store filename and extension
        private string _filename { get; set; } = String.Empty;
        private string _extension { get; set; } = String.Empty;

        //Constructor to initialize the File with filename and extension
        public File(string _filename, string _extension)
        {
            this._filename = _filename;
            this._extension = _extension;
        }

        //Gets the filename of the file
        public string GetFileName()
        {
            return _filename;
        }

        //Gets the extension of the file
        public string GetExtension()
        {
            return _extension;
        }

    }
}
