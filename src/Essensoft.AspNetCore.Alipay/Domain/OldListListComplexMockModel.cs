using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// OldListListComplexMockModel Data Structure.
    /// </summary>
    public class OldListListComplexMockModel : AlipayObject
    {
        /// <summary>
        /// 复杂模型list
        /// </summary>
        [JsonProperty("cm_list")]
        public List<OldComplextMockModel> CmList { get; set; }
    }
}
