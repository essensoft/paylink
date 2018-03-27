using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JdPay.Response
{
    [XmlRoot("jdpay")]
    public class JdPayUnifiedOrderResponse : JdPayResponse
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
