using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OldListListComplexMockModel Data Structure.
    /// </summary>
    public class OldListListComplexMockModel : AlipayObject
    {
        /// <summary>
        /// 复杂模型list
        /// </summary>
        [JsonPropertyName("cm_list")]
        public List<OldComplextMockModel> CmList { get; set; }
    }
}
