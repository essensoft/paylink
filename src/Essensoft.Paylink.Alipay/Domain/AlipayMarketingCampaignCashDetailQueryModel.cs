using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashDetailQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignCashDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 现金活动号，通过<a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.campaign.cash.create">alipay.marketing.campaign.cash.create</a>(创建现金活动)接口创建现金活动获取。
        /// </summary>
        [JsonPropertyName("crowd_no")]
        public string CrowdNo { get; set; }
    }
}
