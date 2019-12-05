using System.Collections.Concurrent;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public class AlipayCertificateManager
    {
        /// <summary>
        /// 不同支付宝公钥证书序列号对应的公钥内容
        /// </summary>
        private readonly ConcurrentDictionary<string, string> _SN2PublicKey = new ConcurrentDictionary<string, string>();

        public bool IsEmpty => _SN2PublicKey.IsEmpty;

        public bool Contains(string sn)
        {
            return _SN2PublicKey.ContainsKey(sn);
        }

        public bool TryAdd(string sn, string publicKey)
        {
            return _SN2PublicKey.TryAdd(sn, publicKey);
        }

        public bool TryGet(string sn, out string publicKey)
        {
            return _SN2PublicKey.TryGetValue(sn, out publicKey);
        }
    }
}
