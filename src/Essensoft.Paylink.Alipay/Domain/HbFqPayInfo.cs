using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HbFqPayInfo Data Structure.
    /// </summary>
    public class HbFqPayInfo : AlipayObject
    {
        /// <summary>
        /// 用户使用花呗分期支付的分期数
        /// </summary>
        [JsonPropertyName("user_install_num")]
        public string UserInstallNum { get; set; }
    }
}
