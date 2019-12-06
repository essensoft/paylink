using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarPromoTicketPushModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarPromoTicketPushModel : AlipayObject
    {
        /// <summary>
        /// 核销流水
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 核销状态，0：成功，1：失败
        /// </summary>
        [JsonPropertyName("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 对应TP活动码
        /// </summary>
        [JsonPropertyName("code_no")]
        public string CodeNo { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [JsonPropertyName("ticket_id")]
        public string TicketId { get; set; }
    }
}
