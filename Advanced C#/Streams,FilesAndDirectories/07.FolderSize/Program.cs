using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long length = 0;

            string[] files = Directory.GetFiles(folderPath);
            foreach (var file in files)
            {
                FileInfo fileinfo = new FileInfo(file);
                length += fileinfo.Length;
            }

            string[] dirs = Directory.GetDirectories(folderPath);
            foreach (var dir in dirs)
            {
                FileInfo fileinfo = new FileInfo(dir);
                length += fileinfo.Length;
            }

            Console.WriteLine(length);
        }
    }
}