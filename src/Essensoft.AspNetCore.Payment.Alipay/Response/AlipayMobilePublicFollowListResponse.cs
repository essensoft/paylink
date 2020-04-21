using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicFollowListResponse.
    /// </summary>
    public class AlipayMobilePublicFollowListResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果码，如200，标识成功
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

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
