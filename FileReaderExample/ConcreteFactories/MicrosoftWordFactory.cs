using FileReaderExample.AbstractFactories;
using FileReaderExample.Concrete;
using FileReaderExample.Interfaces;

namespace FileReaderExample.ConcreteFactories
{
    class MicrosoftWordFactory : IReaderAbstractFactory
    {
        public IReader MakeReader()
        {
            return new MicrosoftWord();
        }
    }
}
