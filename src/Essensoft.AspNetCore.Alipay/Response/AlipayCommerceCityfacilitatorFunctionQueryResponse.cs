using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
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
        public List<SupportFunction> Functions { get; set; }
    }
}
