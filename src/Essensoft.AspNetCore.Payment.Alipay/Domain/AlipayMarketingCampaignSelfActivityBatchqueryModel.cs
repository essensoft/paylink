using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
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
