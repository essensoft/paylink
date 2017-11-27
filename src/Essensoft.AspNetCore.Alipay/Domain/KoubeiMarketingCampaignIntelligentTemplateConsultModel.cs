using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentTemplateConsultModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentTemplateConsultModel : AlipayObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 默认(不传shop_ids门店)使用待体验门店匹配适用模板，指定门店列表(shop_ids)后根据入参匹配适用模板
        /// </summary>
        [JsonProperty("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
