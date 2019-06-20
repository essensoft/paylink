using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpEntityMonitorSetModel : AlipayObject
    {
        /// <summary>
        /// 联系人列表
        /// </summary>
        [JsonProperty("contact_list")]
        public string ContactList { get; set; }

        /// <summary>
        /// 方案ID
        /// </summary>
        [JsonProperty("solution_id")]
        public string SolutionId { get; set; }
    }
}
