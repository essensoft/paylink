using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicXwbtestabcdBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 1111112141414
        /// </summary>
        [JsonProperty("s")]
        [XmlElement("s")]
        public string S { get; set; }
    }
}
