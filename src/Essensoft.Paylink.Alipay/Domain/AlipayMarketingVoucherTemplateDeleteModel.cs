using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherTemplateDeleteModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherTemplateDeleteModel : AlipayObject
    {
        /// <summary>
        /// 券模板 id，可通过<a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.voucher.templatelist.query">alipay.marketing.voucher.templatelist.query</a>(查询券模板列表)接口查询获取。
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
