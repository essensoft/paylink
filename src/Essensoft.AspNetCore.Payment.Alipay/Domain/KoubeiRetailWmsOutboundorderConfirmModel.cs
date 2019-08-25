using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsOutboundorderConfirmModel : AlipayObject
    {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 出库通知单id
        /// </summary>
        [JsonProperty("outbound_order_id")]
        public string OutboundOrderId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 出库单最终状态：FINISHED（完成），CANCELLED（取消）
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
