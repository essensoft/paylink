using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishMenuQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishMenuQueryModel : AlipayObject
    {
        /// <summary>
        /// 菜谱名称
        /// </summary>
        [JsonPropertyName("cook_name")]
        public string CookName { get; set; }
    }
}
