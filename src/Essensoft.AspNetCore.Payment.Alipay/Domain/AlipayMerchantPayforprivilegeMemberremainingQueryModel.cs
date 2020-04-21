using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeMemberremainingQueryModel Data Structure.
    /// </summary>
    public class AlipayMerchantPayforprivilegeMemberremainingQueryModel : AlipayObject
    {
        /// <summary>
        /// 该字段已废弃，请通过user_id查询
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
