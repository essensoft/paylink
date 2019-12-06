using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaytoolRefundRequestDetail Data Structure.
    /// </summary>
    public class PaytoolRefundRequestDetail : AlipayObject
    {
        /// <summary>
        /// 支付宝支付工具单据号，和商户支付工具单据号不能同时为空。
        /// </summary>
        [JsonPropertyName("paytool_bill_no")]
        public string PaytoolBillNo { get; set; }

        /// <summary>
        /// 商户外部支付工具单据号。和支付宝支付工具单据号不能同时为空。
        /// </summary>
        [JsonPropertyName("paytool_request_no")]
        public string PaytoolRequestNo { get; set; }

        /// <summary>
        /// 退款支付工具金额。单位为元，精确到小数点后两位，取值范围[0.01,100000000]。注：退款金额不可大于支付金额
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
