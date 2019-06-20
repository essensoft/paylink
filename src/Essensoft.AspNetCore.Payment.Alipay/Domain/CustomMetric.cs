using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CustomMetric Data Structure.
    /// </summary>
    [Serializable]
    public class CustomMetric : AlipayObject
    {
        /// <summary>
        /// 监控共建自定义指标数据产生的时间戳
        /// </summary>
        [JsonProperty("biz_time")]
        public long BizTime { get; set; }

        /// <summary>
        /// 监控共建自定义指标维度集合
        /// </summary>
        [JsonProperty("dimensions")]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// 监控共建自定义指标名称
        /// </summary>
        [JsonProperty("metric_name")]
        public string MetricName { get; set; }

        /// <summary>
        /// 监控共建自定义指标值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
