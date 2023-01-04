using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace FileGenerator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string e = @"\";
            Console.WriteLine("https://github.com/Tiegertropfen119-0001");
            Console.WriteLine("File size (MB) =>");
            Int64 length = int.Parse(Console.ReadLine());
            length = length * 1048576;
            if(length > 104857600)
            {
                
                Console.WriteLine("Warning filesize over 100MB do you want to continue ? y / n =>");
                string yesno = Console.ReadLine();
                if(yesno == "y")
                {
                    Console.WriteLine("File path =>");
                    string path = Console.ReadLine();
                    Console.WriteLine($"Generating file with size {length} bytes");
                    using StreamWriter writer = File.CreateText(path+e + "test.testfile");
                    for (long l = 0; l < length; l++)
                    {
                        writer.Write('0');
                    }

                    await writer.FlushAsync();

                    Console.WriteLine($"Finished writing data to {path+e}.");
                    Thread.Sleep(1500);
                }
                else
                {
                   
                }

            }
            else
            {
                Console.WriteLine("File path =>");
                string path = Console.ReadLine();
                Console.WriteLine($"Generating file with size {length} bytes");
                using StreamWriter writer = File.CreateText(path+e + "test.testfile");
                for (long l = 0; l < length; l++)
                {
                    writer.Write('0');
                }

                await writer.FlushAsync();

                Console.WriteLine($"Finished writing data to {path+e}.");
                Thread.Sleep(1500);
            }
            
        }
    }
}
