using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Data Data Structure.
    /// </summary>
    public class Data : AlipayObject
    {
        /// <summary>
        /// 用户id列表
        /// </summary>
        [JsonProperty("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
