using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialGiftOrderQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialGiftOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户再送礼平台的唯一ID，用于标识具体的调用业务方，需要先在送礼平台进行业务类型的分配之后才看使用。
        /// </summary>
        [JsonPropertyName("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 对应送礼平台的主订单ID，可根据此进行订单查询
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
