using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserFamilyRelationValidQueryModel Data Structure.
    /// </summary>
    public class AlipayUserFamilyRelationValidQueryModel : AlipayObject
    {
        /// <summary>
        /// 是否需要强一致查询，无特殊要求传false即可。
        /// </summary>
        [JsonPropertyName("strict")]
        public bool Strict { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
