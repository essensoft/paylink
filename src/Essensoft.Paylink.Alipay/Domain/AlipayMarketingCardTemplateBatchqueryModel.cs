using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardTemplateBatchqueryModel : AlipayObject
    {
        /// <summary>
        ///  查询起始页码，第一页为 1。
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数据大小，默认 20条，最大支持20条。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
