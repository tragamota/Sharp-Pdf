using System;
using System.Dynamic;
using System.IO;
using SharpPdf.Exceptions;

namespace SharpPdf.Utils
{
    public class FilePath
    {
        public string AbsolutePath { get; private set; }
        public string FileName { get; private set; }
        public string FileExtension { get; private set; }

        public DateTime CreationDate { get; private set; }
        public DateTime LastModified { get; private set; }
        public DateTime LastAccess { get; private set; }

        public FilePath(string path)
        {
            if (!DoesPathExist(path))
                throw new FilePathDoesNotExistsException();

            FlattenPathInformation(path);
        }

        private void FlattenPathInformation(string path)
        {
            AbsolutePath = Path.GetFullPath(path);
            FileName = Path.GetFileNameWithoutExtension(path);
            FileExtension = Path.GetExtension(path);

            CreationDate = File.GetCreationTimeUtc(path);
            LastModified = File.GetLastWriteTime(path);
            LastAccess = File.GetLastAccessTimeUtc(path);
        }

        public static bool DoesPathExist(string path)
        {
            return File.Exists(path);
        }
    }
}