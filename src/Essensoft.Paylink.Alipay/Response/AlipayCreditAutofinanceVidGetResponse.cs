using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceVidGetResponse.
    /// </summary>
    public class AlipayCreditAutofinanceVidGetResponse : AlipayResponse
    {
        /// <summary>
        /// 核身VID
        /// </summary>
        [JsonPropertyName("verifyid")]
        public string Verifyid { get; set; }
    }
}
