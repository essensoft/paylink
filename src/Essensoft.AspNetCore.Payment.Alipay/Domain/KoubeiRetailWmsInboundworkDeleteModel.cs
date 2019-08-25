using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsInboundworkDeleteModel : AlipayObject
    {
        /// <summary>
        /// 入库作业id
        /// </summary>
        [JsonProperty("inbound_work_id")]
        public string InboundWorkId { get; set; }

        /// <summary>
        /// 操作者上下文
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }
    }
}
