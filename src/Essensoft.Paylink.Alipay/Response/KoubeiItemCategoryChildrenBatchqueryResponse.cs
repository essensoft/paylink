using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiItemCategoryChildrenBatchqueryResponse.
    /// </summary>
    public class KoubeiItemCategoryChildrenBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑标准后台类目信息列表
        /// </summary>
        [JsonPropertyName("category_list")]
        public List<StandardCategoryInfo> CategoryList { get; set; }
    }
}
