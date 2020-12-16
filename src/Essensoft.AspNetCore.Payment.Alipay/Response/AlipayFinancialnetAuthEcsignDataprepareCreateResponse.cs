using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignDataprepareCreateResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignDataprepareCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 跳转类型
        /// </summary>
        [JsonPropertyName("jump_type")]
        public string JumpType { get; set; }

        /// <summary>
        /// 跳转至小程序的URL
        /// </summary>
        [JsonPropertyName("jump_url")]
        public string JumpUrl { get; set; }
    }
}
