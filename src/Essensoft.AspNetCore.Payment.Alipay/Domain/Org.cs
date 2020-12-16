using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Org Data Structure.
    /// </summary>
    public class Org : AlipayObject
    {
        /// <summary>
        /// 企业证件号
        /// </summary>
        [JsonPropertyName("org_id_number")]
        public string OrgIdNumber { get; set; }

        /// <summary>
        /// 企业证件类型，（证件号不为空时必填，详见企业证件类型）
        /// </summary>
        [JsonPropertyName("org_id_type")]
        public string OrgIdType { get; set; }

        /// <summary>
        /// 法定代表人证件号
        /// </summary>
        [JsonPropertyName("org_legal_id_number")]
        public string OrgLegalIdNumber { get; set; }

        /// <summary>
        /// 法定代表人证件类型
        /// </summary>
        [JsonPropertyName("org_legal_id_type")]
        public string OrgLegalIdType { get; set; }

        /// <summary>
        /// 法定代表人名称
        /// </summary>
        [JsonPropertyName("org_legal_name")]
        public string OrgLegalName { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonPropertyName("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 企业唯一标识：可传入平台机构id、企业证件号、企业邮箱等（个人用户与企业的唯一标识不可重复）
        /// </summary>
        [JsonPropertyName("third_party_user_id")]
        public string ThirdPartyUserId { get; set; }
    }
}
