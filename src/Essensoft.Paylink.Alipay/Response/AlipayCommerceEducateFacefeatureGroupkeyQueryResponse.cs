using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureGroupkeyQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureGroupkeyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 人脸库key
        /// </summary>
        [JsonPropertyName("group_key")]
        public string GroupKey { get; set; }
    }
}
