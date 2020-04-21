using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGnoticeModifyModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseChatGnoticeModifyModel : AlipayObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群公告
        /// </summary>
        [JsonPropertyName("group_notice")]
        public string GroupNotice { get; set; }
    }
}
