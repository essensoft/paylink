using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeOrderQueryModel Data Structure.
    /// </summary>
    public class KoubeiTradeOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
