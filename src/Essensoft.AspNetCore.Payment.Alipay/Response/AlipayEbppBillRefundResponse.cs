using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppBillRefundResponse.
    /// </summary>
    public class AlipayEbppBillRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 回传支付宝流水号。
        /// </summary>
        [JsonPropertyName("alipay_bill_no")]
        public string AlipayBillNo { get; set; }

        /// <summary>
        /// 扩展字段，一系列键值对，示例只是个形式，具体的Key-Value需要根据具体业务另行约定。
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 回传ISV流水号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// ACCEPTED：退款请求被接受  REJECTED：退款请求被驳回  本接口的业务逻辑具备幂等性，一旦拿到确定的结果ACCEPTED/REJECTED，再重试是没有意义的。
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
