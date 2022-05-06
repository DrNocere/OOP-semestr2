using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class DataReader
    {
        public List<FileData> FilesList = new();
        public List<DirectoryData> DirectoriesList = new();

        public DataReader(string path)
        {
            if (File.Exists(path))
            {
                // This path is a file
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                // This path is a directory
                ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", path);
            }
        }

        public void ProcessDirectory(string targetDirectory)
        {
            long subDirSize = 0;
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory);
                DirectoryData myFolder = new DirectoryData(subdirectory, subDirSize);
                subDirSize = 0;
                DirectoriesList.Add(myFolder);
            }
        }

        public void ProcessFile(string path)
        {
            FileInfo file = new(path);
            FileData newFile = new(file.Name, file.FullName, file.Extension, file.Length);
            FilesList.Add(newFile);
        }

        public void PrintNodes()
        {
            int countDirectories = 0;
            int countFiles = 0;
            long sizeDirectories = 0;
            long sizeFiles = 0;
            foreach (var file in FilesList)
            {
                countFiles++;
                sizeFiles += file.SizeBytes;
            }
            foreach (var directory in DirectoriesList)
            {
                countDirectories++;
                sizeDirectories += directory.Size;
            }
            Console.WriteLine("Nodes:");
            Console.WriteLine("\t\t[count]\t\t[total size]");
            Console.WriteLine($"   Directories:\t{countDirectories}\t\t{Tools.ConvertSize(sizeDirectories)}");
            Console.WriteLine($"   Files:      \t{countFiles}\t\t{Tools.ConvertSize(sizeFiles)}");
        }
    }
}
