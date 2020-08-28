using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CryptoWinForm
{
    public class CertFileItem : X509CertSelection
    {
        private readonly FileInfo _file;
        private string _name;
        public FileInfo File { get { return _file; } }

        public override string Name
        {
            get
            {
                if (null == _name)
                    _name = Path.GetFileNameWithoutExtension(_file.Name);
                return _name;
            }
        }


        public static string TryCreate(string fileName, out CertFileItem result)
        {
            try
            {
                FileInfo file = new FileInfo(fileName);
                if (!file.Exists)
                    throw new FileNotFoundException("File not found", fileName);
                if (file.Length > int.MaxValue)
                    throw new ArgumentException("File too large", "fileName");
                byte[] data = new byte[(int)file.Length];
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read))
                {
                    if (stream.Read(data, 0, data.Length) != data.Length)
                        throw new IOException("Not all data retrieved from file");
                }
                result = new CertFileItem(new X509Certificate2(data), file);
                return null;
            }
            catch (Exception exc)
            {
                result = null;
                return "Error loading certificate from file: " + exc.Message;
            }
        }

        private CertFileItem(X509Certificate2 cert, FileInfo file) : base(cert)
        {
            this._file = file;
        }
    }
}