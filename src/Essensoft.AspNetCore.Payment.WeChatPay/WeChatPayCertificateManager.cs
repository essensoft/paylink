using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayCertificateManager
    {
        private readonly ConcurrentDictionary<string, X509Certificate2> _certDic = new ConcurrentDictionary<string, X509Certificate2>();

        public bool Contains(string hash)
        {
            return _certDic.ContainsKey(hash);
        }

        public bool TryAdd(string hash, X509Certificate2 certificate)
        {
            return _certDic.TryAdd(hash, certificate);
        }

        public bool TryGet(string hash, out X509Certificate2 certificate)
        {
            return _certDic.TryGetValue(hash, out certificate);
        }
    }
}
