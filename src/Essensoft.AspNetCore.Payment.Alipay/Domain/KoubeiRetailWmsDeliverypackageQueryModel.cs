using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsDeliverypackageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsDeliverypackageQueryModel : AlipayObject
    {
        /// <summary>
        /// 运单号（与通知单号二选一，如果都存在，以通知单号查询）
        /// </summary>
        [JsonProperty("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 通知单id（与运单号二选一）
        /// </summary>
        [JsonProperty("notice_order_id")]
        public string NoticeOrderId { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [JsonProperty("work_order_id")]
        public string WorkOrderId { get; set; }
    }
}
