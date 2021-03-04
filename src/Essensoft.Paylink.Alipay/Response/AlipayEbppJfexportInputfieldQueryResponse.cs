using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppJfexportInputfieldQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportInputfieldQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 输出的输入域列表
        /// </summary>
        [JsonPropertyName("input_fields")]
        public List<JFExportInputFieldModel> InputFields { get; set; }
    }
}
