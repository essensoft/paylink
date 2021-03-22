using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CommunityRelationshipExtendField Data Structure.
    /// </summary>
    public class CommunityRelationshipExtendField : AlipayObject
    {
        /// <summary>
        /// 是否需要跳转外部链接查询户号，1-是，0-否。默认为否
        /// </summary>
        [JsonPropertyName("external_billkey_query_flag")]
        public string ExternalBillkeyQueryFlag { get; set; }
    }
}
