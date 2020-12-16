using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LogisticsCompanyDTO Data Structure.
    /// </summary>
    public class LogisticsCompanyDTO : AlipayObject
    {
        /// <summary>
        /// 配送公司客服电话
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 配送公司物流编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 配送公司名称
        /// </summary>
        [JsonPropertyName("logistics_name")]
        public string LogisticsName { get; set; }
    }
}
