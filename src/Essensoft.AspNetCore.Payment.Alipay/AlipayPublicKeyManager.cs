using System.Collections.Concurrent;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public class AlipayPublicKeyManager
    {
        private readonly ConcurrentDictionary<string, string> _SNPublicKeyDictionary = new ConcurrentDictionary<string, string>();

        public bool IsEmpty => _SNPublicKeyDictionary.IsEmpty;

        public bool ContainsKey(string sn) => _SNPublicKeyDictionary.ContainsKey(sn);

        public bool TryAdd(string sn, string publicKey) => _SNPublicKeyDictionary.TryAdd(sn, publicKey);

        public bool TryGetValue(string sn, out string publicKey) => _SNPublicKeyDictionary.TryGetValue(sn, out publicKey);
    }
}
