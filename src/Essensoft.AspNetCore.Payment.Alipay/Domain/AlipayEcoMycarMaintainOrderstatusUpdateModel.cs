using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainOrderstatusUpdateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarMaintainOrderstatusUpdateModel : AlipayObject
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("ext_param")]
        public MaintainOrderStatusExtParams ExtParam { get; set; }

        /// <summary>
        /// 洗车-015；保养-016；4S-020
        /// </summary>
        [JsonPropertyName("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 55-已核销；7-已出库；8-已收货
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 废弃
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
