using System;
using System.Security.Cryptography.X509Certificates;

namespace Essensoft.Paylink.WeChatPay.V3
{
    public class WeChatPayPlatformCertificate
    {
        /// <summary>
        /// 序列号
        /// </summary>
        public string SerialNo { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        public DateTime EffectiveTime { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        public DateTime ExpireTime { get; set; }

        /// <summary>
        /// 证书
        /// </summary>
        public X509Certificate2 Certificate;
    }
}
