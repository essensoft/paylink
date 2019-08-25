using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 需要改售卖状态的菜品id集合
        /// </summary>
        [JsonProperty("dish_ids")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// open:起售；stop:停售
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
