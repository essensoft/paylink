using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExternalSyncRequest Data Structure.
    /// </summary>
    public class ExternalSyncRequest : AlipayObject
    {
        /// <summary>
        /// 支付宝账单ID
        /// </summary>
        [JsonPropertyName("alipay_bill_id")]
        public string AlipayBillId { get; set; }

        /// <summary>
        /// 外部账单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
