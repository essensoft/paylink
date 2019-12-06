using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DishTag Data Structure.
    /// </summary>
    public class DishTag : AlipayObject
    {
        /// <summary>
        /// 标签类型 : 如"菜属性"，"菜推荐"
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 标签值：如"重辣","中辣","招牌菜","创意菜"
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
