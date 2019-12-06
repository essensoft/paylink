using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderLogisticsInformationRequest Data Structure.
    /// </summary>
    public class OrderLogisticsInformationRequest : AlipayObject
    {
        /// <summary>
        /// 物流公司编号。  物流公司编号值请查看产品文档  注：该值为空时，有可能匹配不到物流信息。若有则必传
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
