using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsInboundworkConfirmModel : AlipayObject
    {
        /// <summary>
        /// 入库作业id
        /// </summary>
        [JsonProperty("inbound_work_id")]
        public string InboundWorkId { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }
    }
}
