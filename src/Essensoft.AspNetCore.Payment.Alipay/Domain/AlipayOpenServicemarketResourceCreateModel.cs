using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketResourceCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketResourceCreateModel : AlipayObject
    {
        /// <summary>
        /// 资源消耗记录
        /// </summary>
        [JsonPropertyName("ability_resource_consume")]
        public List<AbilityResourceConsume> AbilityResourceConsume { get; set; }

        /// <summary>
        /// 资源执行的结束时间
        /// </summary>
        [JsonPropertyName("execution_time_end")]
        public string ExecutionTimeEnd { get; set; }

        /// <summary>
        /// 上报的时候计量的开始时间
        /// </summary>
        [JsonPropertyName("execution_time_start")]
        public string ExecutionTimeStart { get; set; }

        /// <summary>
        /// 资源上报接口,订单消息里面的商品code
        /// </summary>
        [JsonPropertyName("outer_code")]
        public string OuterCode { get; set; }

        /// <summary>
        /// isv每次上报的id
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// Frequency：使用次数（次）       Period：使用时长（秒）      Storage：使用存储空间（Byte）      NetworkOut：上行使用流量（Bit/s）      NetworkIn：下行使用流量（Bit/s）       Character：字符数（个）      DailyActiveUser：日活跃用户数（DAU）      PeriodMin：使用时长（分钟）
        /// </summary>
        [JsonPropertyName("record_unit")]
        public string RecordUnit { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}
