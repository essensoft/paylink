using System.Collections.Concurrent;
using System.Threading.Tasks;
using Essensoft.Paylink.Alipay.Utility;

namespace Essensoft.Paylink.Alipay
{
    public class AlipayPublicKeyManager
    {
        private readonly ConcurrentDictionary<string, string> _publicKeys = new();

        /// <summary>
        /// 获取支付宝公钥证书
        /// </summary>
        /// <param name="client">Alipay 客户端</param>
        /// <param name="options">配置选项</param>
        /// <param name="certSN">证书序列号</param>
        /// <returns>支付宝公钥证书</returns>
        public async Task<string> GetAlipayPublicKeyAsync(IAlipayClient client, AlipayOptions options, string certSN)
        {
            // 为空时添加本地支付宝公钥证书密钥
            if (_publicKeys.IsEmpty)
            {
                _publicKeys.TryAdd(options.AlipayPublicCertSN, options.AlipayPublicKey);
            }

            // 如果响应的支付宝公钥证书序号已经缓存过，则直接使用缓存的公钥
            if (_publicKeys.TryGetValue(certSN, out var publicKey))
            {
                return publicKey;
            }

            // 否则重新下载新的支付宝公钥证书并更新缓存
            var request = new AlipayOpenAppAlipaycertDownloadRequest
            {
                BizContent = @"{""alipay_cert_sn"":""" + certSN + "\"}"
            };

            var response = await client.CertificateExecuteAsync(request, options);
            if (response.IsError)
            {
                throw new AlipayException("支付宝公钥证书校验失败，请确认是否为支付宝签发的有效公钥证书");
            }

            if (!AlipayCertUtil.IsTrusted(response.AlipayCertContent, options.AlipayRootCert))
            {
                throw new AlipayException("支付宝公钥证书校验失败，请确认是否为支付宝签发的有效公钥证书");
            }

            var alipayCert = AlipayCertUtil.Parse(response.AlipayCertContent);
            var alipayCertSN = AlipayCertUtil.GetCertSN(alipayCert);
            var alipayCertPublicKey = AlipayCertUtil.GetCertPublicKey(alipayCert);

            _publicKeys.TryAdd(alipayCertSN, alipayCertPublicKey);

            return alipayCertPublicKey;
        }
    }
}
