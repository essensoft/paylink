using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyCancelResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodPolicyCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 操作结果 true/false
        /// </summary>
        [JsonProperty("cancel_result")]
        [XmlElement("cancel_result")]
        public string CancelResult { get; set; }
    }
}
