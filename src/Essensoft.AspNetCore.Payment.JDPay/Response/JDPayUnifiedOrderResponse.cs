using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay.Response
{
    [XmlRoot("jdpay")]
    public class JDPayUnifiedOrderResponse : JDPayResponse
    {
        [XmlElement("orderId")]
        public string OrderId { get; set; }

        [XmlElement("merchantName")]
        public string MerchantName { get; set; }

        [XmlElement("amount")]
        public string Amount { get; set; }

        [XmlElement("tradeNum")]
        public string TradeNum { get; set; }

        [XmlElement("qrCode")]
        public string QrCode { get; set; }

        [XmlElement("expireTime")]
        public string ExpireTime { get; set; }
    }
}
