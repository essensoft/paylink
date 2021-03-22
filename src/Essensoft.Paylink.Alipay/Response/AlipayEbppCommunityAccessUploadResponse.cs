using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppCommunityAccessUploadResponse.
    /// </summary>
    public class AlipayEbppCommunityAccessUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 脱敏后的手机号码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 开门原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 脱敏后的用户名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
