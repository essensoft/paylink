using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishCommgroupSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCommgroupSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 通用分组的id,标示组结构的唯一id
        /// </summary>
        [JsonPropertyName("comm_group_id")]
        public string CommGroupId { get; set; }

        /// <summary>
        /// 客制化组模型，新增和更新的时候传出
        /// </summary>
        [JsonPropertyName("kbdish_comm_group_info")]
        public KbdishCommGroupInfo KbdishCommGroupInfo { get; set; }
    }
}
