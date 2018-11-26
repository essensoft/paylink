using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.JDPay.Domain;

namespace Essensoft.AspNetCore.Payment.JDPay.Response
{
    [XmlRoot("jdpay")]
    public class JDPayUnifiedOrderResponse : JDPayResponse
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version")]
        public string Version { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("merchant")]
        public string Merchant { get; set; }

        /// <summary>
        /// 门店号
        /// </summary>
        [XmlElement("device")]
        public string Device { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("tradeNum")]
        public string TradeNum { get; set; }

        /// <summary>
        /// 京东交易单号
        /// </summary>
        [XmlElement("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchantName")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易过期时间
        /// </summary>
        [XmlElement("expireTime")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 支付二维码
        /// </summary>
        [XmlElement("qrCode")]
        public string QrCode { get; set; }

        /// <summary>
        /// 交易信息签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("result")]
        public Result Result { get; set; }
    }
}
