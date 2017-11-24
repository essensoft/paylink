using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay.Response
{
    [XmlRoot("jdpay")]
    public class JdPayUnifiedOrderResponse : JdPayResponse
    {
        [XmlElement("orderId")]
        public string OrderId { set; get; }

        [XmlElement("merchantName")]
        public string MerchantName { set; get; }

        [XmlElement("amount")]
        public string Amount { set; get; }

        [XmlElement("tradeNum")]
        public string TradeNum { set; get; }

        [XmlElement("qrCode")]
        public string QrCode { set; get; }

        [XmlElement("expireTime")]
        public string ExpireTime { set; get; }
    }
}
