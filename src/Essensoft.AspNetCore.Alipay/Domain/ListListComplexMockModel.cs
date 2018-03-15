using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ListListComplexMockModel Data Structure.
    /// </summary>
    public class ListListComplexMockModel : AlipayObject
    {
        /// <summary>
        /// 复杂对象list
        /// </summary>
        [JsonProperty("cm_list")]
        public List<ComplextMockModel> CmList { get; set; }
    }
}
