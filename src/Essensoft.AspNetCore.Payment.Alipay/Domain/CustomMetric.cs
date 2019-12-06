using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CustomMetric Data Structure.
    /// </summary>
    public class CustomMetric : AlipayObject
    {
        /// <summary>
        /// 监控共建自定义指标数据产生的时间戳
        /// </summary>
        [JsonPropertyName("biz_time")]
        public long BizTime { get; set; }

        /// <summary>
        /// 监控共建自定义指标维度集合
        /// </summary>
        [JsonPropertyName("dimensions")]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// 监控共建自定义指标名称
        /// </summary>
        [JsonPropertyName("metric_name")]
        public string MetricName { get; set; }

        /// <summary>
        /// 监控共建自定义指标值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
