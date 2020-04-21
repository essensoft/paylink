using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicAuthGettokenResponse.
    /// </summary>
    public class AlipayMobilePublicAuthGettokenResponse : AlipayResponse
    {
        /// <summary>
        /// 返回码。处理成功：200；处理失败：请参考返回码。
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 支付宝返回的处理结果说明，请参考返回码
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }

        /// <summary>
        /// 跳转到授权页面需要的Token
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
