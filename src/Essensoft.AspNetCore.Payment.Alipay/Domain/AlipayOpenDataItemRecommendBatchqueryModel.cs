using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenDataItemRecommendBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenDataItemRecommendBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 国家地区行政编码
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 展位ID,支持批量咨询，多个展位用逗号分隔
        /// </summary>
        [JsonPropertyName("position_ids")]
        public string PositionIds { get; set; }

        /// <summary>
        /// 用户的支付宝UID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
