using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceDataCustommetricSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceDataCustommetricSyncModel : AlipayObject
    {
        /// <summary>
        /// 自定义监控指标数据结构，商户与支付宝进行监控共建场景使用，用户按照数据结构自主上传
        /// </summary>
        [JsonPropertyName("metric_data")]
        public List<CustomMetric> MetricData { get; set; }

        /// <summary>
        /// 命名空间，商户与支付宝进行监控共建场景使用，命令空间需要先在云监控自定义监控页面配置录入。
        /// </summary>
        [JsonPropertyName("namespace")]
        public string Namespace { get; set; }
    }
}
