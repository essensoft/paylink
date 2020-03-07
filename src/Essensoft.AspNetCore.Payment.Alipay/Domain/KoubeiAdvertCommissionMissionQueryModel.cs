using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionQueryModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionMissionQueryModel : AlipayObject
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [JsonPropertyName("identify_list")]
        public List<string> IdentifyList { get; set; }

        /// <summary>
        /// 主键类型  activity_id：运营活动ID  voucher：商品ID  mission：分佣任务ID
        /// </summary>
        [JsonPropertyName("identify_type")]
        public string IdentifyType { get; set; }
    }
}
