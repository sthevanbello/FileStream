using System;
using System.IO;

namespace FileFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region File FileInfo
            //string sourcePath = @"D:\Temp\file1.txt";

            //string targetPath = @"D:\Temp\file2.txt";

            //try
            //{

            //    FileInfo fileInfo1 = new FileInfo(sourcePath);

            //    fileInfo1.CopyTo(targetPath);

            //    Console.WriteLine("File copied...");

            //    string[] lines = File.ReadAllLines(sourcePath);

            //    foreach (string item in lines)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //catch (IOException ex)
            //{

            //    Console.WriteLine($"An error ocurred: {ex.Message}");
            //}
            #endregion

            #region FileStream StreamReader StreamWriter

            string path = @"D:\Temp\file1.txt";

            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                //fileStream = new FileStream(path, FileMode.Open);

                //streamReader = new StreamReader(fileStream);

                streamReader = File.OpenText(path);

                while (!streamReader.EndOfStream)
                {
                string line1 = streamReader.ReadLine();
                Console.WriteLine($"{line1}");

                }

                //string line2 = streamReader.ReadLine();

                //Console.WriteLine(line2);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
                if (fileStream != null) fileStream.Close();
                
            }


            #endregion


            Console.ReadKey();
        }
    }
}
