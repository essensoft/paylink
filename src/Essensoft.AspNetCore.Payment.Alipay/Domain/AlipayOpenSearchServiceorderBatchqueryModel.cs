using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSearchServiceorderBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenSearchServiceorderBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 服务搜索申请单分页入参
        /// </summary>
        [JsonPropertyName("biz_data")]
        public SearchApplyPageQueryRequest BizData { get; set; }

        /// <summary>
        /// 表示查询内容的类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作的类型，如query
        /// </summary>
        [JsonPropertyName("opt_type")]
        public string OptType { get; set; }
    }
}
