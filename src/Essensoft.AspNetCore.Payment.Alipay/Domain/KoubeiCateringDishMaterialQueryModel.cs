using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishMaterialQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishMaterialQueryModel : AlipayObject
    {
        /// <summary>
        /// 加料的id
        /// </summary>
        [JsonProperty("material_id")]
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 要查询的加料库的商户id
        /// </summary>
        [JsonProperty("merchant_id")]
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
