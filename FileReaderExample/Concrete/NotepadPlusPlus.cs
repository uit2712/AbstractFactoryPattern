using FileReaderExample.Interfaces;
using System;

namespace FileReaderExample.Concrete
{
    class NotepadPlusPlus : IReader
    {
        public void Read(string path)
        {
            Console.WriteLine("Read file: " + path);
            Console.WriteLine("Hello, I'm notepad++, an extension of notepad, I can also be used to program many languages :D");
        }
    }
}
