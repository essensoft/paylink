using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPointOrderGetResponse.
    /// </summary>
    public class AlipayPointOrderGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝集分宝发放流水号
        /// </summary>
        [JsonPropertyName("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 发放时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付宝集分宝发放者用户ID
        /// </summary>
        [JsonPropertyName("dispatch_user_id")]
        public string DispatchUserId { get; set; }

        /// <summary>
        /// 向用户展示集分宝发放备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// isv提供的发放号订单号，由数字和字母组成，最大长度为32为，需要保证每笔发放的唯一性，支付宝会对该参数做唯一性控制。如果使用同样的订单号，支付宝将返回订单号已经存在的错误
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 集分宝发放流水状态，I表示处理中，S表示成功，F表示失败
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 发放集分宝的数量
        /// </summary>
        [JsonPropertyName("point_count")]
        public long PointCount { get; set; }

        /// <summary>
        /// 支付宝集分宝接收者用户ID
        /// </summary>
        [JsonPropertyName("receive_user_id")]
        public string ReceiveUserId { get; set; }
    }
}
