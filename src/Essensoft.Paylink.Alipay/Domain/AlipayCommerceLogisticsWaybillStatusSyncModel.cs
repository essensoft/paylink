using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillStatusSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceLogisticsWaybillStatusSyncModel : AlipayObject
    {
        /// <summary>
        /// 接口调用方的渠道编码，由支付宝分配
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 物流运单状态同步的具体内容，根据不同的scene确定参数字段
        /// </summary>
        [JsonPropertyName("data")]
        public List<ParamInfo> Data { get; set; }

        /// <summary>
        /// 物流运单状态同步的场景编码，由支付宝定义
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
