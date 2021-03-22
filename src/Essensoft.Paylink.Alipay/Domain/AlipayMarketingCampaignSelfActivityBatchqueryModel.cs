using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignSelfActivityBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignSelfActivityBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码：默认(DEFAULT)
        /// </summary>
        [JsonPropertyName("scene_code")]
        public List<string> SceneCode { get; set; }
    }
}
