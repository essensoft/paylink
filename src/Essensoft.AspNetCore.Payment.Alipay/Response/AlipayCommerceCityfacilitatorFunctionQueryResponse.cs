using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

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
