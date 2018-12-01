using Essensoft.AspNetCore.Payment.Security;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Crypto;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayOptions
    {
        internal ICipherParameters PublicKey;

        private string rsaPublicKey;

        /// <summary>
        /// 应用账号(公众账号ID/小程序ID/企业号CorpId)
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// API秘钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// RSA公钥 企业付款到银行卡
        /// </summary>
        public string RsaPublicKey
        {
            get => rsaPublicKey;
            set
            {
                rsaPublicKey = value;
                if (!string.IsNullOrEmpty(rsaPublicKey))
                {
                    PublicKey = RSAUtilities.GetPublicKeyParameterFormAsn1PublicKey(rsaPublicKey);
                }
            }
        }

        /// <summary>
        /// 日志等级
        /// </summary>
        public LogLevel LogLevel { get; set; } = LogLevel.Information;
    }
}
