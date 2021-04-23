using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherTemplatedetailQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherTemplatedetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 券模板ID。可通过对应产品创建优惠券模板接口获取。如：无资金优惠券可通过<a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.cashlessvoucher.template.create">alipay.marketing.cashlessvoucher.template.create</a>(无资金券模板创建接口)创建券模板；现金抵价券可通过<a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.cashvoucher.template.create">alipay.marketing.cashvoucher.template.create</a>(创建资金券模板)接口创建券模板。
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
