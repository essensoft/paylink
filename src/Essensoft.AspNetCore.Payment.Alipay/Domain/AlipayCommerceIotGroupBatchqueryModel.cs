using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotGroupBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotGroupBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型-代表不同的业务场景 distribution表示服务分发
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonPropertyName("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 分页搜索偏移值
        /// </summary>
        [JsonPropertyName("offset")]
        public long Offset { get; set; }
    }
}
