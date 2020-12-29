using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMemberQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinCustomerMemberQueryModel : AlipayObject
    {
        /// <summary>
        /// 指定业务线
        /// </summary>
        [JsonPropertyName("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// DID, IP_ID, IP_ROLE_ID
        /// </summary>
        [JsonPropertyName("map_id_type")]
        public string MapIdType { get; set; }

        /// <summary>
        /// 映射id
        /// </summary>
        [JsonPropertyName("map_id_value")]
        public string MapIdValue { get; set; }

        /// <summary>
        /// 会员ID
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 会员角色
        /// </summary>
        [JsonPropertyName("member_role_type")]
        public string MemberRoleType { get; set; }
    }
}
