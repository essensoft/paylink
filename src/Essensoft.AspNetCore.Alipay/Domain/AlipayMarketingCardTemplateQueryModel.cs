using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardTemplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝卡模板ID（模板创建接口返回的支付宝端模板ID）
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
