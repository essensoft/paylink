using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorFunctionQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorFunctionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支持的功能列表
        /// </summary>
        [JsonProperty("functions")]
        [XmlArray("functions")]
        [XmlArrayItem("support_function")]
        public List<SupportFunction> Functions { get; set; }
    }
}
