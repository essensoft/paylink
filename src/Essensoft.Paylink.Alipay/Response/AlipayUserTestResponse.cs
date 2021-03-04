using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserTestResponse.
    /// </summary>
    public class AlipayUserTestResponse : AlipayResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [JsonPropertyName("ret1")]
        public string Ret1 { get; set; }
    }
}
