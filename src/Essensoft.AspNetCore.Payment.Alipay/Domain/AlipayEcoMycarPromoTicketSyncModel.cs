using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarPromoTicketSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarPromoTicketSyncModel : AlipayObject
    {
        /// <summary>
        /// 营销活动ID
        /// </summary>
        [JsonPropertyName("active_id")]
        public string ActiveId { get; set; }

        /// <summary>
        /// 需要同步的卡券信息
        /// </summary>
        [JsonPropertyName("code_no_list")]
        public List<CodeNOList> CodeNoList { get; set; }

        /// <summary>
        /// 卡券来源
        /// </summary>
        [JsonPropertyName("source_type")]
        public string SourceType { get; set; }
    }
}
