using System;
using System.IO;

namespace CryptoWinForm
{
    public class TempFile : IDisposable
    {
        private readonly FileInfo fileInfo;
        private bool disposedValue;

        public long Length { get { return fileInfo.Length; } }

        public TempFile()
        {
            fileInfo = new FileInfo(Path.GetTempFileName());
        }

        public void Refresh() { fileInfo.Refresh(); }

        public StreamWriter AppendText() { return fileInfo.AppendText(); }

        public FileInfo CopyTo(string destFileName) { return fileInfo.CopyTo(destFileName); }

        public FileInfo CopyTo(string destFileName, bool overwrite) { return fileInfo.CopyTo(destFileName, overwrite); }

        public FileStream Open(FileMode mode, FileAccess access) { return fileInfo.Open(mode, access); }

        public FileStream Open(FileMode mode, FileAccess access, FileShare share) { return fileInfo.Open(mode, access, share); }

        public FileStream Open(FileMode mode) { return fileInfo.Open(mode); }

        public FileStream OpenRead() { return fileInfo.OpenRead(); }

        public StreamReader OpenText() { return fileInfo.OpenText(); }

        public FileStream OpenWrite() { return fileInfo.OpenWrite(); }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    try { fileInfo.Delete(); }
                    catch { /* Okay to ignore */ }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~TempFile()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}