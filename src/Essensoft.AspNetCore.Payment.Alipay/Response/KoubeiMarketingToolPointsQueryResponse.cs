using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingToolPointsQueryResponse.
    /// </summary>
    public class KoubeiMarketingToolPointsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可用集点
        /// </summary>
        [JsonProperty("available_points")]
        [XmlElement("available_points")]
        public string AvailablePoints { get; set; }

        /// <summary>
        /// 冻结集点
        /// </summary>
        [JsonProperty("freezed_points")]
        [XmlElement("freezed_points")]
        public string FreezedPoints { get; set; }

        /// <summary>
        /// 累计集点
        /// </summary>
        [JsonProperty("total_points")]
        [XmlElement("total_points")]
        public string TotalPoints { get; set; }
    }
}
