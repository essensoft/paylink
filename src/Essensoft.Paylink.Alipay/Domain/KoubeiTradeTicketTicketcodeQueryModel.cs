using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeQueryModel Data Structure.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 券码值，12位纯数字券码，且唯一不重复。
        /// </summary>
        [JsonPropertyName("ticket_code")]
        public string TicketCode { get; set; }
    }
}
