using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ErrorDishStallEntity Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorDishStallEntity : AlipayObject
    {
        /// <summary>
        /// 未关联档口菜品集合
        /// </summary>
        [JsonProperty("no_set_stall")]
        public List<ErrorDishEntity> NoSetStall { get; set; }

        /// <summary>
        /// 重复关联档口菜品集合
        /// </summary>
        [JsonProperty("repeat_set_stall")]
        public List<ErrorDishEntity> RepeatSetStall { get; set; }
    }
}
