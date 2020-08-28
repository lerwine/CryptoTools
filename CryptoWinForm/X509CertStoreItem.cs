using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace CryptoWinForm
{
    public class X509CertStoreItem : X509CertSelection
    {
        private readonly StoreName _storeName;
        private readonly StoreLocation _storeLocation;

        public StoreName StoreName { get { return _storeName; } }
        public StoreLocation StoreLocation { get { return _storeLocation; } }

        public X509CertStoreItem(X509Certificate2 cert, StoreName storeName, StoreLocation storeLocation) : base(cert)
        {
            _storeName = storeName;
            _storeLocation = storeLocation;
        }
    }
}