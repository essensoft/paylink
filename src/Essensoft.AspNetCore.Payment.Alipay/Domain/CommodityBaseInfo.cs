using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommodityBaseInfo Data Structure.
    /// </summary>
    public class CommodityBaseInfo : AlipayObject
    {
        /// <summary>
        /// 服务logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 服务备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [JsonPropertyName("service_url")]
        public string ServiceUrl { get; set; }
    }
}
