using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CodeNOList Data Structure.
    /// </summary>
    public class CodeNOList : AlipayObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 对应TP活动码
        /// </summary>
        [JsonPropertyName("code_no")]
        public string CodeNo { get; set; }

        /// <summary>
        /// 如果ticket_type为油券，则该字段1:石化，2:石油
        /// </summary>
        [JsonPropertyName("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 券类型,1:油券
        /// </summary>
        [JsonPropertyName("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonPropertyName("valid_date")]
        public string ValidDate { get; set; }
    }
}
