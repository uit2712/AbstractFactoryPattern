using FileReaderExample.AbstractFactories;
using FileReaderExample.Interfaces;

namespace FileReaderExample
{
    class ReaderProgram
    {
        protected IReaderAbstractFactory _readerFactory;
        protected IReader _reader;

        public ReaderProgram(IReaderAbstractFactory readerFactory)
        {
            _readerFactory = readerFactory;
            if (_readerFactory != null)
                _reader = _readerFactory.MakeReader();
        }

        public void ReadFile(string path)
        {
            if (_reader != null)
                _reader.Read(path);
        }
    }
}
