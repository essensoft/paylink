using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemCategoryChildrenBatchqueryResponse.
    /// </summary>
    public class KoubeiItemCategoryChildrenBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑标准后台类目信息列表
        /// </summary>
        [JsonProperty("category_list")]
        [XmlArray("category_list")]
        [XmlArrayItem("standard_category_info")]
        public List<StandardCategoryInfo> CategoryList { get; set; }
    }
}
