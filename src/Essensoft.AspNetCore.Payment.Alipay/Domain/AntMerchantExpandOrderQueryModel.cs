using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 通过ant.merchant.expand.indirect.zmsub.create等接口进件时返回的order_id
        /// </summary>
        [JsonProperty("order_id")]
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
