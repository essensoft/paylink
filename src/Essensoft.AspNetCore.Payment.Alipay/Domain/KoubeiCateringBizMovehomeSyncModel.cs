using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringBizMovehomeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringBizMovehomeSyncModel : AlipayObject
    {
        /// <summary>
        /// leads信息列表
        /// </summary>
        [JsonProperty("leads_info_list")]
        public List<KcpLeadsInfo> LeadsInfoList { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }
    }
}
