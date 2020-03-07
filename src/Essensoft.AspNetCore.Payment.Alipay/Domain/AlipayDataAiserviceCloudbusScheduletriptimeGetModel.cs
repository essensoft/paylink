using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletriptimeGetModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletriptimeGetModel : AlipayObject
    {
        /// <summary>
        /// mean/max/pert_95
        /// </summary>
        [JsonPropertyName("aggregate_type")]
        public string AggregateType { get; set; }

        /// <summary>
        /// 接口版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 配制id
        /// </summary>
        [JsonPropertyName("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 公交公司id
        /// </summary>
        [JsonPropertyName("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 5/10/15/20/30/60   Long 时间粒度(单位分钟)
        /// </summary>
        [JsonPropertyName("time_span")]
        public long TimeSpan { get; set; }
    }
}
