using FileSorter.Path;
using FileSorter.Exception;
using System.IO;
using FileSorter.FileHandler;

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

        fileList = new FileList();

        try
        {
            //Validate the path (may throw exception)
            cPath.ValidatePath();

            //Get the list of files in a specified directory and extract their names
            IEnumerable<string?> files = Directory.GetFiles(cPath.GetPath()).Select(selector: System.IO.Path.GetFileName);

            //Iterate through the list of file names and add each file to the FileList
            foreach (var file in files)
            {
                fileList.AddFile(file);
            }

            fileList.DisplayList();

        }
        catch (PathException ex)
        {
            //Handle a generic path related exception
            Console.WriteLine(ex.Message);
        }
        catch(PathNotFoundException ex)
        {
            //Handle a specific exception when the path is not found or does not exist
            Console.WriteLine(ex.Message);
        }
    }
}