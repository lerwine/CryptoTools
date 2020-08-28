using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace CryptoWinForm
{
    public class Base64LineReader : IDisposable
    {
        private static readonly Regex BASE64_START_LINE = new Regex(@"^[A-Za-z\d+/]+(==?)?$", RegexOptions.Compiled);
        private static readonly Regex BASE64_LINE = new Regex(@"^[A-Za-z\d+/]+$", RegexOptions.Compiled);
        private bool disposedValue;
        private bool endOfData = false;
        private readonly StreamReader reader;
        private readonly StringBuilder currentLine = new StringBuilder();
        public Base64LineReader(StreamReader reader)
        {
            this.reader = reader;
            String line;
            Match match;
            do
            {
                if (null == (line = reader.ReadLine()))
                {
                    endOfData = true;
                    return;
                }
            }
            while ((line = line.Trim()).Length == 0 || !(match = BASE64_START_LINE.Match(line)).Success);
            currentLine.AppendLine(line);
            if (match.Groups[1].Success)
            {
                endOfData = true;
                return;
            }

            for (int i = 1; i < 100; i++)
            {
                if (null == (line = reader.ReadLine()) || (line = line.Trim()).Length == 0)
                {
                    endOfData = true;
                    break;
                }
                currentLine.AppendLine(line);
                if (!BASE64_LINE.IsMatch(line))
                {
                    endOfData = true;
                    break;
                }
            }
        }
        public byte[] getNext()
        {
            string result = currentLine.ToString();
            currentLine.Clear();
            if (endOfData) {
                if (result.Length == 0)
                    return null;
                return Convert.FromBase64String(result);
            }
            for (int i = 0; i < 100; i++)
            {
                String line;
                if (null == (line = reader.ReadLine()) || (line = line.Trim()).Length == 0)
                {
                    endOfData = true;
                    break;
                }
                currentLine.AppendLine(line);
                if (!BASE64_LINE.IsMatch(line))
                {
                    endOfData = true;
                    break;
                }
            }
            return Convert.FromBase64String(result);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Base64LineReader()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}