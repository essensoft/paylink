using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceSportsGamesFriendlistQueryResponse.
    /// </summary>
    public class AlipayCommerceSportsGamesFriendlistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 好友信息集合
        /// </summary>
        [JsonPropertyName("friend_list")]
        public List<FriendVO> FriendList { get; set; }

        /// <summary>
        /// 用户open_id
        /// </summary>
        [JsonPropertyName("self_open_id")]
        public string SelfOpenId { get; set; }
    }
}
