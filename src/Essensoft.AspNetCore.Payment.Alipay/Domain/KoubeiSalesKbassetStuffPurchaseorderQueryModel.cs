using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffPurchaseorderQueryModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffPurchaseorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 每页大小：最小1，最大100
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }
    }
}
