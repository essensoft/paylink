using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsWorkQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsWorkQueryModel : AlipayObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [JsonProperty("work_id")]
        public string WorkId { get; set; }
    }
}
