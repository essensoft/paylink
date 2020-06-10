using System.Text;

namespace Essensoft.AspNetCore.Payment.Security
{
    internal static class InternalEncoding
    {
        static InternalEncoding()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public static Encoding GetEncoding(string name)
        {
            return Encoding.GetEncoding(name);
        }

        public static Encoding GetEncoding(int codepage)
        {
            return Encoding.GetEncoding(codepage);
        }
    }
}
