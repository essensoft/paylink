using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringKmsOrderSyncResponse.
    /// </summary>
    public class KoubeiCateringKmsOrderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 开发者提示信息, 如果重复推单或重复退款, 会通过这个字段提示,  无其他业务作用.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
