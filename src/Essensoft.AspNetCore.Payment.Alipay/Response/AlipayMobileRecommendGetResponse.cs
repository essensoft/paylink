using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileRecommendGetResponse.
    /// </summary>
    public class AlipayMobileRecommendGetResponse : AlipayResponse
    {
        /// <summary>
        /// 推荐结果的扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 推荐结果集合, json数组对象, 每个元素至少包含entity_id的属性,其他属性由推荐方案决定。
        /// </summary>
        [JsonProperty("items")]
        [XmlElement("items")]
        public string Items { get; set; }

        /// <summary>
        /// 本次推荐的唯一标识
        /// </summary>
        [JsonProperty("recommend_id")]
        [XmlElement("recommend_id")]
        public string RecommendId { get; set; }
    }
}
