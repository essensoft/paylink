using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountQueryResponse.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 广告投放出去的优惠信息
        /// </summary>
        [JsonPropertyName("discount")]
        public DiscountInfo Discount { get; set; }
    }
}
