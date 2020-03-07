using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplyApplyCreateResponse.
    /// </summary>
    public class MybankCreditLoanapplyApplyCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单编号，展示给客户，无业务意义
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 客户在网商银行的角色ID
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 子申请单号，唯一标识一笔申请，业务使用
        /// </summary>
        [JsonPropertyName("sub_apply_no")]
        public string SubApplyNo { get; set; }
    }
}
