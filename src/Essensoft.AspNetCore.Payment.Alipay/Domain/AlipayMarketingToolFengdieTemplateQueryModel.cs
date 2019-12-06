using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页数，默认为1
        /// </summary>
        [JsonPropertyName("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页记录数，不能超过50，默认为10
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
