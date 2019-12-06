using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeItemorderRefundModel Data Structure.
    /// </summary>
    public class KoubeiTradeItemorderRefundModel : AlipayObject
    {
        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔订单多次退款需要保证唯一
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 退款原因描述
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 退货明细信息
        /// </summary>
        [JsonPropertyName("refund_infos")]
        public List<RefundInfo> RefundInfos { get; set; }
    }
}
