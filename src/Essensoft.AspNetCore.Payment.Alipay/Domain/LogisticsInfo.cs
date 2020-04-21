using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LogisticsInfo Data Structure.
    /// </summary>
    public class LogisticsInfo : AlipayObject
    {
        /// <summary>
        /// 物流公司code
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonPropertyName("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("logistics_no")]
        public string LogisticsNo { get; set; }
    }
}
