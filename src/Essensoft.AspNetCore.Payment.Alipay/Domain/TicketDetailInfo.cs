using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TicketDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TicketDetailInfo : AlipayObject
    {
        /// <summary>
        /// 总金额，元为单位
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 终点站编码
        /// </summary>
        [JsonProperty("end_station")]
        public string EndStation { get; set; }

        /// <summary>
        /// 终点站中文名称
        /// </summary>
        [JsonProperty("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 票数量
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 起点站编码
        /// </summary>
        [JsonProperty("start_station")]
        public string StartStation { get; set; }

        /// <summary>
        /// 起点站中文名称
        /// </summary>
        [JsonProperty("start_station_name")]
        public string StartStationName { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 单价，元为单位
        /// </summary>
        [JsonProperty("ticket_price")]
        public string TicketPrice { get; set; }

        /// <summary>
        /// 票类型
        /// </summary>
        [JsonProperty("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
