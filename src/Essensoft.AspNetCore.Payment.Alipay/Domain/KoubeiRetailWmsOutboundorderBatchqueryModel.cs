using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsOutboundorderBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonPropertyName("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 外部业务单号（出库通知单id列表列表二选一）
        /// </summary>
        [JsonPropertyName("out_biz_no_list")]
        public List<string> OutBizNoList { get; set; }

        /// <summary>
        /// 出库通知单id列表（与外部业务单号列表二选一）
        /// </summary>
        [JsonPropertyName("outbound_order_id_list")]
        public List<string> OutboundOrderIdList { get; set; }
    }
}
