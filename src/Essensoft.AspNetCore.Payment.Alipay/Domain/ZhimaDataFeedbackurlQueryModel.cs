using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaDataFeedbackurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaDataFeedbackurlQueryModel : AlipayObject
    {
        /// <summary>
        /// 在支付宝商户版注册支付宝账号id
        /// </summary>
        [JsonProperty("merchant_id")]
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
