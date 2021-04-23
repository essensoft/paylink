using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashStatusModifyModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignCashStatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 金活动修改后的状态。支持修改为： *PAUSE：活动暂停。 *READY：活动开始。 *CLOSED：活动结束。
        /// </summary>
        [JsonPropertyName("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 现金活动号，通过<a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.campaign.cash.create">alipay.marketing.campaign.cash.create</a>(创建现金活动)接口创建现金活动获取。
        /// </summary>
        [JsonPropertyName("crowd_no")]
        public string CrowdNo { get; set; }
    }
}
