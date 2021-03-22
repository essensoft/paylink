using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicUserFollowQueryResponse.
    /// </summary>
    public class AlipayOpenPublicUserFollowQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户是否关注。枚举值如下： *T：代表已关注。 *F：代表未关注。
        /// </summary>
        [JsonPropertyName("is_follow")]
        public string IsFollow { get; set; }
    }
}
