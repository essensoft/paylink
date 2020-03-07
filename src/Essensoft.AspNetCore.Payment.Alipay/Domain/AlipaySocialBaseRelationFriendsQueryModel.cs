using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseRelationFriendsQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseRelationFriendsQueryModel : AlipayObject
    {
        /// <summary>
        /// 获取类型。1=获取双向好友   2=获取双向+单向好友
        /// </summary>
        [JsonPropertyName("get_type")]
        public new long GetType { get; set; }

        /// <summary>
        /// 好友列表中是否返回自己， true=返回   false=不返回    默认false
        /// </summary>
        [JsonPropertyName("include_self")]
        public bool IncludeSelf { get; set; }
    }
}
