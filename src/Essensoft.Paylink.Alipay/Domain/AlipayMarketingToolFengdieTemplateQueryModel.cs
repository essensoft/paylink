using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页数，不填本参数默认为 1。
        /// </summary>
        [JsonPropertyName("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 查询结果每页记录数，最大不超过 50，不填本参数默认为 10。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
