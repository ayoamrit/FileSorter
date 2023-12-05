using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSorter.FileHandler;
using FileSorter.Exception;

namespace FileSorter.TransferHandler
{
    public class Transfer
    {

        //List of files to be transferred
        private List<FileHandler.File> fileList { get; set; }

        //Destination path for the transfer
        private string _path { get; set; }
        
        //Constructor for the Transfer
        public Transfer(List<FileHandler.File> fileList, string _path)
        {
            //Initialize the fileList and _path properties
            this.fileList = fileList;
            this._path = _path;
            
            //Process the transfer request
            ProcessTransferRequest();
        }

        //Process the transfer request for each file in the fileList
        private void ProcessTransferRequest()
        {
            for(int x = 0; x < fileList.Count; x++)
            {
                //Extract the filename and extension from the File object
                ProcessTransferRequestHelper(fileList[x].GetFileName(), fileList[x].GetExtension());

            }
        }

        //Helper method to process the transfer request for an individual file
        private void ProcessTransferRequestHelper(string filename, string fileExtension)
        {
            //Concatenate the filename and extension to get the full filename
            string fullFileName = $"{filename}.{fileExtension}";

            //Create a folder path based on the extension (uppercase)
            string folderPath = $"{_path}\\{fileExtension.ToUpper()}";

            //check if the folder exists
            bool folderFlag = ValidateFolder(folderPath);

            //If the folder doesn't exist, create it
            if (!folderFlag)
            {
                try
                {
                    CreateFolder(folderPath);
                }
                catch (IOException)
                {
                    throw new FolderNotCreatedException(filename);
                }
            }

            try
            {
                //Move the file to the destination folder
                MoveFile(fullFileName, folderPath);
            }
            catch (IOException)
            {
                throw new FileNotMovedException(filename);
            }
        }

        //Check if the folder already exists
        //Return true if the folder exists, false otherwise
        private bool ValidateFolder(string folderPath)
        {

            if (System.IO.Directory.Exists(folderPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Create a folder at the specified directory
        private void CreateFolder(string directory)
        {
            Directory.CreateDirectory(directory);
        }

        //Move the file from the source path to the destination path
        private void MoveFile(string fullFileName, string destinationPath)
        {
            //Construct the source path based on the provided _path and fullFilename
            string sourcePath = $"{_path}\\{fullFileName}";

            //Move the file to the destination folder
            System.IO.File.Move(sourcePath, destinationPath+"\\"+fullFileName);
        }
    }
}
