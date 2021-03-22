using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherConsultModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignUserVoucherConsultModel : AlipayObject
    {
        /// <summary>
        /// 活动id列表
        /// </summary>
        [JsonPropertyName("activity_id_list")]
        public List<string> ActivityIdList { get; set; }

        /// <summary>
        /// 场景码：默认(DEFAULT)
        /// </summary>
        [JsonPropertyName("scene_code")]
        public List<string> SceneCode { get; set; }
    }
}
