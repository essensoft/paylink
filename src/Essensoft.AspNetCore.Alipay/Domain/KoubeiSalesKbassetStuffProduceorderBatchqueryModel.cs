using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffProduceorderBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffProduceorderBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 每页容量：最小1，最大100
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }
    }
}
