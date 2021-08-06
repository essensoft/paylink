using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchToggleBoxStatusRequest Data Structure.
    /// </summary>
    public class SearchToggleBoxStatusRequest : AlipayObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 需切换的状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
