using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeSingletripdurationQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeSingletripdurationQueryModel : AlipayObject
    {
        /// <summary>
        /// 聚合方式（MIN、MAX、MEAN、PERCENTILE_95）
        /// </summary>
        [JsonPropertyName("aggregate_type")]
        public string AggregateType { get; set; }

        /// <summary>
        /// 城市代码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交业主ID
        /// </summary>
        [JsonPropertyName("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 线路方向（UP-上行，DOWN-下行）
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值。单程时间查询接口algo_date_list参数必填
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路ID，同一条线路的不同方向该值不同
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路Key，同一条线路的不同方向该值相同
        /// </summary>
        [JsonPropertyName("line_key")]
        public string LineKey { get; set; }

        /// <summary>
        /// 请求ID，唯一标识一次请求，由调用方自行确保唯一性
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 聚合时间粒度，单位：分钟，只支持：5、10、15、20、30、60
        /// </summary>
        [JsonPropertyName("time_span")]
        public long TimeSpan { get; set; }
    }
}
