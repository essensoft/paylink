using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingEncodeShortlinkCreateResponse.
    /// </summary>
    public class AlipayMarketingEncodeShortlinkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 将长连接改写成短连接，改写成功后的短连接地址
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
