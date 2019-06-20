using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsOutboundworkConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsOutboundworkConfirmModel : AlipayObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 出库作业id
        /// </summary>
        [JsonProperty("outbound_work_id")]
        public string OutboundWorkId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }
    }
}
