using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAraterWaitratealgorankQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAraterWaitratealgorankQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 集团统一会员ID
        /// </summary>
        [JsonPropertyName("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 算法打分列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<WaitRateAlgoItem> ItemList { get; set; }

        /// <summary>
        /// 支付宝userId倒数2-3位
        /// </summary>
        [JsonPropertyName("route_uid")]
        public string RouteUid { get; set; }

        /// <summary>
        /// 本次session已点击的itemIds
        /// </summary>
        [JsonPropertyName("session_click_item_ids")]
        public List<string> SessionClickItemIds { get; set; }

        /// <summary>
        /// 本次session已曝光的itemIds
        /// </summary>
        [JsonPropertyName("session_expo_item_ids")]
        public List<string> SessionExpoItemIds { get; set; }
    }
}
