using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ErrorDishStallEntity Data Structure.
    /// </summary>
    public class ErrorDishStallEntity : AlipayObject
    {
        /// <summary>
        /// 未关联档口菜品集合
        /// </summary>
        [JsonPropertyName("no_set_stall")]
        public List<ErrorDishEntity> NoSetStall { get; set; }

        /// <summary>
        /// 重复关联档口菜品集合
        /// </summary>
        [JsonPropertyName("repeat_set_stall")]
        public List<ErrorDishEntity> RepeatSetStall { get; set; }
    }
}
