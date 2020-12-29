using System.Text.Json.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmFunctionQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmFunctionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 功能点列表
        /// </summary>
        [JsonPropertyName("functions")]
        public List<Function> Functions { get; set; }
    }
}
