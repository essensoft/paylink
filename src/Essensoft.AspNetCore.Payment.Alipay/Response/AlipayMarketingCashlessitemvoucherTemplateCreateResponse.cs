using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCashlessitemvoucherTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCashlessitemvoucherTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 使用一张单品券用户可以获得的最大优惠。计算方式和单张券的最大优惠的上限请参考产品说明文档
        /// </summary>
        [JsonPropertyName("voucher_discount_limit")]
        public string VoucherDiscountLimit { get; set; }
    }
}
