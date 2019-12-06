using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemSecurityQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemSecurityQueryModel : AlipayObject
    {
        /// <summary>
        /// 前台类目ID
        /// </summary>
        [JsonPropertyName("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 场景码（具体值请参见产品文档）
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品状态：EFFECT（有效）、INVALID（无效）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品归属主体ID  例：商品归属主体类型为店铺，则商品归属主体ID为店铺ID；
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型：  5（店铺）
        /// </summary>
        [JsonPropertyName("target_type")]
        public string TargetType { get; set; }
    }
}
