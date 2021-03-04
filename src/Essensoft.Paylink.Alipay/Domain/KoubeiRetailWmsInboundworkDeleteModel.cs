using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkDeleteModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsInboundworkDeleteModel : AlipayObject
    {
        /// <summary>
        /// 入库作业id
        /// </summary>
        [JsonPropertyName("inbound_work_id")]
        public string InboundWorkId { get; set; }

        /// <summary>
        /// 操作者上下文
        /// </summary>
        [JsonPropertyName("operate_context")]
        public OperateContext OperateContext { get; set; }
    }
}
