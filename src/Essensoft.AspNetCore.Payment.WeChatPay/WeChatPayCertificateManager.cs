using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayCertificateManager
    {
        private readonly ConcurrentDictionary<string, X509Certificate2> _certificateDictionary = new ConcurrentDictionary<string, X509Certificate2>();

        public bool ContainsKey(string hash) => _certificateDictionary.ContainsKey(hash);

        public bool TryAdd(string hash, X509Certificate2 certificate) => _certificateDictionary.TryAdd(hash, certificate);

        public bool TryGetValue(string hash, out X509Certificate2 certificate) => _certificateDictionary.TryGetValue(hash, out certificate);
    }
}
