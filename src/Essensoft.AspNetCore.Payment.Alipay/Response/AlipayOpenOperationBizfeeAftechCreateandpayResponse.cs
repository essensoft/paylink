using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechCreateandpayResponse.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechCreateandpayResponse : AlipayResponse
    {
        /// <summary>
        /// 费用订单号
        /// </summary>
        [JsonPropertyName("fee_order_no")]
        public string FeeOrderNo { get; set; }

        /// <summary>
        /// 动账支付时间
        /// </summary>
        [JsonPropertyName("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonPropertyName("result_message")]
        public string ResultMessage { get; set; }
    }
}
