using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbCodeInfoVO Data Structure.
    /// </summary>
    public class KbCodeInfoVO : AlipayObject
    {
        /// <summary>
        /// 创建口碑码的批次号
        /// </summary>
        [JsonPropertyName("batch_id")]
        public long BatchId { get; set; }

        /// <summary>
        /// 口碑码图片(不带背景图)
        /// </summary>
        [JsonPropertyName("code_url")]
        public string CodeUrl { get; set; }

        /// <summary>
        /// 口碑码创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 口碑码ID
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 口碑码物料图（带背景）
        /// </summary>
        [JsonPropertyName("resource_url")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 口碑门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 物料模板
        /// </summary>
        [JsonPropertyName("stuff_template")]
        public string StuffTemplate { get; set; }

        /// <summary>
        /// 物料模板描述
        /// </summary>
        [JsonPropertyName("stuff_template_desc")]
        public string StuffTemplateDesc { get; set; }

        /// <summary>
        /// 口碑码类型描述
        /// </summary>
        [JsonPropertyName("stuff_type_desc")]
        public string StuffTypeDesc { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [JsonPropertyName("table_no")]
        public string TableNo { get; set; }
    }
}
