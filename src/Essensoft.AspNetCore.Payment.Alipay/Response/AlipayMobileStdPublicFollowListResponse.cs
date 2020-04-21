using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileStdPublicFollowListResponse.
    /// </summary>
    public class AlipayMobileStdPublicFollowListResponse : AlipayResponse
    {
        /// <summary>
        /// 当前组的值
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// 用户数据
        /// </summary>
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        /// <summary>
        /// 与nextUserId对应，标准Alipay UserId
        /// </summary>
        [JsonPropertyName("next_alipay_user_id")]
        public string NextAlipayUserId { get; set; }

        /// <summary>
        /// 查询分组的userid
        /// </summary>
        [JsonPropertyName("next_user_id")]
        public string NextUserId { get; set; }
    }
}
