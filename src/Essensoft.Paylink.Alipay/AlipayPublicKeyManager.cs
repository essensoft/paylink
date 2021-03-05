using System.Collections.Concurrent;

namespace Essensoft.Paylink.Alipay
{
    public class AlipayPublicKeyManager
    {
        private readonly ConcurrentDictionary<string, string> _publicKeyDictionary = new();

        public bool IsEmpty => _publicKeyDictionary.IsEmpty;

        public bool ContainsKey(string sn) => _publicKeyDictionary.ContainsKey(sn);

        public bool TryAdd(string sn, string publicKey) => _publicKeyDictionary.TryAdd(sn, publicKey);

        public bool TryGetValue(string sn, out string publicKey) => _publicKeyDictionary.TryGetValue(sn, out publicKey);
    }
}
