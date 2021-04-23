using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVunueOrdervoucherVerifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceSportsVunueOrdervoucherVerifyModel : AlipayObject
    {
        /// <summary>
        /// 核销描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务商内部唯一订单号
        /// </summary>
        [JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 服务商提供的外部凭证ID
        /// </summary>
        [JsonPropertyName("out_voucher_id")]
        public string OutVoucherId { get; set; }

        /// <summary>
        /// 剩余核销次数
        /// </summary>
        [JsonPropertyName("verify_count")]
        public string VerifyCount { get; set; }

        /// <summary>
        /// 核销状态，1-未核销，2-核销完成
        /// </summary>
        [JsonPropertyName("verify_status")]
        public string VerifyStatus { get; set; }
    }
}
