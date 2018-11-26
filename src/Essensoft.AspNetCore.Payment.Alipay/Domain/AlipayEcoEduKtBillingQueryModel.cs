using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduKtBillingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduKtBillingQueryModel : AlipayObject
    {
        /// <summary>
        /// Isv pid
        /// </summary>
        [JsonProperty("isv_pid")]
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// ISV调用发送账单接口，返回给商户的order_no
        /// </summary>
        [JsonProperty("out_trade_no")]
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 学校支付宝pid
        /// </summary>
        [JsonProperty("school_pid")]
        [XmlElement("school_pid")]
        public string SchoolPid { get; set; }
    }
}
