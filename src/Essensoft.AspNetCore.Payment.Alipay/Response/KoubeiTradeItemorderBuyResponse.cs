using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeItemorderBuyResponse.
    /// </summary>
    public class KoubeiTradeItemorderBuyResponse : AlipayResponse
    {
        /// <summary>
        /// 收银单id，唤收银台时传入，该参数为请求级别参数，如果二次支付，需要重新获取
        /// </summary>
        [JsonProperty("cashier_order_id")]
        [XmlElement("cashier_order_id")]
        public string CashierOrderId { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付宝交易号，唤收银台时入参
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
