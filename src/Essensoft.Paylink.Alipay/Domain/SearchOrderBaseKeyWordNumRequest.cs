using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchOrderBaseKeyWordNumRequest Data Structure.
    /// </summary>
    public class SearchOrderBaseKeyWordNumRequest : AlipayObject
    {
        /// <summary>
        /// appid
        /// </summary>
        [JsonPropertyName("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [JsonPropertyName("spec_code")]
        public string SpecCode { get; set; }
    }
}
