using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialGiftOrderConfirmModel Data Structure.
    /// </summary>
    public class AlipaySocialGiftOrderConfirmModel : AlipayObject
    {
        /// <summary>
        /// 商户通过该接口落卡包后，其支付宝卡包中对应实体（卡、券）的失效时间。该值可以选填。【注意：如果不填写，默认为生效时间后3年】。其时间规则可以在商户后台进行配置。
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商户再送礼平台的唯一ID，用于标识具体的调用业务方，需要先在送礼平台进行业务类型的分配之后才看使用。
        /// </summary>
        [JsonPropertyName("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 送礼平台方的主订单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户通过该接口落卡包后，其支付宝卡包中对应实体（卡、券）的生效时间。该值可以选填。默认生效时间为当前时间。其规则可以在商户后台进行配置。
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 订单确认金额，用户可选填，如果不填则使用SKU票面价值。如果填写则使用该填写的价格在卡包中展示（如果后台配置为落卡包）。注意支付宝端不会校验该金额的有效性（但会校验是否不小于零），需要商户自行保证。
        /// </summary>
        [JsonPropertyName("total_price")]
        public string TotalPrice { get; set; }
    }
}
