using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailMallCdpQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailMallCdpQueryModel : AlipayObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonProperty("mall_id")]
        [XmlElement("mall_id")]
        public string MallId { get; set; }
    }
}
