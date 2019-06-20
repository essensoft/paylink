using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemModel Data Structure.
    /// </summary>
    [Serializable]
    public class ItemModel : AlipayObject
    {
        /// <summary>
        /// 创建者id
        /// </summary>
        [JsonProperty("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建者类型
        /// </summary>
        [JsonProperty("creator_type")]
        public string CreatorType { get; set; }

        /// <summary>
        /// 商品扩展信息：可以解析成 Map<String, String> 的 json string
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 前台类目id
        /// </summary>
        [JsonProperty("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 商品创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商品更新时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品sku列表
        /// </summary>
        [JsonProperty("sku_list")]
        public List<ItemSkuInfo> SkuList { get; set; }

        /// <summary>
        /// 商品排序
        /// </summary>
        [JsonProperty("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 商品状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商户归属主体id
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型：5(商铺)
        /// </summary>
        [JsonProperty("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
