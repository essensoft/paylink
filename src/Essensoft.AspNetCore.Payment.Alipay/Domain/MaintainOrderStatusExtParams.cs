using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaintainOrderStatusExtParams Data Structure.
    /// </summary>
    [Serializable]
    public class MaintainOrderStatusExtParams : AlipayObject
    {
        /// <summary>
        /// 编码
        /// </summary>
        [JsonProperty("logistics_code")]
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 快递发货商
        /// </summary>
        [JsonProperty("logistics_company")]
        [XmlElement("logistics_company")]
        public string LogisticsCompany { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonProperty("logistics_no")]
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 4S订单状态
        /// </summary>
        [JsonProperty("order_status_txt")]
        [XmlElement("order_status_txt")]
        public string OrderStatusTxt { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [JsonProperty("receiver_addr")]
        [XmlElement("receiver_addr")]
        public string ReceiverAddr { get; set; }

        /// <summary>
        /// 发货地址
        /// </summary>
        [JsonProperty("sender_addr")]
        [XmlElement("sender_addr")]
        public string SenderAddr { get; set; }
    }
}
