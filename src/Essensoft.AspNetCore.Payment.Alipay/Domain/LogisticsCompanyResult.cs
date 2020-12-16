using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LogisticsCompanyResult Data Structure.
    /// </summary>
    public class LogisticsCompanyResult : AlipayObject
    {
        /// <summary>
        /// 物流公司编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonPropertyName("logistics_name")]
        public string LogisticsName { get; set; }
    }
}
