using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAlipaycertDownloadModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAlipaycertDownloadModel : AlipayObject
    {
        /// <summary>
        /// 支付宝公钥证书序列号
        /// </summary>
        [JsonPropertyName("alipay_cert_sn")]
        public string AlipayCertSn { get; set; }
    }
}
