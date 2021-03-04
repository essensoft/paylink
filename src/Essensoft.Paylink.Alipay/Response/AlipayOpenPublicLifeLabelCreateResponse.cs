using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLifeLabelCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }
    }
}
