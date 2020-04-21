using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeBuyerCreditCancelModel Data Structure.
    /// </summary>
    public class AlipayTradeBuyerCreditCancelModel : AlipayObject
    {
        /// <summary>
        /// 卖家授信拆分给买家的额度  单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("grant_credit_quota")]
        public string GrantCreditQuota { get; set; }

        /// <summary>
        /// 本次授信拆分的操作单号
        /// </summary>
        [JsonPropertyName("grant_operation_no")]
        public string GrantOperationNo { get; set; }
    }
}
