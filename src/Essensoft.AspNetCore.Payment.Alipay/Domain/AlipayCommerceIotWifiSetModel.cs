using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotWifiSetModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotWifiSetModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 设置wifi
        /// </summary>
        [JsonPropertyName("pwd")]
        public string Pwd { get; set; }

        /// <summary>
        /// wifi名称
        /// </summary>
        [JsonPropertyName("ssid")]
        public string Ssid { get; set; }
    }
}
