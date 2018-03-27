using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Response
{
    public class WeChatPayUnifiedOrderResponse : WeChatPayResponse
    {
        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 预支付交易会话标识	
        /// </summary>
        [XmlElement("prepay_id")]
        public string PrepayId { get; set; }

        /// <summary>
        /// 二维码链接	
        /// </summary>
        [XmlElement("code_url")]
        public string CodeUrl { get; set; }
    }
}
