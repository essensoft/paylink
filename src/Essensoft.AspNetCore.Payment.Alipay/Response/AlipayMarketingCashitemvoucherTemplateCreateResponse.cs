using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCashitemvoucherTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCashitemvoucherTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模板支付确认链接
        /// </summary>
        [JsonPropertyName("confirm_uri")]
        public string ConfirmUri { get; set; }

        /// <summary>
        /// 资金订单号，模板支付时需要
        /// </summary>
        [JsonPropertyName("fund_order_no")]
        public string FundOrderNo { get; set; }

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
