using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionMissionQueryModel : AlipayObject
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [JsonProperty("identify_list")]
        public List<string> IdentifyList { get; set; }

        /// <summary>
        /// 主键类型  activity_id：运营活动ID  voucher：商品ID  mission：分佣任务ID
        /// </summary>
        [JsonProperty("identify_type")]
        public string IdentifyType { get; set; }
    }
}
