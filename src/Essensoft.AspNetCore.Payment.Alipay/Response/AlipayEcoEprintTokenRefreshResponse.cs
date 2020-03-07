using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEprintTokenRefreshResponse.
    /// </summary>
    public class AlipayEcoEprintTokenRefreshResponse : AlipayResponse
    {
        /// <summary>
        /// 访问易联云凭证
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 预计过期时间秒
        /// </summary>
        [JsonPropertyName("expected_expires_in")]
        public string ExpectedExpiresIn { get; set; }

        /// <summary>
        /// 过期时长秒
        /// </summary>
        [JsonPropertyName("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 4004578279
        /// </summary>
        [JsonPropertyName("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 更新AccessToken凭证
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
