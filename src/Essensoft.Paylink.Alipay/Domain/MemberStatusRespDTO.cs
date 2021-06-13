using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MemberStatusRespDTO Data Structure.
    /// </summary>
    public class MemberStatusRespDTO : AlipayObject
    {
        /// <summary>
        /// 员工当前状态： 邀请中（PROCESSING）、正常（NORMAL）、不在企业中（OUT）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户支付宝2088会员号
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
