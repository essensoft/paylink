using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StockTaskResult Data Structure.
    /// </summary>
    public class StockTaskResult : AlipayObject
    {
        /// <summary>
        /// 售价方式：CPP（按人次保量）、CPT（按时长售卖）
        /// </summary>
        [JsonPropertyName("charge_type")]
        public long ChargeType { get; set; }

        /// <summary>
        /// 库存任务创建时间
        /// </summary>
        [JsonPropertyName("query_time")]
        public string QueryTime { get; set; }

        /// <summary>
        /// 售卖方式，枚举值1:GD（保量）、2:RTB（竞价）
        /// </summary>
        [JsonPropertyName("sell_mode")]
        public long SellMode { get; set; }

        /// <summary>
        /// 库存查询量
        /// </summary>
        [JsonPropertyName("stock_quantity")]
        public List<StockQuantity> StockQuantity { get; set; }

        /// <summary>
        /// 库存任务查询条件
        /// </summary>
        [JsonPropertyName("stock_query_condition")]
        public StockQueryCondition StockQueryCondition { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 单价：CPP模式下 分/千人次， CPT模式下 分/秒）
        /// </summary>
        [JsonPropertyName("unit_price")]
        public long UnitPrice { get; set; }
    }
}
