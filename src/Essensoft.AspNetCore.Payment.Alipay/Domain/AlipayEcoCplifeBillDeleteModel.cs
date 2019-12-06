using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeBillDeleteModel Data Structure.
    /// </summary>
    public class AlipayEcoCplifeBillDeleteModel : AlipayObject
    {
        /// <summary>
        /// 指定小区下待删除的物业费账单应收明细条目ID列表，一次最多删除1000条，如果明细条目已被支付或在支付中，则无法被删除。接口会返回无法删除的明细条目ID列表。
        /// </summary>
        [JsonPropertyName("bill_entry_id_list")]
        public List<string> BillEntryIdList { get; set; }

        /// <summary>
        /// 支付宝社区小区统一编号，必须在物业账号名下存在。
        /// </summary>
        [JsonPropertyName("community_id")]
        public string CommunityId { get; set; }
    }
}
