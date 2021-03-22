using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PromotePageDetail Data Structure.
    /// </summary>
    public class PromotePageDetail : AlipayObject
    {
        /// <summary>
        /// 推广页创建时间，格式：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 推广页id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 推广页名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 推广留资schema
        /// </summary>
        [JsonPropertyName("property_list")]
        public List<PromotePageProperty> PropertyList { get; set; }

        /// <summary>
        /// 推广页类型：COLLECT_INFO -  普通留资；TRADE - 交易留资
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
