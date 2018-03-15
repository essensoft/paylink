using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvchannelUnbindModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionAdvchannelUnbindModel : AlipayObject
    {
        /// <summary>
        /// 广告ID
        /// </summary>
        [JsonProperty("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 渠道ID列表
        /// </summary>
        [JsonProperty("channel_id_list")]
        public List<string> ChannelIdList { get; set; }
    }
}
