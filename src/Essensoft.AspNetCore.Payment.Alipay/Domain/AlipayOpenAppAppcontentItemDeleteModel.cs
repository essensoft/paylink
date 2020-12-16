using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAppcontentItemDeleteModel : AlipayObject
    {
        /// <summary>
        /// 业务唯一ID；和商品ID任一必填一个
        /// </summary>
        [JsonPropertyName("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 商品ID；和业务唯一ID任一必填一个
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
