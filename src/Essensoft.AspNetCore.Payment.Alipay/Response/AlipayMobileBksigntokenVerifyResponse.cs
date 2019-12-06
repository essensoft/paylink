using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileBksigntokenVerifyResponse.
    /// </summary>
    public class AlipayMobileBksigntokenVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回值创建时间
        /// </summary>
        [JsonPropertyName("createtimestamp")]
        public string Createtimestamp { get; set; }

        /// <summary>
        /// 返回值logonId
        /// </summary>
        [JsonPropertyName("loginid")]
        public string Loginid { get; set; }

        /// <summary>
        /// 结果说明
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 结果状态码
        /// </summary>
        [JsonPropertyName("resultcode")]
        public long Resultcode { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 返回值userId
        /// </summary>
        [JsonPropertyName("userid")]
        public string Userid { get; set; }
    }
}
