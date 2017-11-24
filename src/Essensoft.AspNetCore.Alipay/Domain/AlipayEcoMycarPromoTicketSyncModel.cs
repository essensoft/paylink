using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarPromoTicketSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarPromoTicketSyncModel : AlipayObject
    {
        /// <summary>
        /// 营销活动ID
        /// </summary>
        [JsonProperty("active_id")]
        public string ActiveId { get; set; }

        /// <summary>
        /// 需要同步的卡券信息
        /// </summary>
        [JsonProperty("code_no_list")]
        public List<CodeNOList> CodeNoList { get; set; }

        /// <summary>
        /// 卡券来源
        /// </summary>
        [JsonProperty("source_type")]
        public string SourceType { get; set; }
    }
}
