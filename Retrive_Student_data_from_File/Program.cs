using System;
using System.IO;

namespace Retrive_Student_data_from_File
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Practice Exercises\.Net\Phase-1 Agile, Git, and Basics of C# Programming\PracticeProject2\Retrive_Student_data_from_File\Data.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                try
                {
                    string file_data = sr.ReadToEnd();
                    Console.WriteLine(file_data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                    sr.Dispose();
                    fs.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
