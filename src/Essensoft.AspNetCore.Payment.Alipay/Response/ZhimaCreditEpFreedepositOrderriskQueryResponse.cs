using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpFreedepositOrderriskQueryResponse.
    /// </summary>
    public class ZhimaCreditEpFreedepositOrderriskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 风控结果
        /// </summary>
        [JsonPropertyName("decision")]
        public string Decision { get; set; }

        /// <summary>
        /// 芝麻业务流水号
        /// </summary>
        [JsonPropertyName("lease_order_no")]
        public string LeaseOrderNo { get; set; }

        /// <summary>
        /// 商户业务流水号，请确保每次业务唯一
        /// </summary>
        [JsonPropertyName("merchant_lease_order_no")]
        public string MerchantLeaseOrderNo { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }
    }
}
