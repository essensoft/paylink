using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialAntforestProjectQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestProjectQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 请联系接口开发人员咨询相关参数
        /// </summary>
        [JsonPropertyName("projects")]
        public List<string> Projects { get; set; }
    }
}
