using FileReaderExample.Interfaces;
using System;

namespace FileReaderExample.Concrete
{
    class Notepad : IReader
    {
        public void Read(string path)
        {
            Console.WriteLine("Read file: " + path);
            Console.WriteLine("Hello, I'm notepad and I can display plain text without formatting!");
        }
    }
}
