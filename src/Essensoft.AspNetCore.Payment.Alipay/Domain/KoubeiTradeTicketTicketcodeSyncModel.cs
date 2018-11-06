using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeTicketTicketcodeSyncModel : AlipayObject
    {
        /// <summary>
        /// 凭证码类型,INTERNAL_CODE(内部凭证码),EXTERNAL_CODE(外部凭证码),默认INTERNAL_CODE,外部券场景必填
        /// </summary>
        [JsonProperty("code_type")]
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 业务发生时间，如为空默认为接口调用时间
        /// </summary>
        [JsonProperty("gmt_biz")]
        [XmlElement("gmt_biz")]
        public string GmtBiz { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 券码剩余可核销份数(非次卡场景1可核销，0不可核销)
        /// </summary>
        [JsonProperty("quantity")]
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 外部请求号，支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [JsonProperty("request_id")]
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 凭证码，包括内部凭证码和外部凭证码，内部凭证码为12位，纯数字，且唯一不重复
        /// </summary>
        [JsonProperty("ticket_code")]
        [XmlElement("ticket_code")]
        public string TicketCode { get; set; }
    }
}
