using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserValidateResponse.
    /// </summary>
    public class AlipayUserValidateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// true标识通过认证.false标识没有
        /// </summary>
        [JsonPropertyName("certified")]
        public string Certified { get; set; }

        /// <summary>
        /// 隐藏的真实姓名，如 *三(张三)
        /// </summary>
        [JsonPropertyName("real_name")]
        public string RealName { get; set; }
    }
}
