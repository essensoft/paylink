using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSpaceBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieSpaceBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页数，默认为1
        /// </summary>
        [JsonProperty("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页记录数，不能超过50，默认为10
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
