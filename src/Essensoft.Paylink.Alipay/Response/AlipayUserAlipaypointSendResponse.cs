using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserAlipaypointSendResponse.
    /// </summary>
    public class AlipayUserAlipaypointSendResponse : AlipayResponse
    {
        /// <summary>
        /// 发放记录号
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }
    }
}
