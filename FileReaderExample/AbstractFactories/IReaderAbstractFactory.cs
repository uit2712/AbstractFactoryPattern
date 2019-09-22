using FileReaderExample.Interfaces;

namespace FileReaderExample.AbstractFactories
{
    interface IReaderAbstractFactory
    {
        IReader MakeReader();
    }
}
