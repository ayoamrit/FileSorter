using FileSorter.Path;
using FileSorter.Exception;
using System.IO;
using FileSorter.FileHandler;
using FileSorter.TransferHandler;

namespace FileSorter;

public class Program
{
    //variable to hold an instance of CPath
    private static CPath? cPath = null;
    private static FileList? fileList = null;

    public static void Main(string[] args)
    {
        //Create an instance of CPath
        cPath = new CPath();

        //Create an instance of fileList
        fileList = new FileList();


        while (true)
        {
            //Execute the function to transfer files to their folders
            Run();

            //Sleep for 5 seconds and then check again if a new file is added to the folder or not
            Thread.Sleep(5000);
        }


    }

    private static void Run()
    {

        try
        {
            //Validate the path (may throw exception)
            cPath.ValidatePath();

            //Get the list of files in a specified directory and extract their names
            IEnumerable<string?> files = Directory.GetFiles(cPath.GetPath()).Select(selector: System.IO.Path.GetFileName);


            //check if the size of files is not zero
            //Count of more than 0 indicates that there is a file in the folder, which has to be sorted
            //Count of 0 indicates that there is not file to be sorted
            if (files.Count() != 0)
            {

                //Iterate through the list of file names and add each file to the FileList
                foreach (var file in files)
                {
                    fileList.AddFile(file);
                }


                new Transfer(fileList.GetFileList(), cPath.GetPath());
            }

        }
        catch (PathException ex)
        {
            //Handle a generic path related exception
            Console.WriteLine(ex.Message);
        }
        catch (PathNotFoundException ex)
        {
            //Handle a specific exception when the path is not found or does not exist
            Console.WriteLine(ex.Message);
        }
        catch (FolderNotCreatedException ex)
        {
            //Handle an exception when the folder is not created 
            Console.WriteLine(ex.Message);
        }
        catch (FileNotMovedException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            fileList.ClearFileList();
        }
    }
}