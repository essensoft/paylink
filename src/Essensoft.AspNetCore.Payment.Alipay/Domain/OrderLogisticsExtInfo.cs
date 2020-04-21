using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderLogisticsExtInfo Data Structure.
    /// </summary>
    public class OrderLogisticsExtInfo : AlipayObject
    {
        /// <summary>
        /// 服务结束时间，格式为yyyy-MM-dd HH:mm（到分）
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 服务开始时间，格式为yyyy-MM-dd HH:mm（到分）
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }
    }
}
