using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemExtitemExistedQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemExistedQueryModel : AlipayObject
    {
        /// <summary>
        /// 商品编码列表, 商品编码数量不超过100条。
        /// </summary>
        [JsonProperty("code_list")]
        [XmlArray("code_list")]
        [XmlArrayItem("string")]
        public List<string> CodeList { get; set; }
    }
}
