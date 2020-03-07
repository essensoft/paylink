using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailInstanceTransferModel Data Structure.
    /// </summary>
    public class KoubeiRetailInstanceTransferModel : AlipayObject
    {
        /// <summary>
        /// 置顶的券id列表信息，id的顺序指定置顶的券的顺序，如果空表示将原先的id删除。列表数量限制为20
        /// </summary>
        [JsonPropertyName("instance_id_list")]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// 券或者电子DM单（VOUCHER、DM），如果字段为空默认为VOUCHER类型
        /// </summary>
        [JsonPropertyName("instance_type")]
        public string InstanceType { get; set; }
    }
}
