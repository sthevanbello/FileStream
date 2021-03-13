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

            #region FileStream StreamReader

            //string path = @"D:\Temp\file1.txt";

            //FileStream fileStream = null;
            //StreamReader streamReader = null;

            //try
            //{
            //    //fileStream = new FileStream(path, FileMode.Open);

            //    //streamReader = new StreamReader(fileStream);

            //    streamReader = File.OpenText(path);

            //    while (!streamReader.EndOfStream)
            //    {
            //    string line1 = streamReader.ReadLine();
            //    Console.WriteLine($"{line1}");

            //    }

            //    //string line2 = streamReader.ReadLine();

            //    //Console.WriteLine(line2);

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (streamReader != null) streamReader.Close();
            //    if (fileStream != null) fileStream.Close();

            //}


            #endregion

            #region using


            //string path = @"D:\Temp\file1.txt";


            //try
            //{
            //    using (FileStream fileStream = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader streamReader = new StreamReader(fileStream))
            //        {

            //            while (!streamReader.EndOfStream)
            //            {
            //                string text = streamReader.ReadLine();
            //                Console.WriteLine(text);
            //            }
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //try
            //{
            //    using (StreamReader streamReader = File.OpenText(path))
            //    {

            //        while (!streamReader.EndOfStream)
            //        {
            //            string text = streamReader.ReadLine();
            //            Console.WriteLine(text);
            //        }
            //    }


            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region StreamWriter

            string sourcePath = @"D:\Temp\file1.txt";
            string targetPath = @"D:\Temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                //File.WriteAllLines(targetPath, lines);

                using (StreamWriter streamWriter = File.AppendText(targetPath))
                {
                    streamWriter.WriteLine("\n");
                    foreach (string line in lines)
                    {
                        streamWriter.WriteLine($"{line.ToUpper()}");
                    }
                    
                    Console.WriteLine("Done!");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            #endregion



            Console.ReadKey();
        }
    }
}
