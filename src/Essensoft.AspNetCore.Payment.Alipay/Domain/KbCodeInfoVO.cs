using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbCodeInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class KbCodeInfoVO : AlipayObject
    {
        /// <summary>
        /// 创建口碑码的批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public long BatchId { get; set; }

        /// <summary>
        /// 口碑码图片(不带背景图)
        /// </summary>
        [JsonProperty("code_url")]
        public string CodeUrl { get; set; }

        /// <summary>
        /// 口碑码创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 口碑码ID
        /// </summary>
        [JsonProperty("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 口碑码物料图（带背景）
        /// </summary>
        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 口碑门店名称
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 物料模板
        /// </summary>
        [JsonProperty("stuff_template")]
        public string StuffTemplate { get; set; }

        /// <summary>
        /// 物料模板描述
        /// </summary>
        [JsonProperty("stuff_template_desc")]
        public string StuffTemplateDesc { get; set; }

        /// <summary>
        /// 口碑码类型描述
        /// </summary>
        [JsonProperty("stuff_type_desc")]
        public string StuffTypeDesc { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [JsonProperty("table_no")]
        public string TableNo { get; set; }
    }
}
