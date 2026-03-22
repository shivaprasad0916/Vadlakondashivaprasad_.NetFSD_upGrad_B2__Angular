using System;
using System.IO;

namespace IODemo
{
    internal class StreamWriterDemo
    {
        public async static void Main()
        {
            await WriteData("This is test content");
            Console.WriteLine("Content is written successfully");
        }

        public async static Task WriteData(string content)
        {
            //when class or base class implements IDisposable interface

            using (FileStream fs = new FileStream(@"D:\FileTest.txt", FileMode.OpenOrCreate))
            {
                Console.WriteLine("File is Created and Opened");
                using (StreamWriter streamWriter = new StreamWriter(fs))
                {
                    await streamWriter.WriteLineAsync(content);
                    streamWriter.Close();
                    fs.Close();
                }
            }

            Console.WriteLine("FileStream and StreamWriter are Closed");
        }

    }
}
