using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AbilityResourceConsume Data Structure.
    /// </summary>
    public class AbilityResourceConsume : AlipayObject
    {
        /// <summary>
        /// 业务标记
        /// </summary>
        [JsonPropertyName("ability_resource_biz_mark")]
        public List<AbilityResourceBizMark> AbilityResourceBizMark { get; set; }

        /// <summary>
        /// isv提供的资源消耗code,是单次上报的全局唯一code
        /// </summary>
        [JsonPropertyName("consume_code")]
        public string ConsumeCode { get; set; }

        /// <summary>
        /// 资源计量的结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// isv资源被使用的时候,商户绑定的appid
        /// </summary>
        [JsonPropertyName("m_app_id")]
        public string MAppId { get; set; }

        /// <summary>
        /// 计量值,当前时间段类消耗了多少
        /// </summary>
        [JsonPropertyName("record_val")]
        public string RecordVal { get; set; }

        /// <summary>
        /// 资源计量的开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
