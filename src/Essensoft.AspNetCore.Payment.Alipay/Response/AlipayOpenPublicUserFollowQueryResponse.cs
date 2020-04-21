using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicUserFollowQueryResponse.
    /// </summary>
    public class AlipayOpenPublicUserFollowQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户是否关注，T代表已关注，F代表未关注
        /// </summary>
        [JsonPropertyName("is_follow")]
        public string IsFollow { get; set; }
    }
}
