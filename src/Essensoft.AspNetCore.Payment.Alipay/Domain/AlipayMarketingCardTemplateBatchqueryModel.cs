using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardTemplateBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小，默认20条，最大支持20条
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
