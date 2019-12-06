using System.Text.Json.Serialization;

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
        [JsonPropertyName("available_points")]
        public string AvailablePoints { get; set; }

        /// <summary>
        /// 冻结集点
        /// </summary>
        [JsonPropertyName("freezed_points")]
        public string FreezedPoints { get; set; }

        /// <summary>
        /// 累计集点
        /// </summary>
        [JsonPropertyName("total_points")]
        public string TotalPoints { get; set; }
    }
}
