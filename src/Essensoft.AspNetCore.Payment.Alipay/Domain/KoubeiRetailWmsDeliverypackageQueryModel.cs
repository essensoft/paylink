using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsDeliverypackageQueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsDeliverypackageQueryModel : AlipayObject
    {
        /// <summary>
        /// 运单号（与通知单号二选一，如果都存在，以通知单号查询）
        /// </summary>
        [JsonPropertyName("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 通知单id（与运单号二选一）
        /// </summary>
        [JsonPropertyName("notice_order_id")]
        public string NoticeOrderId { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonPropertyName("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [JsonPropertyName("work_order_id")]
        public string WorkOrderId { get; set; }
    }
}
