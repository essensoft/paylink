using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsOrderIstdcancelPreconsultModel Data Structure.
    /// </summary>
    public class AlipayCommerceLogisticsOrderIstdcancelPreconsultModel : AlipayObject
    {
        /// <summary>
        /// 取消原因，取消原因id为i_6时必填
        /// </summary>
        [JsonPropertyName("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 取消原因id
        /// </summary>
        [JsonPropertyName("cancel_reason_id")]
        public string CancelReasonId { get; set; }

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
        /// 商家订单号，与order_no不能同时为空
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        [JsonPropertyName("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
