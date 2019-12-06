using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GroupSetting Data Structure.
    /// </summary>
    public class GroupSetting : AlipayObject
    {
        /// <summary>
        /// 群名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 是否开放群成员邀请
        /// </summary>
        [JsonPropertyName("is_openinv")]
        public bool IsOpeninv { get; set; }

        /// <summary>
        /// 群公告
        /// </summary>
        [JsonPropertyName("public_notice")]
        public string PublicNotice { get; set; }
    }
}
