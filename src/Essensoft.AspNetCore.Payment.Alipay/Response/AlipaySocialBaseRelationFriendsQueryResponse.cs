using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseRelationFriendsQueryResponse.
    /// </summary>
    public class AlipaySocialBaseRelationFriendsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 好友列表数据
        /// </summary>
        [JsonPropertyName("friend_list")]
        public List<FriendListVO> FriendList { get; set; }
    }
}
