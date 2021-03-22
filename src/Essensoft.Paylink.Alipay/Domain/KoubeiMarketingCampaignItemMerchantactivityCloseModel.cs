using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCloseModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityCloseModel : AlipayObject
    {
        /// <summary>
        /// 活动id。通过 <a href="https://opendocs.alipay.com/pre-apis/api_pre/koubei.marketing.campaign.item.merchantactivity.create">koubei.marketing.campaign.item.merchantactivity.create</a>(商户创建商品代金券)获取。
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }
    }
}
