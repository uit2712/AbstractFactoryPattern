using FileReaderExample.AbstractFactories;
using FileReaderExample.ConcreteFactories;

namespace FileReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IReaderAbstractFactory notepadFactory = new NotepadFactory();
            IReaderAbstractFactory notepadPlusPlusFactory = new NotepadPlusPlusFactory();
            IReaderAbstractFactory microsoftWordFactory = new MicrosoftWordFactory();

            string filePath = "file.txt";
            ReaderProgram reader = new ReaderProgram(notepadFactory);
            reader.ReadFile(filePath);

            reader = new ReaderProgram(notepadPlusPlusFactory);
            reader.ReadFile(filePath);

            reader = new ReaderProgram(microsoftWordFactory);
            reader.ReadFile(filePath);
        }
    }
}
