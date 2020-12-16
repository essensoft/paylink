using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PreOrderConfigInfo Data Structure.
    /// </summary>
    public class PreOrderConfigInfo : AlipayObject
    {
        /// <summary>
        /// OPEN表示打开点餐服务 CLOSED表示关闭点餐服务，不传表示不做更新
        /// </summary>
        [JsonPropertyName("pre_order_status")]
        public string PreOrderStatus { get; set; }

        /// <summary>
        /// 最早可提前预订时间，格式: hh:mm，如：00:15，表示15分钟；02:00，表示2个小时。不设置默认为提前5分钟，00:05。
        /// </summary>
        [JsonPropertyName("time_before")]
        public string TimeBefore { get; set; }

        /// <summary>
        /// 自提时段配置列表,按照周规则设置
        /// </summary>
        [JsonPropertyName("time_period_config_list")]
        public List<TimePeriodConfig> TimePeriodConfigList { get; set; }
    }
}
