using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderConfirmModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsInboundorderConfirmModel : AlipayObject
    {
        /// <summary>
        /// 入库通知单号
        /// </summary>
        [JsonPropertyName("inbound_order_id")]
        public string InboundOrderId { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonPropertyName("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 入库单最终状态  FINISHED（完成），CANCELLED（取消）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
