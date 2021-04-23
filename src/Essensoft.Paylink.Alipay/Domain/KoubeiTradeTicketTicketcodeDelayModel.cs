using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeDelayModel Data Structure.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeDelayModel : AlipayObject
    {
        /// <summary>
        /// 券码类型。默认INTERNAL_CODE。枚举值如下： * INTERNAL_CODE：券码。 * EXTERNAL_CODE：外部券码。
        /// </summary>
        [JsonPropertyName("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 延至日期，时间格式为 yyyyMMdd HHmmss。
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求 id，唯一标识一次请求，由商家自定义。
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 凭证码
        /// </summary>
        [JsonPropertyName("ticket_code")]
        public string TicketCode { get; set; }
    }
}
