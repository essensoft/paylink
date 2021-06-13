using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceReceiptSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceReceiptSendModel : AlipayObject
    {
        /// <summary>
        /// 订单信息,最大限制10条
        /// </summary>
        [JsonPropertyName("order_list")]
        public List<ReceiptOrderDTO> OrderList { get; set; }

        /// <summary>
        /// 请求id，基于该字段做幂等校验，冲突返回错误ORDER_DUPLICATE
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }
    }
}
