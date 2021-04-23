using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CateInfo Data Structure.
    /// </summary>
    public class CateInfo : AlipayObject
    {
        /// <summary>
        /// 类目code
        /// </summary>
        [JsonPropertyName("cate_code")]
        public string CateCode { get; set; }

        /// <summary>
        /// 学段code
        /// </summary>
        [JsonPropertyName("stage_code")]
        public string StageCode { get; set; }
    }
}
