using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignSelfVoucherQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignSelfVoucherQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码：默认(DEFAULT)  场景码与业务类型强相关，接入时候请务必和支付宝技术对接人确认。需要传入特定业务场景的场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public List<string> SceneCode { get; set; }

        /// <summary>
        /// 券ID(券唯一标识, 发券接口返回参数)
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
