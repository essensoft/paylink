using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ManagerVO Data Structure.
    /// </summary>
    [Serializable]
    public class ManagerVO : AlipayObject
    {
        /// <summary>
        /// 管理人员名称
        /// </summary>
        [JsonProperty("manager_name")]
        public string ManagerName { get; set; }

        /// <summary>
        /// 职务
        /// </summary>
        [JsonProperty("manager_position")]
        public string ManagerPosition { get; set; }
    }
}
