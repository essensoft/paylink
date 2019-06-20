using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StockTask Data Structure.
    /// </summary>
    [Serializable]
    public class StockTask : AlipayObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 库存查询日期
        /// </summary>
        [JsonProperty("query_time")]
        public string QueryTime { get; set; }

        /// <summary>
        /// 库存任务状态：0 未开始、1 进行中、2已完成、3 失败
        /// </summary>
        [JsonProperty("status")]
        public long Status { get; set; }

        /// <summary>
        /// 库存查询任务id
        /// </summary>
        [JsonProperty("task_id")]
        public long TaskId { get; set; }
    }
}
