using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneProdDeputyPaymentBillDetail Data Structure.
    /// </summary>
    public class SceneProdDeputyPaymentBillDetail : AlipayObject
    {
        /// <summary>
        /// 代客还款的网商银行结算户信息
        /// </summary>
        [JsonPropertyName("deputy_account")]
        public string DeputyAccount { get; set; }

        /// <summary>
        /// 代客还款操作类型，VALID 代客还款， INVALID 取消代客还款
        /// </summary>
        [JsonPropertyName("deputy_type")]
        public string DeputyType { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [JsonPropertyName("term")]
        public string Term { get; set; }
    }
}
