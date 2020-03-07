using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingIndirectcashticketTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingIndirectcashticketTemplateCreateResponse : AlipayResponse
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
        /// 票模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
