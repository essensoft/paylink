using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodsBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 货品编码，限制批量查询100个
        /// </summary>
        [JsonProperty("goods_codes")]
        [XmlArray("goods_codes")]
        [XmlArrayItem("string")]
        public List<string> GoodsCodes { get; set; }
    }
}
