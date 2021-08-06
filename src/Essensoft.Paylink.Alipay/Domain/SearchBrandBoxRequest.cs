using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchBrandBoxRequest Data Structure.
    /// </summary>
    public class SearchBrandBoxRequest : AlipayObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌box工单id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
