using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemUnitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUnitInfo : AlipayObject
    {
        /// <summary>
        /// 商品详情-商品套餐内容-菜品数量
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品价格。字符串，单位元，两位小数
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品规格
        /// </summary>
        [JsonProperty("spec")]
        public string Spec { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品名称。不得超过15个中文字符
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品数量单位
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
