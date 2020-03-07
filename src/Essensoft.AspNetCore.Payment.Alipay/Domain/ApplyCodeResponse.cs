using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApplyCodeResponse Data Structure.
    /// </summary>
    public class ApplyCodeResponse : AlipayObject
    {
        /// <summary>
        /// apply_code_results，申请S码的结果中的批量发码结果
        /// </summary>
        [JsonPropertyName("apply_code_result")]
        public List<ApplyCodeResult> ApplyCodeResult { get; set; }
    }
}
