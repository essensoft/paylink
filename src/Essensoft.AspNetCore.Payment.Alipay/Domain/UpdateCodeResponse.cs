using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UpdateCodeResponse Data Structure.
    /// </summary>
    public class UpdateCodeResponse : AlipayObject
    {
        /// <summary>
        /// 批量更新码值返回结果列表
        /// </summary>
        [JsonPropertyName("update_code_result")]
        public List<UpdateCodeResult> UpdateCodeResult { get; set; }
    }
}
