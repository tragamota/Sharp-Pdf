using System;

namespace SharpPdf.Exceptions
{
    public class FilePathDoesNotExistsException : Exception
    {
        public FilePathDoesNotExistsException() {}
        public FilePathDoesNotExistsException(string message) : base(message) {}
        public FilePathDoesNotExistsException(string message, Exception innerEx) : base(message, innerEx) {}
    }
}