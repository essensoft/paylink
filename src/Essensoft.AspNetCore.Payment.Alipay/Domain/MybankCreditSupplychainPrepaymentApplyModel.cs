using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainPrepaymentApplyModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainPrepaymentApplyModel : AlipayObject
    {
        /// <summary>
        /// 买家身份信息。
        /// </summary>
        [JsonPropertyName("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 贷款支付金额，单位人民币元。
        /// </summary>
        [JsonPropertyName("loan_pay_amount")]
        public string LoanPayAmount { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 接口幂等字段，相同requestId请求系统默认认为是相同的请求。此处requestId要求的格式为"{机构IpRoleId}_{机构生成的唯一请求ID}"
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 客户自付金额，一般为订单首付，单位人民币元。
        /// </summary>
        [JsonPropertyName("self_pay_amount")]
        public string SelfPayAmount { get; set; }
    }
}
