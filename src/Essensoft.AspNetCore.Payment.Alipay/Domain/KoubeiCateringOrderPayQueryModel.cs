using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderPayQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringOrderPayQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部支付订单号,唯一标识本次支付的requestID
        /// </summary>
        [JsonPropertyName("out_pay_no")]
        public string OutPayNo { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [JsonPropertyName("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }
    }
}
