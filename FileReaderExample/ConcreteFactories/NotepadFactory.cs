using FileReaderExample.AbstractFactories;
using FileReaderExample.Concrete;
using FileReaderExample.Interfaces;

namespace FileReaderExample.ConcreteFactories
{
    class NotepadFactory : IReaderAbstractFactory
    {
        public IReader MakeReader()
        {
            return new Notepad();
        }
    }
}
