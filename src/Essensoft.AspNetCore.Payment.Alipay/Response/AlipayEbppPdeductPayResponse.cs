using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppPdeductPayResponse.
    /// </summary>
    public class AlipayEbppPdeductPayResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [JsonProperty("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        [JsonProperty("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 商户代扣业务流水
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单支付状态。  0：未知  1：成功  2：失败
        /// </summary>
        [JsonProperty("result_status")]
        public string ResultStatus { get; set; }
    }
}
