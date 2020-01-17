using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusTransitItem Data Structure.
    /// </summary>
    public class CloudbusTransitItem : AlipayObject
    {
        /// <summary>
        /// 月份
        /// </summary>
        [JsonPropertyName("month")]
        public string Month { get; set; }

        /// <summary>
        /// 客流走廊类型，枚举  0 公共出行 1 不含地铁 2 现有线网
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// oss访问地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
