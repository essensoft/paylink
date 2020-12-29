using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchOrderBrandDetail Data Structure.
    /// </summary>
    public class SearchOrderBrandDetail : AlipayObject
    {
        /// <summary>
        /// 工单详情数据信息
        /// </summary>
        [JsonPropertyName("brand_detail")]
        public BrandDetail BrandDetail { get; set; }

        /// <summary>
        /// 工单详情key值
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
