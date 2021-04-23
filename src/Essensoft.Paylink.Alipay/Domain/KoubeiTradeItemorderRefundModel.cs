using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeItemorderRefundModel Data Structure.
    /// </summary>
    public class KoubeiTradeItemorderRefundModel : AlipayObject
    {
        /// <summary>
        /// 口碑订单号，可通过 <a href="https://opendocs.alipay.com/apis/api_1/koubei.trade.itemorder.buy">koubei.trade.itemorder.buy</a>(口碑商品交易购买接口)获取。
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔订单多次退款需要保证唯一。
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
