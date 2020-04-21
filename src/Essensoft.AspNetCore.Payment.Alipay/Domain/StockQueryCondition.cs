using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StockQueryCondition Data Structure.
    /// </summary>
    public class StockQueryCondition : AlipayObject
    {
        /// <summary>
        /// 库存查询结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 站点列表
        /// </summary>
        [JsonPropertyName("position")]
        public List<Position> Position { get; set; }

        /// <summary>
        /// 库存查询起始日期
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
