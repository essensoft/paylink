using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// GovDocRequest Data Structure.
    /// </summary>
    public class GovDocRequest : AlipayObject
    {
        /// <summary>
        /// 请求
        /// </summary>
        [JsonPropertyName("gov_doc_request")]
        public string GovDocRequest_ { get; set; }

        /// <summary>
        /// 12121
        /// </summary>
        [JsonPropertyName("test")]
        public string Test { get; set; }
    }
}
