using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffPurchaseorderQueryModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffPurchaseorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 每页大小：最小1，最大100
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }
    }
}
