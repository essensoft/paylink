using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMicropayOrderFreezeResponse.
    /// </summary>
    public class AlipayMicropayOrderFreezeResponse : AlipayResponse
    {
        /// <summary>
        /// 冻结订单详情
        /// </summary>
        [JsonPropertyName("micro_pay_order_detail")]
        public MicroPayOrderDetail MicroPayOrderDetail { get; set; }
    }
}
