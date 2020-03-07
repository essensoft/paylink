using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsOutboundworkDeleteModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsOutboundworkDeleteModel : AlipayObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonPropertyName("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 出库作业id
        /// </summary>
        [JsonPropertyName("outbound_work_id")]
        public string OutboundWorkId { get; set; }
    }
}
