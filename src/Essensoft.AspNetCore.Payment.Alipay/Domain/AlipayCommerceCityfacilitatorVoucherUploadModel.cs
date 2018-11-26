using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorVoucherUploadModel : AlipayObject
    {
        /// <summary>
        /// 渠道商提供的其它信息
        /// </summary>
        [JsonProperty("biz_info_ext")]
        [XmlElement("biz_info_ext")]
        public string BizInfoExt { get; set; }

        /// <summary>
        /// 城市标准码
        /// </summary>
        [JsonProperty("city_code")]
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// JSON字符串，包含出票的序列号，票号，出票时间，出票流水号
        /// </summary>
        [JsonProperty("exchange_ids")]
        [XmlElement("exchange_ids")]
        public string ExchangeIds { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonProperty("operate_time")]
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 核销码
        /// </summary>
        [JsonProperty("ticket_no")]
        [XmlElement("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
