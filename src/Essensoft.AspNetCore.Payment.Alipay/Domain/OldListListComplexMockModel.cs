using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OldListListComplexMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class OldListListComplexMockModel : AlipayObject
    {
        /// <summary>
        /// 复杂模型list
        /// </summary>
        [JsonProperty("cm_list")]
        public List<OldComplextMockModel> CmList { get; set; }
    }
}
