using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayInsCooperationProductOfflineBatchqueryResponse.
    /// </summary>
    public class AlipayInsCooperationProductOfflineBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回给机构的线下产品信息列表
        /// </summary>
        [JsonProperty("product_list")]
        public List<InsOffilneProduct> ProductList { get; set; }
    }
}
