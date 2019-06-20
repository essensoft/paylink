using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StockQueryCondition Data Structure.
    /// </summary>
    [Serializable]
    public class StockQueryCondition : AlipayObject
    {
        /// <summary>
        /// 库存查询结束时间
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 站点列表
        /// </summary>
        [JsonProperty("position")]
        public List<Position> Position { get; set; }

        /// <summary>
        /// 库存查询起始日期
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }
}
