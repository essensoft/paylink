using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubAccountInfoDTO Data Structure.
    /// </summary>
    public class SubAccountInfoDTO : AlipayObject
    {
        /// <summary>
        /// 开户状态 ACCEPTED: 受理成功状态，尚未发起开户 OPENING: 子户开通中，等待开户结果 SUCCESS: 子户开通成功状态，子户信息可查询 OPEN_FAILED: 开户失败，需重新发起
        /// </summary>
        [JsonPropertyName("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 子户以及其绑定信息 只有当状态为SUCCESS时该参数才存在
        /// </summary>
        [JsonPropertyName("sub_account_info")]
        public SubAccountAndBindDTO SubAccountInfo { get; set; }
    }
}
