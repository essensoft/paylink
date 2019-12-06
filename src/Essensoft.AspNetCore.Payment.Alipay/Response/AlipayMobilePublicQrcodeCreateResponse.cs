using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicQrcodeCreateResponse.
    /// </summary>
    public class AlipayMobilePublicQrcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果码，如200，标识成功
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonPropertyName("code_img")]
        public string CodeImg { get; set; }

        /// <summary>
        /// 码过期时间，单位：秒
        /// </summary>
        [JsonPropertyName("expire_second")]
        public long ExpireSecond { get; set; }

        /// <summary>
        /// 结果吗描述信息
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }
    }
}
