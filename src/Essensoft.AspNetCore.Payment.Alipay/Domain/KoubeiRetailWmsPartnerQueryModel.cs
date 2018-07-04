using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsPartnerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsPartnerQueryModel : AlipayObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operate_context")]
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 商户ID，限制批量查询100个ID
        /// </summary>
        [JsonProperty("partner_ids")]
        [XmlArray("partner_ids")]
        [XmlArrayItem("string")]
        public List<string> PartnerIds { get; set; }
    }
}
