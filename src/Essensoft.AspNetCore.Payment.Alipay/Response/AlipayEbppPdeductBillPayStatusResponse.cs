using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppPdeductBillPayStatusResponse.
    /// </summary>
    public class AlipayEbppPdeductBillPayStatusResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝协议流水
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝流billNo
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单的结果码
        /// </summary>
        [JsonPropertyName("order_result_code")]
        public string OrderResultCode { get; set; }

        /// <summary>
        /// 订单的结果描述
        /// </summary>
        [JsonPropertyName("order_result_msg")]
        public string OrderResultMsg { get; set; }

        /// <summary>
        /// 外部订单流水
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单支付状态。  0：未知状态。  1：支付成功。  2：支付失败。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
