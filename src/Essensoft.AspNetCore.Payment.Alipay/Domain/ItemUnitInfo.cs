using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemUnitInfo Data Structure.
    /// </summary>
    public class ItemUnitInfo : AlipayObject
    {
        /// <summary>
        /// 商品详情-商品套餐内容-菜品数量
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品价格。字符串，单位元，两位小数
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品规格
        /// </summary>
        [JsonPropertyName("spec")]
        public string Spec { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品名称。不得超过15个中文字符
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品数量单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
