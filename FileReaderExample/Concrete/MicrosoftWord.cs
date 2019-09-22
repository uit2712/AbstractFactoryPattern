using FileReaderExample.Interfaces;
using System;

namespace FileReaderExample.Concrete
{
    class MicrosoftWord : IReader
    {
        public void Read(string path)
        {
            Console.WriteLine("Read file: " + path);
            Console.WriteLine("Hello, I'm microsoft word, I can do many things such as show text with many beautiful format and color,...");
        }
    }
}
