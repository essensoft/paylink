using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataAlisisReportBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page")]
        public string Page { get; set; }

        /// <summary>
        /// 每页最大条数，最大为30
        /// </summary>
        [JsonPropertyName("size")]
        public string Size { get; set; }
    }
}
