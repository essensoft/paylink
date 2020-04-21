using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WorldTicketType Data Structure.
    /// </summary>
    public class WorldTicketType : AlipayObject
    {
        /// <summary>
        /// 票种代码
        /// </summary>
        [JsonPropertyName("ticket_type_code")]
        public string TicketTypeCode { get; set; }

        /// <summary>
        /// 票种描述
        /// </summary>
        [JsonPropertyName("ticket_type_desc")]
        public string TicketTypeDesc { get; set; }

        /// <summary>
        /// 票种名称
        /// </summary>
        [JsonPropertyName("ticket_type_name")]
        public string TicketTypeName { get; set; }
    }
}
