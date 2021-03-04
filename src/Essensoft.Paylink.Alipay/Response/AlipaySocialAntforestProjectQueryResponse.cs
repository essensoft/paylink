using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
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
