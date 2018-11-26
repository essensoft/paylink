using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketShopBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 页码，第一页传入"1"，默认500个结果为一页。此参数必须是大于0的正整数，为0时将查询报错。
        /// </summary>
        [JsonProperty("page_no")]
        [XmlElement("page_no")]
        public string PageNo { get; set; }
    }
}
