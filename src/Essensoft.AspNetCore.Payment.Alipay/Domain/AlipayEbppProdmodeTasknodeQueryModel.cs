using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeTasknodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeTasknodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        [JsonProperty("task_id")]
        public string TaskId { get; set; }
    }
}
