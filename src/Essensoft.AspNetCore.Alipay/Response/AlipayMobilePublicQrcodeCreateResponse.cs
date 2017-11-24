using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicQrcodeCreateResponse.
    /// </summary>
    public class AlipayMobilePublicQrcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果码，如200，标识成功
        /// </summary>
        [JsonProperty("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonProperty("code_img")]
        public string CodeImg { get; set; }

        /// <summary>
        /// 码过期时间，单位：秒
        /// </summary>
        [JsonProperty("expire_second")]
        public long ExpireSecond { get; set; }

        /// <summary>
        /// 结果吗描述信息
        /// </summary>
        [JsonProperty("msg")]
        public new string Msg { get; set; }
    }
}
