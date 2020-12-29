using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishDetailInfo Data Structure.
    /// </summary>
    public class KbdishDetailInfo : AlipayObject
    {
        /// <summary>
        /// 外部菜品id
        /// </summary>
        [JsonPropertyName("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部sku_id列表
        /// </summary>
        [JsonPropertyName("out_sku_id_list")]
        public List<string> OutSkuIdList { get; set; }
    }
}
