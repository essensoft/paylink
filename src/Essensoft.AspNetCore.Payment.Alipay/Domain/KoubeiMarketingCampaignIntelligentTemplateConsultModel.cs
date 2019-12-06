using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentTemplateConsultModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentTemplateConsultModel : AlipayObject
    {
        /// <summary>
        /// 根据不同场景,过滤不同的门店数据,可参考值:CREATE_NORMAL:正常创建;RENEWAL_OLD:原方案续期;RENEWAL_NEW:新方案续期
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonPropertyName("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 结合biz_scene一起使用,值为RENEWAL_OLD:原方案续期、RENEWAL_NEW:新方案续期,要求必传
        /// </summary>
        [JsonPropertyName("promo_id")]
        public string PromoId { get; set; }

        /// <summary>
        /// 默认(不传shop_ids门店)使用待体验门店匹配适用模板，指定门店列表(shop_ids)后根据入参匹配适用模板
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
