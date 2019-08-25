using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCouponTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCouponTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模板支付确认链接
        /// </summary>
        [JsonProperty("confirm_uri")]
        public string ConfirmUri { get; set; }

        /// <summary>
        /// 资金订单号，模板支付时需要
        /// </summary>
        [JsonProperty("fund_order_no")]
        public string FundOrderNo { get; set; }

        /// <summary>
        /// 红包模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
