using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderUpdateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingOrderUpdateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝支付流水号，系统唯一
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 用户停车订单状态，枚举支持： *0：成功。 *1：失败。
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 停车缴费用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 注意：ISV需保证用户 id 的正确性，以免导致用户在停车平台查询不到相关的订单信息。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
