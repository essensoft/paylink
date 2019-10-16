using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketUsedRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeTicketUsedRefundModel : AlipayObject
    {
        /// <summary>
        /// 外部请求号，支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 凭证码，包括内部凭证码和外部凭证码，内部凭证码为12位，纯数字，且唯一不重复
        /// </summary>
        [JsonProperty("ticket_code")]
        public string TicketCode { get; set; }

        /// <summary>
        /// 券核销流水号，针对该次核销发起售后退操作
        /// </summary>
        [JsonProperty("trans_id")]
        public string TransId { get; set; }
    }
}
