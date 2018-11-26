using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherConfirmResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 订单金额，元为单位
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 终点站
        /// </summary>
        [JsonProperty("end_station")]
        [XmlElement("end_station")]
        public string EndStation { get; set; }

        /// <summary>
        /// 终点站点名称
        /// </summary>
        [JsonProperty("end_station_name")]
        [XmlElement("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 订单中包含的票数
        /// </summary>
        [JsonProperty("quantity")]
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 起点站
        /// </summary>
        [JsonProperty("start_station")]
        [XmlElement("start_station")]
        public string StartStation { get; set; }

        /// <summary>
        /// 起始站点名称
        /// </summary>
        [JsonProperty("start_station_name")]
        [XmlElement("start_station_name")]
        public string StartStationName { get; set; }

        /// <summary>
        /// 该笔订单状态，默认必然是SUCCESS
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 票单价
        /// </summary>
        [JsonProperty("ticket_price")]
        [XmlElement("ticket_price")]
        public string TicketPrice { get; set; }

        /// <summary>
        /// 描述票种类
        /// </summary>
        [JsonProperty("ticket_type")]
        [XmlElement("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
