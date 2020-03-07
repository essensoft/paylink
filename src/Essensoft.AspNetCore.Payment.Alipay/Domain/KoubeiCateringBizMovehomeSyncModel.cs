using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringBizMovehomeSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringBizMovehomeSyncModel : AlipayObject
    {
        /// <summary>
        /// leads信息列表
        /// </summary>
        [JsonPropertyName("leads_info_list")]
        public List<KcpLeadsInfo> LeadsInfoList { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}
