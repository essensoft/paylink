using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemExtitemCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemCategoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 父品类编码. (查询顶级类目时值传0)
        /// </summary>
        [JsonProperty("parent_id")]
        [XmlElement("parent_id")]
        public string ParentId { get; set; }
    }
}
