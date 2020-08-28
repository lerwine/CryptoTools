using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CryptoWinForm
{
    public class ParsedCertItem : X509CertSelection
    {
        public const string BEGIN_CERTIFICATE_TEXT = "-----BEGIN CERTIFICATE-----";
        private const int BEGIN_CERTIFICATE_LENGTH = 27;
        public const string END_CERTIFICATE_TEXT = "-----END CERTIFICATE-----";
        private string _base64Text;

        public string Base64Text { get => _base64Text; }

        public static ParseResult TryCreate(string base64Text, out ParsedCertItem result)
        {
            if (null == base64Text)
            {
                result = null;
                return ParseResult.NoData;
            }
            int i = base64Text.IndexOf(BEGIN_CERTIFICATE_TEXT);
            if (i > 0)
            {
                base64Text = base64Text.Substring(i + BEGIN_CERTIFICATE_LENGTH);
                i = base64Text.IndexOf(END_CERTIFICATE_TEXT);
                if (i > 0)
                    base64Text = base64Text.Substring(0, i);
            }
            if ((base64Text = base64Text.Trim()).Length == 0)
            {
                result = null;
                return ParseResult.NoData;
            }
            byte[] data;
            try
            {
                data = Convert.FromBase64String(base64Text);
            }
            catch
            {
                result = null;
                return ParseResult.Base64DecodeError;
            }
            try { result = new ParsedCertItem(new X509Certificate2(data), base64Text); }
            catch
            {
                result = null;
                return ParseResult.CertificateLoadErr;
            }
            return ParseResult.Success;
        }
        private ParsedCertItem(X509Certificate2 cert, string base64Text) : base(cert)
        {
            _base64Text = base64Text;
        }

        public enum ParseResult
        {
            Success,
            NoData,
            Base64DecodeError,
            CertificateLoadErr
        }
    }
}