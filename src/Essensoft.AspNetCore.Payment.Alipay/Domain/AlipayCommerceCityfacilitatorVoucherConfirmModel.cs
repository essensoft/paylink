using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherConfirmModel Data Structure.
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherConfirmModel : AlipayObject
    {
        /// <summary>
        /// 金额，元为单位
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 渠道商提供的其它信息
        /// </summary>
        [JsonProperty("biz_info_ext")]
        public string BizInfoExt { get; set; }

        /// <summary>
        /// 该笔请求的唯一编号，有值请求强校验
        /// </summary>
        [JsonProperty("biz_request_id")]
        public string BizRequestId { get; set; }

        /// <summary>
        /// 城市标准码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 终点站编号
        /// </summary>
        [JsonProperty("end_station")]
        public string EndStation { get; set; }

        /// <summary>
        /// 单张票编号列表，多个逗号分隔
        /// </summary>
        [JsonProperty("exchange_ids")]
        public string ExchangeIds { get; set; }

        /// <summary>
        /// 商户核销时间
        /// </summary>
        [JsonProperty("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 商户的交易号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 票数
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 请求方标识
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 起点站编号
        /// </summary>
        [JsonProperty("start_station")]
        public string StartStation { get; set; }

        /// <summary>
        /// 核销号
        /// </summary>
        [JsonProperty("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 票单价，元为单位
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
