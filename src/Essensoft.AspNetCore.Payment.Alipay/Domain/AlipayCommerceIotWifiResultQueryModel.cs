using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotWifiResultQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotWifiResultQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一标识，设备id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }
    }
}
