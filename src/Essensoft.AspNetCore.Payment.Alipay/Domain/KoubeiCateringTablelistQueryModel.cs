using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringTablelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringTablelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
