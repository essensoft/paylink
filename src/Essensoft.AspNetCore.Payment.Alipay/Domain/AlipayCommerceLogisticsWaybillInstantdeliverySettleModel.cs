using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillInstantdeliverySettleModel Data Structure.
    /// </summary>
    public class AlipayCommerceLogisticsWaybillInstantdeliverySettleModel : AlipayObject
    {
        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 结算请求流水号
        /// </summary>
        [JsonPropertyName("out_settle_request_no")]
        public string OutSettleRequestNo { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        [JsonPropertyName("waybill_no")]
        public string WaybillNo { get; set; }

        /// <summary>
        /// 即时配送运单状态
        /// </summary>
        [JsonPropertyName("waybill_status")]
        public string WaybillStatus { get; set; }
    }
}
