using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAlipaycertDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAlipaycertDownloadModel : AlipayObject
    {
        /// <summary>
        /// 支付宝公钥证书序列号
        /// </summary>
        [JsonProperty("alipay_cert_sn")]
        public string AlipayCertSn { get; set; }
    }
}
