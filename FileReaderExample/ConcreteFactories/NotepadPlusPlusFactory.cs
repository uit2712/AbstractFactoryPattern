using FileReaderExample.AbstractFactories;
using FileReaderExample.Concrete;
using FileReaderExample.Interfaces;

namespace FileReaderExample.ConcreteFactories
{
    class NotepadPlusPlusFactory : IReaderAbstractFactory
    {
        public IReader MakeReader()
        {
            return new NotepadPlusPlus();
        }
    }
}
