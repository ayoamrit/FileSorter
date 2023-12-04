﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.FileHandler
{
    public class FileList
    {
        //List to store file objects
        private List<File>? fileList { get; set; }

        //Constructor to initialize the fileList
        public FileList()
        {
            fileList = new List<File>();
        }

        //Add a new file to the list
        public void AddFile(string file)
        {
            //Extract filename and extension from the file path
            (string filename, string fileExtension) = GetFileProperties(file);

            //Create a new File object and adds it to the list
            fileList.Add(new File(filename, fileExtension));
        }


        //Function to extract filename and extension from a given file path
        private (string, string) GetFileProperties(string file)
        {
            //Splits the file path based on the dot('.') to separate filename and extension.
            string[] fileProperties = file.Split('.');

            //Return a tuple with filename and extension
            return (fileProperties[0], fileProperties[1]);
        }

        //Gets the list of File objects
        public List<File>? GetFileList()
        {
            return fileList;
        }

        public void DisplayList()
        {
            foreach(var file in fileList)
            {
                Console.WriteLine(file.GetFileName() + " "+ file.GetExtension());
            }
        }
    }
}
