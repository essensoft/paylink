using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryReservationPayshopIdentifyResponse.
    /// </summary>
    public class KoubeiServindustryReservationPayshopIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否付费店铺
        /// </summary>
        [JsonPropertyName("pay_shop")]
        public bool PayShop { get; set; }
    }
}
