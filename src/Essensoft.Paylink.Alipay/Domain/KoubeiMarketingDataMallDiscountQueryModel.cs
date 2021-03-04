using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMallDiscountQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataMallDiscountQueryModel : AlipayObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }
    }
}
