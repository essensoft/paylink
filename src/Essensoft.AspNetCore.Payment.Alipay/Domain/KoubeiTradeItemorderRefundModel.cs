using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔订单多次退款需要保证唯一
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 退款原因描述
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 退货明细信息
        /// </summary>
        [JsonProperty("refund_infos")]
        public List<RefundInfo> RefundInfos { get; set; }
    }
}
