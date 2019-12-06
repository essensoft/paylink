using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialGiftVoucherUseModel Data Structure.
    /// </summary>
    public class AlipaySocialGiftVoucherUseModel : AlipayObject
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
        /// 主订单id，核销对应的送礼平台主订单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 当前用户剩余的金额，该金额会作为剩余金额显示到卡包中。注意，需要由商户自行保证该金额的正确性。平台不会存这个剩余金额，也不会做相关校验（除了必须不能小于零外）
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商户通过该接口落卡包后，其支付宝卡包中对应实体（卡、券）的生效时间。该值可以选填。默认生效时间为当前时间。其规则可以在商户后台进行配置。
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 核销金额，即本次用户消费的金额。
        /// </summary>
        [JsonPropertyName("use_price")]
        public string UsePrice { get; set; }

        /// <summary>
        /// 卡码code，改id为商户上传到平台的id。
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
