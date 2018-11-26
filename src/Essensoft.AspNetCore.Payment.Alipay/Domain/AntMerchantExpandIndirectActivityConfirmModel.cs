using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectActivityConfirmModel : AlipayObject
    {
        /// <summary>
        /// 活动报名id
        /// </summary>
        [JsonProperty("order_id")]
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
