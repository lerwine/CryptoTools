using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace CryptoWinForm
{
    public abstract class X509CertSelection
    {
        internal static readonly Regex NEWLINE_REGEX = new Regex("\r\n?|\n", RegexOptions.Compiled);
        private readonly X509Certificate2 _certificate;
        private string _name = null;
        private string _issuedBy = null;
        private string _serialNumber = null;
        private string _algorithm = null;
        private X509KeyUsageFlags? _keyUsages = null;
        private string _usagesDisplay = null;
        private ReadOnlyCollection<KeyValuePair<String, String>> _enhancedUsages = null;
        private ReadOnlyCollection<KeyValuePair<String, String>> _alternativeNameList = null;
        private byte[] _publicKeyBytes = null;
        private int? _publicKeyBitLength = null;
        private string _keyExchangeAlgorithm = null;
        private string _signatureAlgorithm = null;

        public X509Certificate2 Certificate { get { return _certificate; } }
        public string IssuedTo { get { return _certificate.Subject; } }
        public string Thumbprint { get { return _certificate.Thumbprint; } }
        public virtual string Name
        {
            get
            {
                if (null == _name)
                {
                    _name = _certificate.FriendlyName;
                    if (String.IsNullOrWhiteSpace(_name))
                    {
                        foreach (X509NameType t in Enum.GetValues(typeof(X509NameType)))
                        {
                            _name = _certificate.GetNameInfo(t, false);
                            if (!String.IsNullOrWhiteSpace(_name))
                                return _name;
                        }
                        _name = (AlternativeNameList.Count > 0) ? _alternativeNameList[0].Value : "";
                    }
                }
                return _name;
            }
        }
        public string IssuedBy
        {
            get
            {
                if (null == _issuedBy)
                {
                    _issuedBy = _certificate.IssuerName.Name;
                    if (String.IsNullOrEmpty(_issuedBy))
                    {
                        foreach (X509NameType t in Enum.GetValues(typeof(X509NameType)))
                        {
                            _issuedBy = _certificate.GetNameInfo(t, true);
                            if (!String.IsNullOrWhiteSpace(_issuedBy))
                                return _issuedBy;
                        }
                        if (null == (_issuedBy = _certificate.Issuer))
                            _issuedBy = "";
                    }
                }
                return _issuedBy;
            }
        }
        public string SerialNumber
        {
            get
            {
                if (null == _serialNumber && null == (_serialNumber = _certificate.GetSerialNumberString()))
                    _serialNumber = "";
                return _serialNumber;
            }
        }
        public DateTime ValidFrom { get { return _certificate.NotBefore; } }
        public DateTime ValidTo { get { return _certificate.NotAfter; } }
        public string Algorithm
        {
            get
            {
                if (null == _algorithm)
                {
                    string a = _certificate.GetKeyAlgorithm();
                    _algorithm = (String.IsNullOrWhiteSpace(a)) ? "" : (new Oid(a)).FriendlyName;
                }
                return _algorithm;
            }
        }
        public byte[] GetPublicKeyBytes()
        {
            if (null == _publicKeyBytes && null == (_publicKeyBytes = _certificate.GetPublicKey()))
                _publicKeyBytes = new byte[0];
            return _publicKeyBytes;
        }
        public string SignatureAlgorithm
        {
            get
            {
                if (null == _signatureAlgorithm)
                    FillPublicKeyInfo();
                return _signatureAlgorithm;
            }
        }
        public string KeyExchangeAlgorithm
        {
            get
            {
                if (null == _keyExchangeAlgorithm)
                    FillPublicKeyInfo();
                return _keyExchangeAlgorithm;
            }
        }
        public int PublicKeyBitLength
        {
            get
            {
                if (!_publicKeyBitLength.HasValue)
                    FillPublicKeyInfo();
                return _publicKeyBitLength.Value;
            }
        }
        public X509KeyUsageFlags KeyUsages
        {
            get
            {
                if (!_keyUsages.HasValue)
                    _keyUsages = _certificate.Extensions.OfType<X509KeyUsageExtension>().Aggregate(X509KeyUsageFlags.None, (a, e) => a | e.KeyUsages);
                return _keyUsages.Value;
            }
        }
        public string UsagesDisplay
        {
            get
            {
                if (null == _usagesDisplay)
                {
                    X509KeyUsageFlags flags = KeyUsages;
                    if (flags == X509KeyUsageFlags.None)
                    {
                        if (EnhancedUsages.Count == 0)
                            _usagesDisplay = "None";
                        else
                            _usagesDisplay = String.Join(", ", EnhancedUsages.ToArray());
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (X509KeyUsageFlags f in Enum.GetValues(typeof(X509KeyUsageFlags)))
                        {
                            if ((f & flags) != X509KeyUsageFlags.None)
                            {
                                if (sb.Length > 0)
                                    sb.Append(", ");
                                switch (f)
                                {
                                    case X509KeyUsageFlags.CrlSign:
                                        sb.Append("Sign certificate revocation list (CRL)");
                                        break;
                                    case X509KeyUsageFlags.DataEncipherment:
                                        sb.Append("Data encryption");
                                        break;
                                    case X509KeyUsageFlags.DecipherOnly:
                                        sb.Append("Decryption only");
                                        break;
                                    case X509KeyUsageFlags.DigitalSignature:
                                        sb.Append("Digital signature");
                                        break;
                                    case X509KeyUsageFlags.EncipherOnly:
                                        sb.Append("Encryption only");
                                        break;
                                    case X509KeyUsageFlags.KeyAgreement:
                                        sb.Append("Determine key agreement");
                                        break;
                                    case X509KeyUsageFlags.KeyCertSign:
                                        sb.Append("Sign certificates");
                                        break;
                                    case X509KeyUsageFlags.KeyEncipherment:
                                        sb.Append("Key encryption");
                                        break;
                                    case X509KeyUsageFlags.NonRepudiation:
                                        sb.Append("Authentication");
                                        break;
                                    default:
                                        sb.Append(Enum.GetName(typeof(X509KeyUsageFlags), f));
                                        break;
                                }
                            }
                        }
                        foreach (KeyValuePair<String, String> s in EnhancedUsages)
                            sb.Append(", ").Append(s.Value);
                        _usagesDisplay = sb.ToString();
                    }
                }
                return _usagesDisplay;
            }
        }
        public ReadOnlyCollection<KeyValuePair<String, String>> EnhancedUsages
        {
            get
            {
                if (null == _enhancedUsages)
                    _enhancedUsages = new ReadOnlyCollection<KeyValuePair<String, String>>(_certificate.Extensions.OfType<X509EnhancedKeyUsageExtension>().SelectMany(e => e.EnhancedKeyUsages.Cast<Oid>())
                        .Select(oid => new KeyValuePair<String, String>(oid.Value, (String.IsNullOrEmpty(oid.FriendlyName)) ? oid.Value : oid.FriendlyName)).ToList());
                return _enhancedUsages;


            }
        }
        public ReadOnlyCollection<KeyValuePair<String, String>> AlternativeNameList
        {
            get
            {
                if (null == _alternativeNameList)
                    _alternativeNameList = new ReadOnlyCollection<KeyValuePair<String, String>>(_certificate.Extensions.Cast<X509Extension>().Where(e => e.Oid.FriendlyName == "Subject Alternative Name")
                        .SelectMany(e => NEWLINE_REGEX.Split(new AsnEncodedData(e.Oid, e.RawData).Format(true))).Select(s => new { Index = s.IndexOf('='), Value = s })
                        .Where(a => a.Index > 0).Select(a => new KeyValuePair<string, string>(a.Value.Substring(0, a.Index).Trim(), a.Value.Substring(a.Index + 1).Trim())).ToList());
                return _alternativeNameList;
            }
        }

        protected X509CertSelection(X509Certificate2 cert)
        {
            _certificate = cert;
        }

        private void FillPublicKeyInfo()
        {
            byte[] publicKey = GetPublicKeyBytes();
            if (null != publicKey && publicKey.Length > 0)
            {
                AsymmetricAlgorithm pk;
                try { pk = _certificate.GetRSAPublicKey(); }
                catch { pk = null; }
                if (null == pk)
                {
                    try { pk = _certificate.GetECDsaPublicKey(); }
                    catch { pk = null; }
                    if (null == pk)
                        try { pk = _certificate.GetDSAPublicKey(); }
                        catch { pk = null; }
                }
                if (null != pk)
                {
                    using (pk)
                    {
                        _publicKeyBitLength = pk.KeySize;
                        _keyExchangeAlgorithm = pk.KeyExchangeAlgorithm;
                        if (String.IsNullOrWhiteSpace(_keyExchangeAlgorithm))
                            _keyExchangeAlgorithm = Algorithm;
                        _keyExchangeAlgorithm = pk.SignatureAlgorithm;
                        if (null == _signatureAlgorithm)
                            _signatureAlgorithm = "";
                    }
                    return;
                }
            }
            _publicKeyBitLength = 0;
            _keyExchangeAlgorithm = "";
            _signatureAlgorithm = "";
        }
    }
}