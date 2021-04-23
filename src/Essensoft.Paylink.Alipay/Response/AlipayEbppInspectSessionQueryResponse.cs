using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInspectSessionQueryResponse.
    /// </summary>
    public class AlipayEbppInspectSessionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 登录ID
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
