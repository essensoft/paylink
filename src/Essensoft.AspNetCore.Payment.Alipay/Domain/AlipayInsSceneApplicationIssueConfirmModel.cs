using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationIssueConfirmModel Data Structure.
    /// </summary>
    public class AlipayInsSceneApplicationIssueConfirmModel : AlipayObject
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [JsonPropertyName("application_no")]
        public string ApplicationNo { get; set; }

        /// <summary>
        /// payToIssue:支付后出单 issue:直接出单
        /// </summary>
        [JsonPropertyName("issue_type")]
        public string IssueType { get; set; }
    }
}
