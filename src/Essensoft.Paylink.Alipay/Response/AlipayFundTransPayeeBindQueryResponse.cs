using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransPayeeBindQueryResponse.
    /// </summary>
    public class AlipayFundTransPayeeBindQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否绑定收款账号。true：已绑定；false：未绑定
        /// </summary>
        [JsonPropertyName("bind")]
        public string Bind { get; set; }
    }
}
