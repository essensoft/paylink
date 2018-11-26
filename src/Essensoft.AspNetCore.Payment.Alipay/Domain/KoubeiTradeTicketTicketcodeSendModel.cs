using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeTicketTicketcodeSendModel : AlipayObject
    {
        /// <summary>
        /// 需要发送的码列表，其中code表示串码码值，num表示码的可核销份数
        /// </summary>
        [JsonProperty("isv_ma_list")]
        [XmlArray("isv_ma_list")]
        [XmlArrayItem("kb_isv_ma_code")]
        public List<KbIsvMaCode> IsvMaList { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求id，唯一标识一次请求
        /// </summary>
        [JsonProperty("request_id")]
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑商品发货单号
        /// </summary>
        [JsonProperty("send_order_no")]
        [XmlElement("send_order_no")]
        public string SendOrderNo { get; set; }

        /// <summary>
        /// 口碑发码通知透传码商，码商需要跟发码通知获取到的参数一致
        /// </summary>
        [JsonProperty("send_token")]
        [XmlElement("send_token")]
        public string SendToken { get; set; }
    }
}
