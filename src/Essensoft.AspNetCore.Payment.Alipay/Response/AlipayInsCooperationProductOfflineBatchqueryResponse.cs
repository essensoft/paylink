using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
        [XmlArray("product_list")]
        [XmlArrayItem("ins_offilne_product")]
        public List<InsOffilneProduct> ProductList { get; set; }
    }
}
