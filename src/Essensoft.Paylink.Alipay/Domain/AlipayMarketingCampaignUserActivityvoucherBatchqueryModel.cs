using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUserActivityvoucherBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignUserActivityvoucherBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码：默认(DEFAULT)
        /// </summary>
        [JsonPropertyName("scene_code")]
        public List<string> SceneCode { get; set; }

        /// <summary>
        /// 券状态： 可使用(ENABLED)，已核销(即完全使用，USED)，已过期(EXPIRED)
        /// </summary>
        [JsonPropertyName("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
