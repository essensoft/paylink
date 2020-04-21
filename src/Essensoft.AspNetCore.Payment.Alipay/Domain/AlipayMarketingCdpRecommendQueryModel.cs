using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCdpRecommendQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCdpRecommendQueryModel : AlipayObject
    {
        /// <summary>
        /// 广告标识码
        /// </summary>
        [JsonPropertyName("ad_code")]
        public string AdCode { get; set; }

        /// <summary>
        /// 扩展信息，传json格式的字符串，包含longitude=经度；latitude=纬度；deviceId=设备标识
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 支付宝账户
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }
    }
}
