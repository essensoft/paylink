using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishstatusModifyModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDishstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 需要改售卖状态的菜品id集合
        /// </summary>
        [JsonPropertyName("dish_ids")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// open:起售；stop:停售
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
