using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WriteoffOrderParam Data Structure.
    /// </summary>
    public class WriteoffOrderParam : AlipayObject
    {
        /// <summary>
        /// 当前子订单是否已结清
        /// </summary>
        [JsonPropertyName("is_clearance")]
        public bool IsClearance { get; set; }

        /// <summary>
        /// 主订单号
        /// </summary>
        [JsonPropertyName("order_num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        [JsonPropertyName("sub_order_num")]
        public string SubOrderNum { get; set; }
    }
}
