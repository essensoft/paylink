using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ListListSmMockModel Data Structure.
    /// </summary>
    public class ListListSmMockModel : AlipayObject
    {
        /// <summary>
        /// 简单模型列表
        /// </summary>
        [JsonProperty("list_simple_model_list")]
        public List<SimpleMockModel> ListSimpleModelList { get; set; }
    }
}
