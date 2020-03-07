using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvchannelUnbindModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionAdvchannelUnbindModel : AlipayObject
    {
        /// <summary>
        /// 广告ID
        /// </summary>
        [JsonPropertyName("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 渠道ID列表
        /// </summary>
        [JsonPropertyName("channel_id_list")]
        public List<string> ChannelIdList { get; set; }
    }
}
