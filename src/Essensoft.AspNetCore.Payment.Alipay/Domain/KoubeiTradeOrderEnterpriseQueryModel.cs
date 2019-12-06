using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeOrderEnterpriseQueryModel Data Structure.
    /// </summary>
    public class KoubeiTradeOrderEnterpriseQueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑订单号，和外部订单号不能同时为空
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 创建订单时传入的商户订单号,和口碑订单号不能同时为空
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户签约支付宝的账号,和口碑订单号不能同时为空
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}
