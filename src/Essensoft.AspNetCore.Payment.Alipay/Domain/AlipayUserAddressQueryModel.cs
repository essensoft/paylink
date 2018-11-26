using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAddressQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAddressQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户地址唯一ID。通过调用小程序开放api(my.chooseAddress)获取。
        /// </summary>
        [JsonProperty("address_id")]
        [XmlElement("address_id")]
        public string AddressId { get; set; }
    }
}
