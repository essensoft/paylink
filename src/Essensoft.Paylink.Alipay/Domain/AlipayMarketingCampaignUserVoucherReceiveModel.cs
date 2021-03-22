using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherReceiveModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignUserVoucherReceiveModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部业务号，是否传入由业务场景决定， 如果传入前缀需要带入ISV信息
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 场景码：默认(DEFAULT) 场景码与业务类型相关，接入时候请务必和支付宝技术对接人确认。需要传入特定业务场景的场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public List<string> SceneCode { get; set; }
    }
}
