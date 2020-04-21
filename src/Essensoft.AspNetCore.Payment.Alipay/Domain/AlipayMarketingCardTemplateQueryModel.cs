using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardTemplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝卡模板ID（模板创建接口返回的支付宝端模板ID）
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
