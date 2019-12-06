using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderCreditQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantOrderCreditQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部订单号,包含字母、数字、下划线，调用方需要保证订单号唯一
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 芝麻订单号
        /// </summary>
        [JsonPropertyName("zm_order_no")]
        public string ZmOrderNo { get; set; }
    }
}
