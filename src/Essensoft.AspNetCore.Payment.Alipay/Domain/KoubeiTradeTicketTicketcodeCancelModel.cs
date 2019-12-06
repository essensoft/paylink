using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeCancelModel Data Structure.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeCancelModel : AlipayObject
    {
        /// <summary>
        /// 凭证码类型,INTERNAL_CODE(内部凭证码),EXTERNAL_CODE(外部凭证码),默认INTERNAL_CODE,外部券场景必填
        /// </summary>
        [JsonPropertyName("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 口碑订单号，使用外部凭证码取消时必填
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 冲正份数，次卡业务必填，用于校验正反向份数相同
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 业务请求号,一般为正向核销时使用的外部请求号
        /// </summary>
        [JsonPropertyName("request_biz_no")]
        public string RequestBizNo { get; set; }

        /// <summary>
        /// 核销的外部请求号，指定撤销某一次的核销动作
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// request_id对应核销的凭证码
        /// </summary>
        [JsonPropertyName("ticket_code")]
        public string TicketCode { get; set; }
    }
}
