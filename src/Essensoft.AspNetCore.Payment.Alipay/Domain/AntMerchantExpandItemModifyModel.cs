using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemModifyModel : AlipayObject
    {
        /// <summary>
        /// 商品扩展信息：可以解析成 Map<String, String> 的 json string
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 前台类目id, null表示未分类
        /// </summary>
        [JsonProperty("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品标签列表，null表示不修改标签列表，空list表示清空标签
        /// </summary>
        [JsonProperty("label_list")]
        public List<ItemLabelModifyInfo> LabelList { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 场景：GAS_CHARGE（加油）
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品sku列表，至少有一个
        /// </summary>
        [JsonProperty("sku_list")]
        public List<ItemSkuModifyInfo> SkuList { get; set; }
    }
}
